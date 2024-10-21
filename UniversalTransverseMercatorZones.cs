using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMLBuilder
{
    public partial class UniversalTransverseMercatorZones : Form
    {
        private PictureBox pictureBox;
        public UniversalTransverseMercatorZones()
        {
            InitializeComponent();
            pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom // Change as needed
            };
            byte[] imageData = Properties.Resources.Universal_Transverse_Mercator_zones;
            using(MemoryStream ms = new MemoryStream(imageData))
            {
                pictureBox.Image = Image.FromStream(ms);
            }

            this.Controls.Add(pictureBox);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
