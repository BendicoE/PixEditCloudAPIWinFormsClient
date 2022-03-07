using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.IO;

namespace PixEditCloudAPIClient
{
    public partial class MainForm : Form
    {
        static HttpClient _client;

        private string _authToken = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void linkOutputFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new(linkOutputFile.Text);
            psi.UseShellExecute = true;
            try
            {
                Process.Start(psi);
            }
            catch
            { }
        }

        private string BaseUri
        {
            get
            {
                if (!txtUrl.Text.EndsWith('/'))
                    txtUrl.Text += '/';
                return txtUrl.Text;
            }
        }

        private string OperationUri(string operation, params string[] p)
        {
            string uri = $"{BaseUri}{operation}";

            if (p != null && p.Length > 0)
            {
                uri += $"?{p[0]}";

                if (p.Length > 1)
                {
                    for (int i = 1; i < p.Length; i++)
                        uri += $";{p[i]}";
                }
            }

            return uri;
        }

        private async void Connect()
        {
            _client = new HttpClient();

            _client.BaseAddress = new(BaseUri);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));

            try
            {
                HttpResponseMessage response = await _client.GetAsync(OperationUri(""));

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    JObject info = JObject.Parse(jsonString);
                    txtInfo.Text = $"{info["appName"]}\r\nVersion {info["appVersion"]}\r\nPublished {info["publishedDate"]}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtUrl.Text = Settings.Default.Url;
            txtUsername.Text = Settings.Default.Username;
            txtSerialNo.Text = Settings.Default.SerialNo;
            txtPassword.Text = Settings.Default.Password;
            txtSubscriptionKey.Text = Settings.Default.SubscriptionKey;
            cmbOutputFileFormat.SelectedIndex = Settings.Default.SelectedOutputFormat;

            Connect();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Url = txtUrl.Text;
            Settings.Default.Username = txtUsername.Text;
            Settings.Default.SerialNo = txtSerialNo.Text;
            Settings.Default.Password = txtPassword.Text;
            Settings.Default.SubscriptionKey = txtSubscriptionKey.Text;
            Settings.Default.SelectedOutputFormat = cmbOutputFileFormat.SelectedIndex;
            Settings.Default.Save();
        }

        private async void Authenticate_Click(object sender, EventArgs e)
        {
            var byteArray = Encoding.ASCII.GetBytes($"{txtUsername.Text}+{txtSerialNo.Text}:{txtPassword.Text}");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            try
            {
                HttpResponseMessage response = await _client.GetAsync(OperationUri("Authenticate"));

                if (response.IsSuccessStatusCode)
                {
                    _authToken = await response.Content.ReadAsStringAsync();
                    lblAuthenticated.Text = "OK";
                    btnConvert.Enabled = true;
                }
                else
                {
                    _authToken = "";
                    lblAuthenticated.Text = "Failed";
                }
            }
            catch (Exception ex)
            {
                _authToken = "";
                lblAuthenticated.Text = "";
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new();
            dlg.Filter = "PDF documents (*.pdf)|*.pdf|MS Office Documents (*.docx;*.doc;*.xlsx;*.xls;*.pptx;*.ppt)|*.docx;*.doc;*.xlsx;*.xls;*.pptx;*.ppt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
                txtFileName.Text = dlg.FileName;
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFileName.Text))
            {
                UseWaitCursor = true;

                try
                {
                    string uri = OperationUri("Convert", $"Format={cmbOutputFileFormat.SelectedValue}", "OCR=true");
                    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _authToken);
                    string outputFileName = Path.Combine(
                        Path.GetDirectoryName(txtFileName.Text),
                        Path.ChangeExtension(Path.GetFileNameWithoutExtension(txtFileName.Text) + " (Converted)", "pdf"));

                    using (var form = new MultipartFormDataContent())
                    {
                        using (var fs = File.OpenRead(txtFileName.Text))
                        {
                            using (var streamContent = new StreamContent(fs))
                            {
                                using (var fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync()))
                                {
                                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

                                    form.Add(fileContent, "file", Path.GetFileName(txtFileName.Text));
                                    HttpResponseMessage response = await _client.PostAsync(uri, form);
                                    if (response.IsSuccessStatusCode)
                                    {
                                        if (File.Exists(outputFileName))
                                            File.Delete(outputFileName);

                                        using (var outputStream = File.Create(outputFileName))
                                        {
                                            var responseStream = await response.Content.ReadAsStreamAsync();
                                            await responseStream.CopyToAsync(outputStream);
                                            linkOutputFile.Text = outputFileName;
                                            UseWaitCursor = false;
                                        }
                                    }
                                    else
                                    {
                                        UseWaitCursor = false;
                                        MessageBox.Show($"Conversion failed: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    UseWaitCursor = false;
                    MessageBox.Show($"Conversion failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }
    }
}
