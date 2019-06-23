using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AdaptiveVectorQuantization
{
    public partial class FormAVQ : Form
    {

        private FastImage originalImage;

        public FormAVQ()
        {
            InitializeComponent();
        }

        public static string OriginalFile { get; set; }
        public static string InputFileComp { get; set; }
        internal AVQ AvqCompression { get; set; } = null;

        private void invertFormAcces()
        {
            buttonStart.Enabled = !buttonStart.Enabled;
            buttonLoad.Enabled = !buttonLoad.Enabled;
            buttonDecode.Enabled = !buttonDecode.Enabled;
        }

        public void updatePanelBlock(Bitmap image)
        {
            panelBlockPaint.BackgroundImage = image;
            //panelBlockPaint.Update();
            panelBlockPaint.Refresh();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

            openFileDialog.Filter = "Image Files(*.BMP;*.JPG)|*.BMP;*.JPG|All files (*.*)|*.*";

            openFileDialog.ShowDialog();
            OriginalFile = openFileDialog.FileName;

            try
            {
                panelOriginalImage.BackgroundImage = new Bitmap(OriginalFile);
            }
            catch (Exception)
            {
                Console.WriteLine("File {0} not found", OriginalFile);
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            invertFormAcces();
            panelDestination.BackgroundImage = null;
            Refresh();

            if(comboBoxDictionarySize.SelectedItem == null)
            {
                MessageBox.Show("You need to choose a dictionary size!");
                invertFormAcces();
                return;
            }
            if (OriginalFile != null)
            {

                int.TryParse(textBoxThreshold.Text, out int threshold);
                int.TryParse(comboBoxDictionarySize.GetItemText(comboBoxDictionarySize.SelectedItem), out int dictionarySize);


                AvqCompression = new AVQ(OriginalFile);
                originalImage = AvqCompression.StartCompression(threshold, dictionarySize);


                panelDestination.BackgroundImage = originalImage.GetBitMap();
            }
            else
            {
                MessageBox.Show("You need to choose an image!");
            }


            invertFormAcces();
        }

        private void buttonShannon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Facultate\Licenta\Shannon.jar");
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {

            invertFormAcces();
            openFileDialog.Filter = "AVQ Files(*.AVQ)|*.AVQ|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            InputFileComp = openFileDialog.FileName;

            if (InputFileComp != null)
            {
                AvqCompression = new AVQ();

                originalImage = AvqCompression.StartDeCompression(InputFileComp);
                Bitmap bitmap = originalImage.GetBitMap();

                string[] output = InputFileComp.Split('.');
                bitmap.Save(output[0] + "-decoded.bmp");
            }
            else
            {
                MessageBox.Show("You need to choose an image!");
            }
            MessageBox.Show("Image decompressed!");
            invertFormAcces();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invertFormAcces();

            //int[] thresholds = { 0, 5, 10, 15 };
            //int[] dictionarySizes = {1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144 };

            int[] thresholds = { 0 };
            int[] dictionarySizes = { 100 };
          
            if (OriginalFile != null)
            {
                List<SimulationResult> simulations = new List<SimulationResult>(thresholds.Length * dictionarySizes.Length);

                string delimiter = ",";
                foreach (int threshold in thresholds)
                {
                    foreach (int dictionarySize in dictionarySizes)
                    {
                        AvqCompression = new AVQ(OriginalFile);
                        simulations.Add(AvqCompression.StartSimulation(threshold, dictionarySize));
                    }
                }

                string[] parts = OriginalFile.Split('\\');
                string imageName = parts[parts.Length - 1].Split('.')[0];
                string filePath = @"D:\Facultate\Licenta\Img\" + imageName + ".csv";
            

                
                StringBuilder sb = new StringBuilder();

                sb.Append("Timp de executie compresie" + delimiter);
                sb.Append("Timp de executie decompresie" + delimiter);
                sb.Append("Numar de blocuri" + delimiter);
                sb.Append("Marime fisier comprimat" + delimiter);
                sb.Append("Marime fisier decomprimat" + delimiter);
                sb.AppendLine("PSNR" + delimiter);

               foreach (SimulationResult result in simulations)
                {
                    sb.Append( result.CompressionTime + delimiter);
                    sb.Append( result.DeompressionTime + delimiter);
                    sb.Append(result.BlocksNumber.ToString() + delimiter);
                    sb.Append( result.CompressedFileSize.ToString() + delimiter);
                    sb.Append( result.DecompressedFileSize.ToString() + delimiter);
                    sb.AppendLine(result.PSNR.ToString() + delimiter);
                    
                }

                File.WriteAllText(filePath, sb.ToString());


            }
            else
            {
                MessageBox.Show("You need to choose an image!");
            }



            

            invertFormAcces();
            MessageBox.Show("Simulation finished!");
        }
    }
}
