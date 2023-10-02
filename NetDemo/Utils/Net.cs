using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NetDemo.Utils
{
    internal class Net
    {
        private static HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// 发起一个 GET 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns>响应体</returns>
        public static async Task<string> Get(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return string.Empty;
            }

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        /// <summary>
        /// 发起一个 POST 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public static async Task<string> Post(string url, Dictionary<string, string> param)
        {
            HttpContent httpContent = new FormUrlEncodedContent(param);
            HttpResponseMessage response = await _httpClient.PostAsync(url, httpContent);

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// 【已废弃】发起一个 GET 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns>返回体</returns>
        public static string Get_2(string url)
        {
            // 请勿使用 WebRequest 或其派生类进行新开发。 请改用该 System.Net.Http.HttpClient 类。
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

        // 下载文件的方法，改进了.net6中WebRequest废弃的方法，使用httpclient
        public static async void DownloadUpdate(string url, string filePath, ProgressBar prog, Button btn)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            btn.Enabled = false;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    //获取文件后缀
                    //string extension = Path.GetExtension(response.RequestMessage.RequestUri.ToString());
                    using (FileStream fileStream = new FileStream(filePath, FileMode.CreateNew))
                    {
                        byte[] buffer = new byte[1024 * 50];
                        int readLength = 0;
                        int length;
                        //设置进度条的总长度
                        prog.Maximum = (int)stream.Length;
                        while ((length = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                        {
                            Application.DoEvents();
                            readLength += length;
                            prog.Value = readLength;
                            // 写入到文件
                            fileStream.Write(buffer, 0, length);
                            Application.DoEvents();
                        }
                    }
                }
                // TODO：下载完成
                btn.Enabled = true;
                MessageBox.Show("补丁下载完成，即将更新", "通用更新程序");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
