using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpCompress;
using System.IO;
using SharpCompress.Readers;
using SharpCompress.Writers;
using SharpCompress.Common;

namespace Fast_RAR_Extractor
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        string RAR_FILE_PATH = null;
        string DESTINATION_FOLDER_PATH = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Minimize and close window button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Move window
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        // Select file
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if(obtainFilePath.ShowDialog() == DialogResult.OK)
            {
                RAR_FILE_PATH = obtainFilePath.FileName;
            }
        }

        // Select destination folder
        private void btnSelectDestinationFolder_Click(object sender, EventArgs e)
        {
            if(obtainDestinationFolder.ShowDialog() == DialogResult.OK)
            {
                DESTINATION_FOLDER_PATH = obtainDestinationFolder.SelectedPath;
            }
        }

        // Start extraction
        private void btnStart_Click(object sender, EventArgs e)
        {
            backgroundWorkerMain.RunWorkerAsync();
        }

        // Estract file
        public void zipExtraction()
        {
            int con = 0;

            try
            {
                // Calulating time process [START]
                var watch = System.Diagnostics.Stopwatch.StartNew();
                if (RAR_FILE_PATH != null && DESTINATION_FOLDER_PATH != null)
                {
                    using (Stream stream = File.OpenRead(RAR_FILE_PATH))
                    using (var reader = ReaderFactory.Open(stream))
                    {
                        while (reader.MoveToNextEntry())
                        {
                            if (!reader.Entry.IsDirectory)
                            {
                                Console.WriteLine(reader.Entry.Key);
                                reader.WriteEntryToDirectory(DESTINATION_FOLDER_PATH, new ExtractionOptions()
                                {
                                    ExtractFullPath = true,
                                    Overwrite = true
                                });
                                con++;
                                this.Invoke((MethodInvoker)delegate { labelStatus.Text = $"FILE JUST EXTRACTED: {con}"; });
                            }
                        }
                        stream.Close();
                    }
                }
                // Calulating time process [STOP]
                watch.Stop();

                this.Invoke((MethodInvoker)delegate { labelStatus.Text += $"\nEXTRACTED IN: {watch.ElapsedMilliseconds} Milliseconds"; });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate { labelStatus.Text = ex.Message; });
            }
        }

        // Using backgroudWorker
        private void backgroundWorkerMain_DoWork(object sender, DoWorkEventArgs e)
        {
            zipExtraction();
        }
    }
}
