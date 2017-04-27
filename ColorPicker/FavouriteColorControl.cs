using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace ColorPicker
{
    public partial class FavouriteColorControl : UserControl
    {
        public event EventHandler FavouriteClick;


        static int index = 0;
        private byte r = 0;
        private byte g = 0;
        private byte b = 0;
        private FavouriteColor favor = new FavouriteColor();

        public FavouriteColor Favor
        {
            get
            {
                return favor;
            }
        }

        public FavouriteColorControl(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;

            var color = Color.FromArgb(r, g, b);
                                   
            InitializeComponent();

            button1.Click += DeleteFavourite;
            pictureBox1.Click += FavouriteColorControl_Click;
            textBox1.Click += FavouriteColorControl_Click;
            this.Click += FavouriteColorControl_Click;
            btnSaveName.Click += SaveToFavName;

            pictureBox1.BackColor = color;
            textBox1.Text = color.GetHexText();

            favor.favColorName = labelColorName.Text;
            favor.favHexText = textBox1.Text;
            favor.favCreatedData = DateTime.Now.ToString();
        }

        private void SaveToFavName(object sender, EventArgs e)
        {
            labelColorName.Text = favNameYourColor.Text;
            favNameYourColor.Text = "edit";
            favNameYourColor.ForeColor = Color.Silver;
            favNameYourColor.Text = labelColorName.Text;
            favor.favColorName = labelColorName.Text;
        }

        private void FavouriteColorControl_Click(object sender, EventArgs e)
        {

            if (FavouriteClick != null)
            {
                FavouriteClick(this, new EventArgs());
            }
        }

        public Color GetFavouriteColor()
        {
            return Color.FromArgb(r, g, b);
        }

        public void DeleteFavourite(object sender, EventArgs e)
        {
            
            Dispose();

        }

        public void Save()
        {

            //favor.favColorName = labelColorName.Text;
            //favor.favHexText = textBox1.Text;
            //favor.favCreatedData = DateTime.Now.ToString();

            //StreamWriter wr = new StreamWriter("dane.xml");
            //XmlSerializer serializer = new XmlSerializer(typeof(List<FavouriteColor>));
            //serializer.Serialize(wr, listadocelowa);
            //wr.Flush();
            //wr.Close();
        }

    }
}
