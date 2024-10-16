using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace KMLBuilder
{
    public partial class Form1 : Form
    {
        private BindingSource waypointsBindingSource = new BindingSource();
        private BindingList<Waypoint> bindingList = new BindingList<Waypoint>();
        private string? _kmlFilePath;

        public Form1()
        {
            InitializeComponent();

            // Subscribe to the EditingControlShowing event
            // to check for valid data types in Lat, Long, Elevation inputs
            dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);

            // Data validation listening
            dataGridView1.CellValidating += dataGridView1_CellValidating;

            waypointsBindingSource.DataSource = bindingList;

            dataGridView1.DataSource = waypointsBindingSource;
            dataGridView1.Columns[0].HeaderText = "Πλάτος (Latitude ) - x";
            dataGridView1.Columns[1].HeaderText = "Μήκος (Longitude) - y";
            dataGridView1.Columns[2].HeaderText = "Ύψόμετρο (Elevation) - z";
            dataGridView1.Columns[3].HeaderText = "Ετικέτα";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Check which column is currently being edited
            DataGridViewTextBoxEditingControl textBox = e.Control as DataGridViewTextBoxEditingControl;

            if (dataGridView1.CurrentCell.ColumnIndex == 0 || // Latitude Column
                dataGridView1.CurrentCell.ColumnIndex == 1 || // Longitude Column
                dataGridView1.CurrentCell.ColumnIndex == 2)   // Elevation Column
            {
                textBox.KeyPress -= new KeyPressEventHandler(TextBox_KeyPress);
                textBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            }
            else
            {
                textBox.KeyPress -= new KeyPressEventHandler(TextBox_KeyPress);
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters, digits, the decimal point, and the minus sign
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true; // Reject the input
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true; // Reject the input
            }

            // Allow '-' only at the start of the input
            if (e.KeyChar == '-' && ((TextBox)sender).SelectionStart > 0)
            {
                e.Handled = true; // Reject if '-' is not at the start
            }

            // Allow '0' as a valid entry at the start
            if (e.KeyChar == '0' && ((TextBox)sender).Text.Length == 0)
            {
                e.Handled = false; // Accept the input
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Assuming column index 0 is Latitude and 1 is Longitude
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1) // Adjust column indices as necessary
            {
                // Validate if the input is a valid decimal number
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal result))
                {
                    MessageBox.Show("Παρακαλώ εισάγετε έναν έγκυρο αριθμό.");
                    e.Cancel = true; // Cancel the edit
                    return;
                }

                // Check if Latitude, Longitude, or Elevation is empty
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("Το Πλάτος (Latitude ), Μήκος (Longitude ) και Υψόμετρο (Elevation), είναι υποχρεωτικά πεδία.");
                    e.Cancel = true; // Cancel the edit
                }

                // Additional validation for Latitude and Longitude ranges
                if (e.ColumnIndex == 0) // Latitude
                {
                    if (result < -90 || result > 90)
                    {
                        MessageBox.Show("Το Πλάτος (Lat) πρέπει να είναι μεταξύ -90 και 90 μοίρες.");
                        e.Cancel = true; // Cancel the edit
                    }
                }
                else if (e.ColumnIndex == 1) // Longitude
                {
                    if (result < -180 || result > 180)
                    {
                        MessageBox.Show("Το μήκος (Long) πρέπει να είναι μεταξύ -180 και 180 μοίρες.");
                        e.Cancel = true; // Cancel the edit
                    }
                }
            }
        }

        private void άνοιγμαΑρχείουKMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadKMLFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_kmlFilePath))
            {
                // If no file path is set, call Save As
                saveAsToolStripMenuItem_Click(sender, e); // Call the Save As method
            }
            else
            {
                // Save the DataGridView data as KML to the stored path
                SaveDataGridViewToKML(_kmlFilePath);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "KML Files (*.kml)|*.kml|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save KML File As";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the file path for later use
                    _kmlFilePath = saveFileDialog.FileName;

                    // Save the DataGridView data as KML
                    SaveDataGridViewToKML(_kmlFilePath);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Ctrl is pressed and the S key is pressed for Save action
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Prevent the default save action if needed
                e.SuppressKeyPress = true;

                // Call the save method
                saveToolStripMenuItem_Click(sender, e); // Trigger the save action
            }

            // Check if Ctrl + Shift + S is pressed for Save As action
            if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                // Prevent the default action if needed
                e.SuppressKeyPress = true;

                // Call the Save As method
                saveAsToolStripMenuItem_Click(sender, e); // Trigger the Save As action
            }

            // Check if Ctrl + Q  is pressed for Application exit action
            if (e.Control && e.KeyCode == Keys.Q)
            {
                // Prevent the default action if needed
                e.SuppressKeyPress = true;

                // Call the Save As method
                exitToolStripMenuItem_Click(sender, e); // Trigger the Save As action
            }
        }

        // Prompt for save before closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        //----------------------------------------------
        // Implementation

        // Open a KML 2.2 file with .kml file extension
        private void LoadKMLFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "KML Files (*.kml)|*.kml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;

                    try
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(filePath);

                        // Clear existing data
                        var waypoints = waypointsBindingSource.DataSource as BindingList<Waypoint>;
                        waypoints.Clear();

                        // Parse the KML file
                        XmlNodeList placemarks = xmlDoc.GetElementsByTagName("Placemark");
                        foreach (XmlNode placemark in placemarks)
                        {
                            Waypoint waypoint = new Waypoint
                            {
                                Details = placemark["name"]?.InnerText,
                                Latitude = Convert.ToDecimal(placemark["Point"]["coordinates"].InnerText.Split(',')[1]),
                                Longitude = Convert.ToDecimal(placemark["Point"]["coordinates"].InnerText.Split(',')[0]),
                                Elevation = placemark["Point"]["altitudeMode"]?.InnerText == "absolute" ?
                                            Convert.ToDecimal(placemark["Point"]["coordinates"].InnerText.Split(',')[2]) : 0
                            };
                            waypoints.Add(waypoint);
                        }

                        // Notify the DataGridView to refresh
                        waypointsBindingSource.ResetBindings(false);
                        statusLabel.Text = $"Επιτυχής φόρτωση του KML αρχείου {filePath}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Σφάλμα κατά τη φόρτωση του KML αρχείου: {ex.Message}");
                        statusLabel.Text = $"Σφάλμα κατά τη φόρτωση του KML αρχείου";
                    }
                }
            }
        }

        // Save file as KML 2.2 with a .kml file extension
        private void SaveDataGridViewToKML(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the KML header
                    writer.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                    writer.WriteLine("<kml xmlns=\"http://www.opengis.net/kml/2.2\">");
                    writer.WriteLine("<Document>");

                    // Write the data from DataGridView
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue; // Skip the new row placeholder

                        string latitude = row.Cells[0].Value?.ToString();
                        string longitude = row.Cells[1].Value?.ToString();
                        string elevation = row.Cells[2].Value?.ToString();
                        string details = row.Cells[3].Value?.ToString();

                        // Only include rows with latitude, longitude, and elevation
                        if (!string.IsNullOrWhiteSpace(latitude) &&
                            !string.IsNullOrWhiteSpace(longitude) &&
                            !string.IsNullOrWhiteSpace(elevation))
                        {
                            writer.WriteLine("  <Placemark>");
                            writer.WriteLine($"    <name>{details ?? "No Name"}</name>");
                            writer.WriteLine($"    <Point>");
                            writer.WriteLine($"      <coordinates>{longitude},{latitude},{elevation}</coordinates>");
                            writer.WriteLine("    </Point>");
                            writer.WriteLine("  </Placemark>");
                        }
                    }

                    // Write the KML footer
                    writer.WriteLine("</Document>");
                    writer.WriteLine("</kml>");
                }
                // Update the status strip on successful save
                statusLabel.Text = $"Το αρχείο KML {filePath} αποθηκεύτηκε με επιτυχία!";
                MessageBox.Show("Το αρχείο KML αποθηκεύτηκε με επιτυχία!", "Αποθήκευση Ως KML", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                // Handle exceptions and update status
                statusLabel.Text = $"Σφάλμα κατά την αποθήκευση: {ex.Message}";
            }
        }

        private void πληροφορίεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox1();
            about.ShowDialog();
        }
    }
}
