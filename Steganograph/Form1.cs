using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Steganograph
{
    public partial class Form1 : Form
    {
        // where are access modifiers?

        // mark required fields as const
        string fPath;
        string fFilter = "Image Files (*.bmp) | *.bmp";
        string fInitialDirectory = @"C:\\Users\\nol1fe\\Desktop\\C#\\";
        string saveSuccessMessage = "Save success!";

        char letter;
        byte valueOfLetter;
        string outputMessage;

        int multiplicator;
        int multiplicatorMaxValue;
        int txtLenght;
        int startPixelPoint;
        int multiplicatorPoint;
        int txtLenghtPoint;

        Image imgIn;
        Image imgOut;

        byte[] byteArrayIn;
        byte[] byteArrayOut;
        byte[] valuesToMerge;


        public Form1()
        {
            InitializeComponent();

            btnOpen.Click += OpenImage;
            btnSave.Click += SaveImage;
            btnCode.Click += MergeArrays;
            btnDecode.Click += DecodeImage;
            btnClear.Click += ClearAll;

            trackBar1.ValueChanged += MultiplicatorValue;
                        
        }

        private void ClearAll(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Restart();
        }

        private void MultiplicatorValue(object sender, EventArgs e)
        {

            multiplicator = trackBar1.Value;

            Code(valuesToMerge, multiplicator);

        }

        private void DecodeImage(object sender, EventArgs e)
        {
            textMessageOut.Clear();

            startPixelPoint = 56;
            multiplicatorPoint = 55;
            txtLenghtPoint = 54;

            txtLenght = byteArrayIn[txtLenghtPoint];
            multiplicator = byteArrayIn[multiplicatorPoint];

            for (var i = 0; i< txtLenght; i++)
            {
                valueOfLetter = byteArrayIn[startPixelPoint];
                letter = Convert.ToChar(valueOfLetter);
                outputMessage = string.Join("", letter);
                textMessageOut.AppendText(outputMessage);

                startPixelPoint+= multiplicator;
            }

        }

        private void MergeArrays(object sender, EventArgs e)
        {
     
            startPixelPoint = 56;
            multiplicatorPoint = 55;
            txtLenghtPoint = 54;

            txtLenght = textMessageIn.TextLength;

            valuesToMerge = new byte[txtLenght];
            byteArrayOut = new byte[byteArrayIn.Length];
            byteArrayIn.CopyTo(byteArrayOut, 0);


            trackBar1.ValueChanged -= MultiplicatorValue;

            trackBar1.Maximum = Byte.MaxValue / txtLenght;
            trackBar1.Value = 255 / txtLenght;

            trackBar1.ValueChanged += MultiplicatorValue;

            multiplicator = 255 / txtLenght;
            multiplicatorMaxValue = 255 / txtLenght;
            multipliLabel.Text = multiplicator.ToString();
            //multiplicatorMaxValue = (byteArrayIn.Length - startPixelPoint) / txtLenght;

            //for (var i = 0; i < txtLenght; i++)
            //{
            //    // here you can address element of an array by index. There is no need to use substring
            //    letter = Convert.ToChar(textMessageIn.Text.Substring(i, 1));
            //    valueOfLetter = Convert.ToByte(letter);
            //    textInNumbers.AppendText(letter + " = " + valueOfLetter + "\n");
            //    valuesToMerge[i] = valueOfLetter;
            //}


            //learn about linq. Linq allows to skip 'for' loop: 
            var myValuesToMerge = textMessageIn.Text.Select(x => (byte)x).ToArray();
            textInNumbers.AppendText(String.Join(Environment.NewLine, myValuesToMerge.Select(x => string.Format("{0} = {1}", Convert.ToChar(x), x))));


            Code(myValuesToMerge, multiplicator);

            RefreshOut();

        }

        private void Code (byte[] valuesToMerge, int multiplicator)
        {
            Array.Clear(byteArrayOut, 0, byteArrayOut.Length);
            byteArrayOut = new byte[byteArrayIn.Length];
            byteArrayIn.CopyTo(byteArrayOut, 0);

            byteArrayOut[multiplicatorPoint] = (byte)multiplicator;
            byteArrayOut[txtLenghtPoint] = (byte)txtLenght;

            startPixelPoint = 56;

            for (var i = 0; i < valuesToMerge.Length; i++)
            {
                byteArrayOut[startPixelPoint] = valuesToMerge[i];
                startPixelPoint += multiplicator;
            }

            RefreshOut();
            multipliLabel.Text = multiplicator.ToString();
        }


        private void SaveImage(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = fFilter;
            saveFile.InitialDirectory = fInitialDirectory;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (var fs = File.Create(saveFile.FileName))
                {
                    fs.Write(byteArrayOut, 0, Convert.ToInt32(byteArrayOut.Length));
                    fs.Close();
                }
            }

            MessageBox.Show(saveSuccessMessage);
        }

        private void OpenImage(object sender, EventArgs e)
        {

            txtLenghtPoint = 54;

            var openFile = new OpenFileDialog();
            openFile.Filter = fFilter;
            openFile.InitialDirectory = fInitialDirectory;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var fInfo = new FileInfo(openFile.FileName);
                fPath = fInfo.FullName;

                byteArrayIn = GetBytesFromFile(fPath);
                imgIn = ByteArrayToImage(byteArrayIn);

                pictureBox1.Image = imgIn;

            }

            RefreshIn();
        }

        public byte[] GetBytesFromFile(string fullFilePath)
        {

            using (var fs = File.OpenRead(fullFilePath))
            {
                var bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                return bytes;
            }
        }

        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                ms.Position = 0;
                return Image.FromStream(ms);
            }
        }

        public void RefreshIn()
        {

            textInNumbers.Clear();

            imgIn = ByteArrayToImage(byteArrayIn);

            pictureBox1.Image = imgIn;
        }

        public void RefreshOut()
        {

            startPixelPoint = 56;

            imgOut = ByteArrayToImage(byteArrayOut);

            pictureBox2.Image = imgOut;


        }
    }
}
