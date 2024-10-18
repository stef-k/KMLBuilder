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
            pictureBox.Image = Image.FromFile("Universal_Transverse_Mercator_zones.png");
            this.Controls.Add(pictureBox);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
