using NetDemo.Utils;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NetDemo
{
    public partial class Form1 : Form
    {
        private static string updateUrl = "hello";
        private const string filePath = @"temp/update_file.exe";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_LoadAsync(object sender, EventArgs e)
        {
            currentVersion.Text = Global.Version;
            currentBuild.Text = Global.Build.ToString();
            btn_DownloadUdate.Enabled = false;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            button1.Enabled = false;

            string res = await Net.Get(Global.CheckUpdateUrl);
            //string res = Net.Get_2(Global.CheckUpdateUrl);

            JObject JObj = (JObject)JsonConvert.DeserializeObject(res);

            try
            {
                string version = JObj["version"].ToString();
                int build = (int)JObj["build"];
                string updateLog = JObj["updateLog"].ToString();
                updateUrl = JObj["updateUrl"].ToString();

                if (build > Global.Build)
                {
                    richTextBox1.AppendText($"发现新版本！\r\n版本号：{version}({build})\r\n更新内容：\r\n{updateLog}");
                    btn_DownloadUdate.Enabled = true;
                }
                else
                {
                    btn_DownloadUdate.Enabled = false;
                    MessageBox.Show("你当前使用的是最新版本", "检查更新");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            button1.Enabled = true;
        }

        private void btn_DownloadUdate_Click(object sender, EventArgs e)
        {
            Net.DownloadUpdate(updateUrl, filePath, prog_DownloadUpdate, btn_DownloadUdate);
        }
    }
}