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
using System.Xml.Serialization;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        private byte r = 0;
        private byte g = 0;
        private byte b = 0;
        private byte textColor = 0;
        private int i = 0;

        public static List<FavouriteColorControl> favourites;

        public static List<FavouriteColor> listadocelowa;

        List<PictureBox> lastColorsList;
        

        public Form1()
        {
            var favouriteColorControl = new FavouriteColorControl(r, g, b);
            

            InitializeComponent();

            favourites = new List<FavouriteColorControl>();
            lastColorsList = new List<PictureBox>();
            listadocelowa = new List<FavouriteColor>();

            #region EventsInit
            sliderRed.ValueChanged += SliderRed_ValueChanged;
            sliderGreen.ValueChanged += SliderGreen_ValueChanged;
            sliderBlue.ValueChanged += SliderBlue_ValueChanged;
            buttonRandom.Click += ButtonRandom_Click;
            buttonSave.Click += AddToFavourites;
            buttonExport.Click += SaveToolStripButton_Click;
            saveToolStripButton.Click += SaveToolStripButton_Click;
            saveFileDialog.FileOk += SaveFileDialog_FileOk;
            favouriteToolStripButton.Click += AddToFavourites;
            buttonClear.Click += ButtonClear_Click;
            #endregion EventsInit

            Refresh();

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            favourites.Clear();
            lastColorsList.Clear();

            favouriteListPanel.Controls.Clear();
            lastColorsPanel.Controls.Clear();

        }

        private void LoadColorFromFavourites(object sender, EventArgs e)
        {
            var favourite = sender as FavouriteColorControl;
            if(favourite != null)
            {

                var favouriteColor = favourite.GetFavouriteColor();
                r = favouriteColor.R;
                g = favouriteColor.G;
                b = favouriteColor.B;

                ColorUpdate();
            }

        }

        private void LoadColorFromLastColors(object sender, EventArgs e)
        {
            var lastcolor = sender as PictureBox;
            if (lastColorsList != null)
            {
                r = lastcolor.BackColor.R;
                g = lastcolor.BackColor.G;
                b = lastcolor.BackColor.B;

                ColorUpdate();
            }
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
          
            
        }

        //wiec np w main form masz metode save
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            ColorUpdate();
            //i  na koncu robisz tego writtera serializujesz cala liste nie pojedynczy element I done :)
            StreamWriter wr = new StreamWriter("dane.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<FavouriteColor>));
            serializer.Serialize(wr, listadocelowa);
            wr.Flush();
            wr.Close();
        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            
            var rnd = new Random();
            r = (byte)rnd.Next(0, 255);
            g = (byte)rnd.Next(0, 255);
            b = (byte)rnd.Next(0, 255);

            ColorUpdate();
            AddToLastColors();
        }

        private void SliderRed_ValueChanged(object sender, EventArgs e)
        {
            r = (byte)sliderRed.Value;
            ColorUpdate();

        }

        private void SliderGreen_ValueChanged(object sender, EventArgs e)
        {
            g = (byte)sliderGreen.Value;
            ColorUpdate();

        }

        private void SliderBlue_ValueChanged(object sender, EventArgs e)
        {
            b = (byte)sliderBlue.Value;
            ColorUpdate();

        }

        private void ColorUpdate()
        {

            colorDisplay.ReadOnly = true;

            redAmmount.Text = r.ToString();
            greenAmmount.Text = g.ToString();
            blueAmmount.Text = b.ToString();

            sliderRed.Value = r;
            sliderGreen.Value = g;
            sliderBlue.Value = b;

            if (r > 150 || b > 150 || g > 150)
            {
                textColor = 0;
            }
            else
            {
                textColor = 255;
            }

            colorDisplay.BackColor = GetColorFromArgb(r, g, b);
            colorDisplay.Text = Color.FromArgb(r,g,b).GetHexText();
            colorDisplay.ForeColor = Color.FromArgb(textColor, textColor, textColor);

            SaveToListaDocelowa();

        }


        private Color GetColorFromArgb(byte r, byte g, byte b)
        {
            return Color.FromArgb(r, g, b);
        }

        private void AddToFavourites(object sender, EventArgs e)
        {
            
            var positionMultiplier = favourites.Count() != 0 ? favourites.Count() : 1;
            var favouriteColorControl = new FavouriteColorControl(r, g, b);
            var favor = new FavouriteColor();

                                    
            favouriteColorControl.Disposed += FavouriteColorControl_Deleted;
            favouriteColorControl.Click += LoadColorFromFavourites;

            favouriteColorControl.Location = new Point(0, (favouriteColorControl.Height + 10) * positionMultiplier);
            favouriteColorControl.FavouriteClick += LoadColorFromFavourites;

            favourites.Add(favouriteColorControl);
            favouriteListPanel.Controls.Add(favouriteColorControl);
            listadocelowa.Add(favor);

            RefreshFavourites();

        }

        private void RefreshFavourites()
        {
            var positionMultiplier = -1;
            
            foreach (FavouriteColorControl favourite in favouriteListPanel.Controls)

            {
                positionMultiplier++;
                favourite.Location =  new Point(0, positionMultiplier * (favourite.Height + 10) );
            }
        }

        private void FavouriteColorControl_Deleted(object sender, EventArgs e)
        {                                   
            RefreshFavourites();
        }

        private void AddToLastColors()
        {
            var positionMultiplier = lastColorsList.Count();
            var lastColor = new PictureBox()
            {
                BackColor = GetColorFromArgb(r, g, b),
                ForeColor = Color.FromArgb(textColor, textColor, textColor),
                Text = BackColor.GetHexText(),
                Height = 32,
                Width = 32
            };

            if (lastColorsList.Count < 15)
            {
                lastColor.Location = new Point(37 * positionMultiplier, 0);
            }
            else
            {
                lastColorsList.Clear();
                lastColorsPanel.Controls.Clear();
            }

            lastColor.Click += LoadColorFromLastColors;
            lastColorsList.Add(lastColor);
            lastColorsPanel.Controls.Add(lastColor);
           
        }

        private void SaveToListaDocelowa()
        {
            listadocelowa = new List<FavouriteColor>();

            //ona leci po aktulanej twojej liscie ulubionej nawet kontrolek
            //i na bazie danych z niej tworzy ta liste elementow twojej klasy do zapisu
            foreach (FavouriteColorControl favourite in favourites)
            {
                var fav = favourite.Favor;
                listadocelowa.Add(fav);
            }

        }

        // listener 
    }
}


