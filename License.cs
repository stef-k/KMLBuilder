using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMLBuilder
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            string url = e.LinkText;

            try
            {
                // Validate the URL
                if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true // for URLs
                    });
                }
                else
                {
                    MessageBox.Show("The link is not a valid URL.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open link: {ex.Message}");
            }
        }
    }
}
