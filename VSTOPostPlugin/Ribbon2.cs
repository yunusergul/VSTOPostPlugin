using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Net;
using System.Windows.Forms;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;
using Nancy.Json;

namespace WordAddIn9
{
    public partial class Ribbon2
    {
        string folder_tt = @"C:\Users\yunus\AppData\Local\WBD\data.json";
        string folder_tt2 = @"C:\Users\yunus\AppData\Local\WBD\data2.json";

        public  void TestRefType()
        {
            
       
            if (File.Exists(folder_tt) == true)
            {
                group1.Visible = true;
                group2.Visible = true;
                group3.Visible = true;
                group4.Visible = false;
                string path = Path.Combine(Environment.CurrentDirectory, folder_tt);
                string json2 = File.ReadAllText(path);
                JObject rss = JObject.Parse(json2);
                label3.Label = (string)rss["name"];

            }
            else
            {
                group1.Visible = false;
                group2.Visible = false;
                group3.Visible = false;
                group4.Visible = true;
            }
        }
        
        private void Ribbon2_Load(object sender, RibbonUIEventArgs e)
        {
            TestRefType();
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                string URL = "http://127.0.0.1:8080/api/login";
                System.Net.WebRequest webRequest = System.Net.WebRequest.Create(URL);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                Stream reqStream = webRequest.GetRequestStream();
                string postData = "email=" + editBox3.Text + "&password=" + editBox4.Text;
                byte[] postArray = Encoding.ASCII.GetBytes(postData);
                reqStream.Write(postArray, 0, postArray.Length);
                reqStream.Close();
                StreamReader sr = new StreamReader(webRequest.GetResponse().GetResponseStream());
                string Result = sr.ReadToEnd();


                FileStream fs = new FileStream(folder_tt, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(Result);
                sw.Flush();
                sw.Close();
                fs.Close();
                TestRefType();
            }
            catch (Exception y)
            {
                string ErrorString = y.Message;
                System.Windows.Forms.MessageBox.Show(ErrorString);
            }
            
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            string folder_tt = @"C:\Users\yunus\AppData\Local\WBD\cc.txt";
            string folder_tt2 = @"C:\Users\%username%\";
            FileStream fs = new FileStream(folder_tt, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            label1.Label = yazi + folder_tt2;
            label3.Label = Environment.UserDomainName;
            label4.Label = Environment.NewLine;


            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            string XML = doc.Content.WordOpenXML;
            string htmls = doc.Content.XML;
            // XML Changes

            using (WebClient client = new WebClient())
            {
                try
                {
                    #region POST YAPILIYOR
                    string postUrl = "http://127.0.0.1:8080/wordInPost/";
                    var gelenYanit = client.UploadValues(postUrl, new NameValueCollection() { { "name", htmls } });
                    #endregion
                    #region POST NETİCESİNDE ÇIKTI ALINIYOR
                    string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                    System.Windows.Forms.MessageBox.Show(result);

                    #endregion
                }
                catch 
                {
                    
                }
            }
            doc.Content.InsertXML(XML);
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            File.Delete(folder_tt);
            TestRefType();
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                Document oWordDoc = Globals.ThisAddIn.Application.ActiveDocument;
                Paragraph oPara1 = null;
                string path = Path.Combine(Environment.CurrentDirectory, folder_tt);
                string json2 = File.ReadAllText(path);
                JObject rss = JObject.Parse(json2);
                string token = (string)rss["token"];




                string url = "http://localhost:8080/api/cs?token=" + token;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                var webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();
                var responseReader = new StreamReader(webStream);
                var response = responseReader.ReadToEnd();
                FileStream fs = new FileStream(folder_tt2, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(response);
                sw.Flush();
                sw.Close();
                fs.Close();
                responseReader.Close();


                string pathd = Path.Combine(Environment.CurrentDirectory, folder_tt2);
                string jsond = File.ReadAllText(pathd);
                JObject rssd = JObject.Parse(jsond);
                string info = (string)rssd["name"];

                string TextToWrite = info;
                Object oMissing = System.Reflection.Missing.Value;
                oPara1 = oWordDoc.Content.Paragraphs.Add(ref oMissing);
                oPara1.Range.Text = TextToWrite;








            }
            catch (Exception y)
            {
                string ErrorString = y.Message;
                System.Windows.Forms.MessageBox.Show(ErrorString);
            }
        }
    }
}
