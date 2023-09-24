using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vosk;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;


using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using SpeechRecognizer = Microsoft.CognitiveServices.Speech.SpeechRecognizer;
using System.Threading;

namespace OAKSpeechToText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        public string aa = "";
        string alltext = "";
        string errorss = "";
        void ConverttotextwithPhyton10sec()
        {

            int start = 0;
            int end = 10;
            string inputfile = textBox1.Text;
            var ffProbe = new NReco.VideoInfo.FFProbe();
            var videoInfo = ffProbe.GetMediaInfo(inputfile);
            int duration = Convert.ToInt32(videoInfo.Duration.TotalSeconds);
            string newfilename = Path.GetFileNameWithoutExtension(textBox1.Text);
            while (start < duration)
            {
                string outputFilename = $@"{"temp.wav"}";
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "ffmpeg.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (start == 0)
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
                else
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start - 1} -t {end + 1} \"{outputFilename}\"";

                using (Process exeprocess = Process.Start(startInfo))
                {
                    exeprocess.WaitForExit();

                }
                if (rbEnglish.Checked)
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }

                }
                else
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv_TR.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }
                }

                if (File.Exists("temp.wav"))
                {
                    File.Delete("temp.wav");
                }
                if (File.Exists("ses1.txt"))
                {
                    if (rbTurkish.Checked)
                    {
                        string yardim = "";
                        StreamReader sr = new StreamReader(String.Format(@"{0}\ses1.txt", System.Windows.Forms.Application.StartupPath), Encoding.GetEncoding("iso-8859-9"), false);
                        alltext += " " + sr.ReadToEnd();
                        sr.Close();
                        alltext += " " + yardim;
                    }
                    else
                    {
                        alltext += " " + File.ReadAllText("ses1.txt");
                    }


                }
                else
                {
                    errorss += " " + start.ToString() + "_ " + end.ToString();
                }
                if (File.Exists("ses1.txt"))
                {
                    File.Delete("ses1.txt");
                }
                richTextBox1.Text = alltext;
                start += end;
                if (start == duration)
                    break;

            }
            if (start != duration)
            {
                start -= end;
                int kalan = duration - start;

                string outputFilename = $@"{"temp.wav"}";
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "ffmpeg.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (start == 0)
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
                else
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start - 1} -t {end + 1} \"{outputFilename}\"";
                using (Process exeprocess3 = Process.Start(startInfo))
                {
                    exeprocess3.WaitForExit();

                }
                if (rbEnglish.Checked)
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }

                }
                else
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv_TR.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }
                }
                if (File.Exists("temp.wav"))
                {
                    File.Delete("temp.wav");
                }
                if (File.Exists("ses1.txt"))
                {
                    if (rbTurkish.Checked)
                    {
                        string yardim = "";
                        StreamReader sr = new StreamReader(String.Format(@"{0}\ses1.txt", System.Windows.Forms.Application.StartupPath), Encoding.GetEncoding("iso-8859-9"), false);
                        alltext += " " + sr.ReadToEnd();
                        sr.Close();
                        alltext += " " + yardim;
                    }
                    else
                    {
                        alltext += " " + File.ReadAllText("ses1.txt");
                    }


                }
                else
                {
                    errorss += " " + start.ToString() + "_ " + end.ToString();
                }


                if (File.Exists("ses1.txt"))
                {
                    File.Delete("ses1.txt");
                }
            }
        }

        void ConverttotextwithPhyton50sec()
        {

            int start = 0;
            int end = 50;
            string inputfile = textBox1.Text;
            var ffProbe = new NReco.VideoInfo.FFProbe();
            var videoInfo = ffProbe.GetMediaInfo(inputfile);
            int duration = Convert.ToInt32(videoInfo.Duration.TotalSeconds);
            string newfilename = Path.GetFileNameWithoutExtension(textBox1.Text);
            while (start < duration)
            {
                string outputFilename = $@"{"temp.wav"}";
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "ffmpeg.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (start == 0)
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
                else
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start - 1} -t {end + 1} \"{outputFilename}\"";

                using (Process exeprocess = Process.Start(startInfo))
                {
                    exeprocess.WaitForExit();

                }
                if (rbEnglish.Checked)
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }

                }
                else
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv_TR.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }
                }
                if (File.Exists("temp.wav"))
                {
                    File.Delete("temp.wav");
                }
                if (File.Exists("ses1.txt"))
                {
                    if (rbTurkish.Checked)
                    {
                        string yardim = "";
                        StreamReader sr = new StreamReader(String.Format(@"{0}\ses1.txt", System.Windows.Forms.Application.StartupPath), Encoding.GetEncoding("iso-8859-9"), false);
                        alltext += " " + sr.ReadToEnd();
                        sr.Close();
                        alltext += " " + yardim;
                    }
                    else
                    {
                        alltext += " " + File.ReadAllText("ses1.txt");
                    }


                }
                else
                {
                    errorss += " " + start.ToString() + "_ " + end.ToString();
                }
                if (File.Exists("ses1.txt"))
                {
                    File.Delete("ses1.txt");
                }
                richTextBox1.Text = alltext;
                start += end;
                if (start == duration)
                    break;

            }
            if (start != duration)
            {
                start -= end;
                int kalan = duration - start;

                string outputFilename = $@"{"temp.wav"}";
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "ffmpeg.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (start == 0)
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
                else
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start - 1} -t {end + 1} \"{outputFilename}\"";
                using (Process exeprocess3 = Process.Start(startInfo))
                {
                    exeprocess3.WaitForExit();

                }
                if (rbEnglish.Checked)
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }

                }
                else
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv_TR.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }
                }
                if (File.Exists("temp.wav"))
                {
                    File.Delete("temp.wav");
                }
                if (File.Exists("ses1.txt"))
                {
                    if (rbTurkish.Checked)
                    {
                        string yardim = "";
                        StreamReader sr = new StreamReader(String.Format(@"{0}\ses1.txt", System.Windows.Forms.Application.StartupPath), Encoding.GetEncoding("iso-8859-9"), false);
                        alltext += " " + sr.ReadToEnd();
                        sr.Close();
                        alltext += " " + yardim;
                    }
                    else
                    {
                        alltext += " " + File.ReadAllText("ses1.txt");
                    }


                }
                else
                {
                    errorss += " " + start.ToString() + "_ " + end.ToString();
                }
                richTextBox1.Text += " " + File.ReadAllText("ses1.txt");
                if (File.Exists("ses1.txt"))
                {
                    File.Delete("ses1.txt");
                }
            }
        }

        void ConverttotextwithPhyton5min()
        {

            int start = 0;
            int end = 280;
            string inputfile = textBox1.Text;
            var ffProbe = new NReco.VideoInfo.FFProbe();
            var videoInfo = ffProbe.GetMediaInfo(inputfile);
            int duration = Convert.ToInt32(videoInfo.Duration.TotalSeconds);
            string newfilename = Path.GetFileNameWithoutExtension(textBox1.Text);
            while (start < duration)
            {
                string outputFilename = $@"{"temp.wav"}";
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "ffmpeg.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (start == 0)
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
                else
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start - 1} -t {end + 1} \"{outputFilename}\"";

                using (Process exeprocess = Process.Start(startInfo))
                {
                    exeprocess.WaitForExit();

                }
                if (rbEnglish.Checked)
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }

                }
                else
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv_TR.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }
                }
                if (File.Exists("temp.wav"))
                {
                    File.Delete("temp.wav");
                }
                if (File.Exists("ses1.txt"))
                {
                    if (rbTurkish.Checked)
                    {
                        string yardim = "";
                        StreamReader sr = new StreamReader(String.Format(@"{0}\ses1.txt", System.Windows.Forms.Application.StartupPath), Encoding.GetEncoding("iso-8859-9"), false);
                        alltext += " " + sr.ReadToEnd();
                        sr.Close();
                        alltext += " " + yardim;
                    }
                    else
                    {
                        alltext += " " + File.ReadAllText("ses1.txt");
                    }


                }
                else
                {
                    errorss += " " + start.ToString() + "_ " + end.ToString();
                }
                if (File.Exists("ses1.txt"))
                {
                    File.Delete("ses1.txt");
                }
                richTextBox1.Text = alltext;
                start += end;
                if (start == duration)
                    break;

            }
            if (start != duration)
            {
                start -= end;
                int kalan = duration - start;

                string outputFilename = $@"{"temp.wav"}";
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "ffmpeg.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (start == 0)
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
                else
                    startInfo.Arguments = $"-i \"{inputfile}\" -ss {start - 1} -t {end + 1} \"{outputFilename}\"";
                using (Process exeprocess3 = Process.Start(startInfo))
                {
                    exeprocess3.WaitForExit();

                }
                if (rbEnglish.Checked)
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Conv.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }

                }
                else
                {
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.FileName = "Audio_Convtr.exe";
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    using (Process exeprocess2 = Process.Start(startInfo2))
                    {
                        exeprocess2.WaitForExit();


                    }
                }
                if (File.Exists("temp.wav"))
                {
                    File.Delete("temp.wav");
                }
                if (File.Exists("ses1.txt"))
                {
                    if (rbTurkish.Checked)
                    {
                        string yardim = "";
                        StreamReader sr = new StreamReader(String.Format(@"{0}\ses1.txt", System.Windows.Forms.Application.StartupPath), Encoding.GetEncoding("iso-8859-9"), false);
                        alltext += " " + sr.ReadToEnd();
                        sr.Close();
                        alltext += " " + yardim;
                    }
                    else
                    {
                        alltext += " " + File.ReadAllText("ses1.txt");
                    }


                }
                else
                {
                    errorss += " " + start.ToString() + "_ " + end.ToString();
                }
                richTextBox1.Text += " " + File.ReadAllText("ses1.txt");
                if (File.Exists("ses1.txt"))
                {
                    File.Delete("ses1.txt");
                }
            }
        }
        private void btnSpeechtoText_ClickAsync(object sender, EventArgs e)
        {
            MessageBox.Show("This Property is not avaliable yet");

            //OpenFileDialog ofd = new OpenFileDialog();

            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    List<dosyaad> list = new List<dosyaad>();
            //    int start = 0;
            //    int end = 280;
            //    int count = 0;
            //    string inputfile = ofd.FileName;
            //    var ffProbe = new NReco.VideoInfo.FFProbe();
            //    var videoInfo = ffProbe.GetMediaInfo(inputfile);
            //    int duration = Convert.ToInt32(videoInfo.Duration.TotalSeconds);
            //    string newfilename = Path.GetFileNameWithoutExtension(ofd.FileName);
            //    if (!Directory.Exists(@"tempdata"))
            //        Directory.CreateDirectory(@"tempdata");

            //    while (start < duration)
            //    {
            //        dosyaad ad = new dosyaad();
            //        count++;
            //        string outputFilename = $@"tempdata\{newfilename}{"_"}{count}{".wav"}";
            //        ad.ad = newfilename + "_" + count;
            //        list.Add(ad);
            //        string command = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
            //        ProcessStartInfo startInfo = new ProcessStartInfo();
            //        startInfo.CreateNoWindow = true;
            //        startInfo.UseShellExecute = false;
            //        startInfo.FileName = "ffmpeg.exe";
            //        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //        startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
            //        using (Process exeprocess = Process.Start(startInfo))
            //        {
            //            exeprocess.WaitForExit();
            //        }
            //        start += end;
            //        if (start == duration)
            //            break;

            //    }
            //    if (start != duration)
            //    {
            //        start -= end;
            //        int kalan = duration - start;
            //        count++;
            //        string outputFilename = $@"tempdata\{newfilename}{"_"}{count}{".wav"}";
            //        string command = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
            //        ProcessStartInfo startInfo = new ProcessStartInfo();
            //        startInfo.CreateNoWindow = true;
            //        startInfo.UseShellExecute = false;
            //        startInfo.FileName = "ffmpeg.exe";
            //        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //        startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
            //        using (Process exeprocess = Process.Start(startInfo))
            //        {
            //            exeprocess.WaitForExit();
            //        }
            //        dosyaad ad = new dosyaad();

            //        ad.ad = newfilename + "_" + count;
            //        list.Add(ad);

            //    }
            //    string textvalue = "";
            //    foreach (var item in list)
            //    {
            //        var result = getawaitAsync(item.ad);
            //        textvalue += result;
            //        richTextBox1.Text = textvalue;

            //    }

            //    //foreach (var item in list)
            //    //{
            //    //    richTextBox1.Text += ConvertToText(item.ad);
            //    //}
            //    //ExportToWord(Path.GetFileNameWithoutExtension(ofd.FileName));






            //}
        }
        async Task<string> getawaitAsync(string filepath)
        {
            var speechConfig = SpeechConfig.FromSubscription("ec16b91578f94c15bee400c23664dd45", "westus2");
            var Result = await FromFile(speechConfig, filepath);
            return Result;


        }
        class dosyaad
        {
            public string ad { get; set; }
        }
        public bool isword;
        void ExportToWord(string filename)
        {
            filename = Path.GetFileNameWithoutExtension(filename);
            string dokumanName = DateTime.Now.ToString("dd_MM_yyyy");
            string createdfilename = dokumanName + "_" + filename;
            if (!Directory.Exists(@"C:\OAK\Document"))
                Directory.CreateDirectory(@"C:\OAK\Document");
            try
            {
                Word.Application word = new Word.Application();
                //word.Visible = true;
                word.WindowState = Word.WdWindowState.wdWindowStateNormal;
                Word.Document dokuman = word.Documents.Add();
                Word.Paragraph parag;
                parag = dokuman.Paragraphs.Add();
                parag.Range.Text = alltext;


                if (File.Exists(@"C:\OAK\Document\" + createdfilename + ".doc"))
                    createdfilename += "_1";

                dokuman.SaveAs2(@"C:\OAK\Document\" + createdfilename + ".doc");
                isword = true;
            }
            catch (Exception ex)
            {
                if (File.Exists(@"C:\OAK\Document\" + createdfilename + ".txt"))
                    createdfilename += "_1";
                FileStream fParameter = new FileStream(@"C:\OAK\Document\" + createdfilename + ".txt", FileMode.Create, FileAccess.Write);
                StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                m_WriterParameter.Write(richTextBox1.Text);
                m_WriterParameter.Flush();
                m_WriterParameter.Close();
                isword = false;

            }

        }
        public async static Task<string> FromFile(SpeechConfig speechConfig, string filepath)
        {
            var audioConfig = AudioConfig.FromWavFileInput("tempdata\\" + filepath + ".wav");
            var recognizer = new SpeechRecognizer(speechConfig, audioConfig);

            var result = await recognizer.RecognizeOnceAsync();

            return result.Text;

        }

        private void btnPhyton10_Click(object sender, EventArgs e)
        {
            alltext = "";
            errorss = "";

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = "";

                textBox1.Text = ofd.FileName;

                ConverttotextwithPhyton10sec();
                ExportToWord(ofd.FileName);

                if (isword)
                    MessageBox.Show("Doc file saved");
                else
                    MessageBox.Show("txt file saved");

                Process.Start(@"C:\OAK\Document");
            }
        }

        private void btnPhyton50_Click(object sender, EventArgs e)
        {
            alltext = "";
            errorss = "";
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = "";
                textBox1.Text = ofd.FileName;
                ConverttotextwithPhyton50sec();
                ExportToWord(ofd.FileName);
                if (alltext == "")
                {
                    MessageBox.Show("No file saved");
                }
                else if (isword)
                    MessageBox.Show("Doc file saved");
                else
                    MessageBox.Show("txt file saved");
                Process.Start(@"C:\OAK\Document");
            }
        }

        private void btnPhyton5min_Click(object sender, EventArgs e)
        {
            alltext = "";
            errorss = "";
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = "";
                textBox1.Text = ofd.FileName;
                ConverttotextwithPhyton5min();
                ExportToWord(ofd.FileName);

                if (isword)
                    MessageBox.Show("Doc file saved");
                else
                    MessageBox.Show("txt file saved");
                Process.Start(@"C:\OAK\Document");
            }
        }

        private void btnMicrosoft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Property is not avaliable yet");

            //OpenFileDialog ofd = new OpenFileDialog();

            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    List<dosyaad> list = new List<dosyaad>();
            //    int start = 0;
            //    int end = 280;
            //    int count = 0;
            //    string inputfile = ofd.FileName;
            //    var ffProbe = new NReco.VideoInfo.FFProbe();
            //    var videoInfo = ffProbe.GetMediaInfo(inputfile);
            //    int duration = Convert.ToInt32(videoInfo.Duration.TotalSeconds);
            //    string newfilename = Path.GetFileNameWithoutExtension(ofd.FileName);
            //    if (!Directory.Exists(@"tempdata"))
            //        Directory.CreateDirectory(@"tempdata");

            //    while (start < duration)
            //    {
            //        dosyaad ad = new dosyaad();
            //        count++;
            //        string outputFilename = $@"tempdata\{newfilename}{"_"}{count}{".wav"}";
            //        ad.ad = newfilename + "_" + count;
            //        list.Add(ad);
            //        string command = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
            //        ProcessStartInfo startInfo = new ProcessStartInfo();
            //        startInfo.CreateNoWindow = true;
            //        startInfo.UseShellExecute = false;
            //        startInfo.FileName = "ffmpeg.exe";
            //        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //        startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
            //        using (Process exeprocess = Process.Start(startInfo))
            //        {
            //            exeprocess.WaitForExit();
            //        }
            //        start += end;
            //        if (start == duration)
            //            break;

            //    }
            //    if (start != duration)
            //    {
            //        start -= end;
            //        int kalan = duration - start;
            //        count++;
            //        string outputFilename = $@"tempdata\{newfilename}{"_"}{count}{".wav"}";
            //        string command = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
            //        ProcessStartInfo startInfo = new ProcessStartInfo();
            //        startInfo.CreateNoWindow = true;
            //        startInfo.UseShellExecute = false;
            //        startInfo.FileName = "ffmpeg.exe";
            //        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //        startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
            //        using (Process exeprocess = Process.Start(startInfo))
            //        {
            //            exeprocess.WaitForExit();
            //        }
            //        dosyaad ad = new dosyaad();

            //        ad.ad = newfilename + "_" + count;
            //        list.Add(ad);

            //    }
            //    string textvalue = "";
            //    foreach (var item in list)
            //    {
            //        var result = getawaitAsync(item.ad);
            //        textvalue += result;
            //        richTextBox1.Text = textvalue;

            //    }

            //    //foreach (var item in list)
            //    //{
            //    //    richTextBox1.Text += ConvertToText(item.ad);
            //    //}
            //    //ExportToWord(Path.GetFileNameWithoutExtension(ofd.FileName));

        }

        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            try
            {
                Word.Application word = new Word.Application();
                //word.Visible = true;
                word.WindowState = Word.WdWindowState.wdWindowStateNormal;
                Word.Document dokuman = word.Documents.Add();
                Word.Paragraph parag;
                parag = dokuman.Paragraphs.Add();
                parag.Range.Text = richTextBox1.Text;
                if (!Directory.Exists(@"C:\OAK\Document"))
                    Directory.CreateDirectory(@"C:\OAK\Document");
                string dokumanName = DateTime.Now.ToString("dd_MM_yyyy") + "_ savedfile";
                dokuman.SaveAs2(@"C:\OAK\Document\" + dokuman + ".doc");
                MessageBox.Show("Youe file saved in C:\\OAK\\Document folder as name " + dokumanName);
            }
            catch (Exception ex)
            {

                MessageBox.Show("There is an error in your system for save any file to word.");
            }
        }

        private void btnConvertToWav_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {



                string ext = Path.GetExtension(ofd.FileName);
                if (ext != ".wav")
                {
                    var convert = new NReco.VideoConverter.FFMpegConverter();

                    string filename = Path.GetFileNameWithoutExtension(ofd.FileName);

                    if (!Directory.Exists(@"C:\OAK\ConvertedToWav"))
                        Directory.CreateDirectory(@"C:\OAK\ConvertedToWav");
                    convert.ConvertMedia(ofd.FileName, "C:\\OAK\\ConvertedToWav\\" + filename + ".wav", "wav"); //@"D\video\videos.mp4", NReco.VideoConverter.Format.mp4
                    MessageBox.Show("Convertted");
                    Process.Start(@"C:\OAK\ConvertedToWav");
                }
                else
                    MessageBox.Show("This file's extension is already .wav");

            }
        }

        int timercounter = 0;
        int minutes = 0;
        int hours = 0;
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string ipstrCommand, string ipstrReturnString, int uReturnLenth, int hwndCallback);

        private void btnRecord_Click(object sender, EventArgs e)
        {
            timercounter = 0;
            minutes = 0;
            hours = 0;
            label1.Text = "00:00:00";
            timer1.Start();
            record("open new Type waveaudio Alias recSound", "", 0, 0);
            record("record recsound", "", 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("temp.wav"))
            {
                File.Delete("temp.wav");
            }
            if (!Directory.Exists(@"C:\OAK\Split"))
            {
                Directory.CreateDirectory(@"C:\OAK\Split");
            }
            if (File.Exists("ses1.txt"))
            {
                File.Delete("ses1.txt");
            }
            comboBox1.SelectedIndex = 0;
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            record("save recsound d:\\mic.wav", "", 0, 0);
            record("save recsound e:\\mic.wav", "", 0, 0);
            record("save recsound f:\\mic.wav", "", 0, 0);
            record("close recsound", "", 0, 0);
            string inputfilename = "";
            if (File.Exists(@"d:\\mic.wav"))
            {
                inputfilename = "d:\\mic.wav";
            }
            else if (File.Exists(@"d:\\mic.wav"))
            {
                inputfilename = "e:\\mic.wav";
            }
            else if (File.Exists(@"d:\\mic.wav"))
            {
                inputfilename = "f:\\mic.wav";
            }
            if (inputfilename != "")
            {
                textBox1.Text = inputfilename;
                ConverttotextwithPhyton10sec();
                ExportToWord(inputfilename);
                if (File.Exists(@"d:\\mic.wav"))
                {
                    File.Delete(@"d:\\mic.wav");
                }
                if (File.Exists(@"e:\\mic.wav"))
                {
                    File.Delete(@"e:\\mic.wav");
                }
                if (File.Exists(@"f:\\mic.wav"))
                {
                    File.Delete(@"f:\\mic.wav");
                }
                if (isword)
                    MessageBox.Show("Doc file saved");
                else
                    MessageBox.Show("txt file saved");
                Process.Start(@"C:\OAK\Document");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timercounter++;
            if (minutes == 60)
            {
                hours++;
                minutes = 0;
                timercounter = 0;
            }
            else if (timercounter == 60)
            {
                timercounter = 0;
                minutes++;
            }
            string hoursstring = "";
            string minstring = "";
            string secstring = "";
            if (hours < 10)
                hoursstring = "0" + hours.ToString() + ":";
            else
                hoursstring = hours.ToString() + ":";
            if (minutes < 10)
                minstring = "0" + minutes.ToString() + ":";
            else
                minstring = minutes.ToString() + ":";
            if (timercounter < 10)
                secstring = "0" + timercounter.ToString();
            else
                secstring = timercounter.ToString();
            label1.Text = hoursstring + minstring + secstring;
        }




        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSplit_Click_1(object sender, EventArgs e)
        {


            if (txtTime.Text == "")
            {
                MessageBox.Show("Please set split time ");
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int start = 0;
                    int end = Convert.ToInt32(txtTime.Text);
                    if (comboBox1.SelectedIndex == 1)
                        end = end * 60;
                    string inputfile = ofd.FileName;
                    var ffProbe = new NReco.VideoInfo.FFProbe();
                    var videoInfo = ffProbe.GetMediaInfo(inputfile);
                    int duration = Convert.ToInt32(videoInfo.Duration.TotalSeconds);
                    int count = 0;
                    string newfilename = Path.GetFileNameWithoutExtension(ofd.FileName);
                    string directory = "";
                    if (!Directory.Exists(@"C:\OAK\Split\" + newfilename))
                    {
                        directory = @"C:\OAK\Split\" + newfilename;
                        Directory.CreateDirectory(directory);
                    }

                    else
                    {
                        directory = @"C:\OAK\Split\" + newfilename + "_1";
                        Directory.CreateDirectory(directory);

                    }
                    int tampstart = 0;
                    while (start < duration)
                    {
                        tampstart = start + end;
                        if (tampstart < duration)
                        {
                            count++;
                            string outputFilename = $@"{directory}\{newfilename}{"_"}{count}{".mp4"}";
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.CreateNoWindow = true;
                            startInfo.UseShellExecute = false;
                            startInfo.FileName = "ffmpeg.exe";
                            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
                            using (Process exeprocess = Process.Start(startInfo))
                            {
                                exeprocess.WaitForExit();

                            }

                        }
                        start += end;
                        if (start == duration)
                            break;

                    }
                    if (start != duration)
                    {
                        count++;
                        start -= end;
                        int kalan = duration - start-1;

                        string outputFilename2 = $@"{directory}\{newfilename}{"_"}{count}{".wav"}";
                        ProcessStartInfo startInfo2 = new ProcessStartInfo();
                        startInfo2.CreateNoWindow = true;
                        startInfo2.UseShellExecute = false;
                        startInfo2.FileName = "ffmpeg.exe";
                        startInfo2.WindowStyle = ProcessWindowStyle.Hidden;

                        startInfo2.Arguments = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename2}\"";
                        using (Process exeprocess3 = Process.Start(startInfo2))
                        {
                            exeprocess3.WaitForExit();

                        }
                    }
                    MessageBox.Show("Your file was splited into " + count.ToString() + " pieces");
                    Process.Start(directory);

                }
            }
        }
    }
}