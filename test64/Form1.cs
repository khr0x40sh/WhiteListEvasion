using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace test64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string comm="C:\\Windows\\System32\\cmd.exe /C ping 127.0.0.1";
        public string output = "";
        
        private void browsebtn_Click(object sender, EventArgs e)
        {
        //    openFileDialog1.ShowDialog();
         //   textBox1.Text = openFileDialog1.FileName;
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            //ActiveForm.Text += value;
            richTextBox1.Text = value;
        }

        private void exBtn_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text)))
            {
                comm = textBox1.Text;
            }

            //AppDomain a = AppDomain.CurrentDomain;
            //a.ExecuteAssembly(comm);  //System.Net.Security Error

            //WebClient wC = new WebClient();
            //wC.DownloadFile("http://172.21.196.127/files/scripts64.exe", "script64.exe");     //System.Net.Security Error

            //StreamWriter sW = new StreamWriter("C:\\Users\\Public\\Downloads\\test.txt");     //System.Net.Security Error
            //StreamReader sR = new StreamReader("C:\\Users\\Public\\Downloads\\desktop.ini");  //System.Net.Security Error
            
            Thread t = new Thread(execT);
            t.Start();                                                                        //System.Net.Security Error 
            Thread.Sleep(1500);
        }

        private void execT()
        {
            string[] stuff = comm.Split(' ');
            string cmd = stuff[0];
            string args = "";
            for(int i=1;i<stuff.Length;i++)
            {
                args += stuff[i]+" ";
            }
            ProcessStartInfo s = new ProcessStartInfo();
            s.FileName = cmd;
            s.Arguments = args;
            s.CreateNoWindow = true;
            s.UseShellExecute = false;
            s.WindowStyle = ProcessWindowStyle.Normal;
            s.RedirectStandardOutput = true;
            s.RedirectStandardError = true;
           
            using (Process p = Process.Start(s))
            {
                using (StreamReader reader = p.StandardOutput)
                {
                    output = reader.ReadToEnd();
                }
            }
            AppendTextBox(output);
        }


        private void DownloadStringBtn_Click(object sender, EventArgs e)
        {
            string url = textBox2.Text;
            WebClient wC = new WebClient();
            string temp = wC.DownloadString(url);   //ensure has http, since this is test code I'm not checking it for you.
            //wC.DownloadFile("http://172.21.196.127/files/scripts64.exe", "script64.exe");     //System.Net.Security Error
            richTextBox1.Text = temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
