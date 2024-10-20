namespace KMLBuilder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            αρχείοToolStripMenuItem = new ToolStripMenuItem();
            openKMLToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveAsText = new ToolStripMenuItem();
            saveAsCSV = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            βοήθειαToolStripMenuItem = new ToolStripMenuItem();
            πληροφορίεςToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            οδηγίεςΧρήσηςToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            universalTransverseMercatorZonesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            άδειαΧρήσηςToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewUtility = new DataGridView();
            WGS84Lat = new DataGridViewTextBoxColumn();
            WGS84Lon = new DataGridViewTextBoxColumn();
            MGRS = new DataGridViewTextBoxColumn();
            ClearBTN = new DataGridViewButtonColumn();
            CoordinatesConvert = new DataGridViewButtonColumn();
            AddToTable = new DataGridViewButtonColumn();
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUtility).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 589);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1084, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { αρχείοToolStripMenuItem, βοήθειαToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // αρχείοToolStripMenuItem
            // 
            αρχείοToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openKMLToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, saveAsText, saveAsCSV, toolStripSeparator6, exitToolStripMenuItem });
            αρχείοToolStripMenuItem.Name = "αρχείοToolStripMenuItem";
            αρχείοToolStripMenuItem.Size = new Size(55, 20);
            αρχείοToolStripMenuItem.Text = "Αρχείο";
            // 
            // openKMLToolStripMenuItem
            // 
            openKMLToolStripMenuItem.Name = "openKMLToolStripMenuItem";
            openKMLToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openKMLToolStripMenuItem.Size = new Size(316, 22);
            openKMLToolStripMenuItem.Text = "Άνοιγμα Αρχείου KML";
            openKMLToolStripMenuItem.ToolTipText = "Άνοιγμα αρχείου KML";
            openKMLToolStripMenuItem.Click += openKMLToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(313, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(316, 22);
            saveToolStripMenuItem.Text = "Αποθήκευση αρχείου KML";
            saveToolStripMenuItem.ToolTipText = "Αποθήκευση του αρχείου";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(316, 22);
            saveAsToolStripMenuItem.Text = "Αποθήκευση αρχείου KML ως...";
            saveAsToolStripMenuItem.ToolTipText = "Αποθήκευση ως, με δυνατότητα εισαγωγής ονόματος αρχείου και τοποθεσίας αποθήκευσης";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(313, 6);
            // 
            // saveAsText
            // 
            saveAsText.Name = "saveAsText";
            saveAsText.Size = new Size(316, 22);
            saveAsText.Text = "Εξαγωγή Αρχείου σε Κείμενο";
            saveAsText.ToolTipText = "Εξαγωγή του αρχείου σε μορφή κειμένου";
            saveAsText.Click += saveAsText_Click;
            // 
            // saveAsCSV
            // 
            saveAsCSV.Name = "saveAsCSV";
            saveAsCSV.Size = new Size(316, 22);
            saveAsCSV.Text = "Εξαγωγή Αρχείου ως CSV";
            saveAsCSV.ToolTipText = "Εξαγωγή του αρχείου σε μορφή CSV, χρήσιμη για άνοιγμα στο EXCEL";
            saveAsCSV.Click += saveAsCSV_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(313, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            exitToolStripMenuItem.Size = new Size(316, 22);
            exitToolStripMenuItem.Text = "Έξοδος";
            exitToolStripMenuItem.ToolTipText = "Τερματισμός εφαρμογής. Προσοχή δεν αποθηκεύει αυτόματα κατα το κλείσιμο!!!";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // βοήθειαToolStripMenuItem
            // 
            βοήθειαToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { οδηγίεςΧρήσηςToolStripMenuItem, toolStripSeparator5, universalTransverseMercatorZonesToolStripMenuItem, toolStripSeparator4, πληροφορίεςToolStripMenuItem, toolStripSeparator3, άδειαΧρήσηςToolStripMenuItem });
            βοήθειαToolStripMenuItem.Name = "βοήθειαToolStripMenuItem";
            βοήθειαToolStripMenuItem.Size = new Size(62, 20);
            βοήθειαToolStripMenuItem.Text = "Βοήθεια";
            // 
            // πληροφορίεςToolStripMenuItem
            // 
            πληροφορίεςToolStripMenuItem.Name = "πληροφορίεςToolStripMenuItem";
            πληροφορίεςToolStripMenuItem.Size = new Size(308, 22);
            πληροφορίεςToolStripMenuItem.Text = "Πληροφορίες";
            πληροφορίεςToolStripMenuItem.Click += πληροφορίεςToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(305, 6);
            // 
            // οδηγίεςΧρήσηςToolStripMenuItem
            // 
            οδηγίεςΧρήσηςToolStripMenuItem.Name = "οδηγίεςΧρήσηςToolStripMenuItem";
            οδηγίεςΧρήσηςToolStripMenuItem.Size = new Size(308, 22);
            οδηγίεςΧρήσηςToolStripMenuItem.Text = "Οδηγίες Χρήσης";
            οδηγίεςΧρήσηςToolStripMenuItem.Click += οδηγίεςΧρήσηςToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(305, 6);
            // 
            // universalTransverseMercatorZonesToolStripMenuItem
            // 
            universalTransverseMercatorZonesToolStripMenuItem.Name = "universalTransverseMercatorZonesToolStripMenuItem";
            universalTransverseMercatorZonesToolStripMenuItem.Size = new Size(308, 22);
            universalTransverseMercatorZonesToolStripMenuItem.Text = "UNIVERSAL TRANSVERSE MERCATOR ZONES";
            universalTransverseMercatorZonesToolStripMenuItem.Click += universalTransverseMercatorZonesToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(305, 6);
            // 
            // άδειαΧρήσηςToolStripMenuItem
            // 
            άδειαΧρήσηςToolStripMenuItem.Name = "άδειαΧρήσηςToolStripMenuItem";
            άδειαΧρήσηςToolStripMenuItem.Size = new Size(308, 22);
            άδειαΧρήσηςToolStripMenuItem.Text = "Άδεια Χρήσης";
            άδειαΧρήσηςToolStripMenuItem.Click += άδειαΧρήσηςToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1084, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(361, 22);
            toolStripLabel2.Text = "ΧΡΗΣΙΜΟΠΟΙΕΙΣΤΕ ΤΕΛΕΙΕΣ ( . ) ΣΤΟΥΣ ΔΕΚΑΔΙΚΟΥΣ ΠΑΝΤΟΥ!!!";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewUtility, 0, 2);
            tableLayoutPanel1.Controls.Add(richTextBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1084, 565);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridViewUtility
            // 
            dataGridViewUtility.AllowUserToAddRows = false;
            dataGridViewUtility.AllowUserToDeleteRows = false;
            dataGridViewUtility.AllowUserToResizeColumns = false;
            dataGridViewUtility.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewUtility.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUtility.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewUtility.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUtility.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUtility.Columns.AddRange(new DataGridViewColumn[] { WGS84Lat, WGS84Lon, MGRS, ClearBTN, CoordinatesConvert, AddToTable });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewUtility.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewUtility.Dock = DockStyle.Fill;
            dataGridViewUtility.Location = new Point(3, 108);
            dataGridViewUtility.Name = "dataGridViewUtility";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewUtility.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewUtility.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewUtility.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewUtility.Size = new Size(1078, 94);
            dataGridViewUtility.TabIndex = 4;
            dataGridViewUtility.TabStop = false;
            dataGridViewUtility.CellContentClick += dataGridViewUtility_CellContentClick;
            // 
            // WGS84Lat
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WGS84Lat.DefaultCellStyle = dataGridViewCellStyle3;
            WGS84Lat.HeaderText = "WGS84-Πλάτος (Latitude)";
            WGS84Lat.Name = "WGS84Lat";
            WGS84Lat.ToolTipText = "Εισάγετε το Πλάτος (Latitude) σε μορφή 40.0000";
            // 
            // WGS84Lon
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WGS84Lon.DefaultCellStyle = dataGridViewCellStyle4;
            WGS84Lon.HeaderText = "WGS84-Μήκος (Longitude)";
            WGS84Lon.Name = "WGS84Lon";
            WGS84Lon.ToolTipText = "Εισάγετε το Μήκος (Longitude) σε μορφή 35.00000";
            // 
            // MGRS
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MGRS.DefaultCellStyle = dataGridViewCellStyle5;
            MGRS.HeaderText = "MGRS (Στρατιωτικές)";
            MGRS.Name = "MGRS";
            MGRS.ToolTipText = "Εισάγετε τις Στρατιωτικές συντεταγμένες σε μορφή 35T MF 35000 38000";
            // 
            // ClearBTN
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            ClearBTN.DefaultCellStyle = dataGridViewCellStyle6;
            ClearBTN.FlatStyle = FlatStyle.System;
            ClearBTN.HeaderText = "Καθαρισμός Πεδίων";
            ClearBTN.Name = "ClearBTN";
            ClearBTN.Resizable = DataGridViewTriState.True;
            ClearBTN.SortMode = DataGridViewColumnSortMode.Automatic;
            ClearBTN.Text = "Καθαρισμός";
            ClearBTN.ToolTipText = "Πατήστε για καθαρισμό πεδίων βοηθήματος μετατροπής συντεταγμένων";
            ClearBTN.UseColumnTextForButtonValue = true;
            // 
            // CoordinatesConvert
            // 
            CoordinatesConvert.HeaderText = "Μετατροπή Συντεταγμένων";
            CoordinatesConvert.Name = "CoordinatesConvert";
            CoordinatesConvert.Resizable = DataGridViewTriState.True;
            CoordinatesConvert.SortMode = DataGridViewColumnSortMode.Automatic;
            CoordinatesConvert.Text = "Μετατροπή";
            CoordinatesConvert.ToolTipText = "Πατήστε για μετατροπή συντεταγμένων";
            CoordinatesConvert.UseColumnTextForButtonValue = true;
            // 
            // AddToTable
            // 
            AddToTable.HeaderText = "Εισαγωγή στον Πίνακα";
            AddToTable.Name = "AddToTable";
            AddToTable.Text = "Εισαγωγή στο Πίνακα";
            AddToTable.ToolTipText = "Πατήστε για να εισαχθούν οι συντεταγμένες σε νέα γραμμή του πίνακα";
            AddToTable.UseColumnTextForButtonValue = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(3, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(1078, 74);
            richTextBox1.TabIndex = 5;
            richTextBox1.TabStop = false;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle10.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1078, 337);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 205);
            label1.Name = "label1";
            label1.Size = new Size(1078, 17);
            label1.TabIndex = 6;
            label1.Text = "ΕΙΣΑΓΕΤΕ ΤΑ ΣΗΜΕΙΑ ΣΤΟΝ ΚΑΤΩ ΠΙΝΑΚΑ ΓΙΑ ΔΗΜΙΟΥΡΓΙΑ KML ΑΡΧΕΙΟΥ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 611);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KML Builder WGS 84";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUtility).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem αρχείοToolStripMenuItem;
        private ToolStripMenuItem openKMLToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem βοήθειαToolStripMenuItem;
        private ToolStripMenuItem πληροφορίεςToolStripMenuItem;
        private ToolStripStatusLabel statusLabel;
        private ToolStrip toolStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewUtility;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripMenuItem universalTransverseMercatorZonesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem άδειαΧρήσηςToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem οδηγίεςΧρήσηςToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private Label label1;
        private DataGridViewTextBoxColumn WGS84Lat;
        private DataGridViewTextBoxColumn WGS84Lon;
        private DataGridViewTextBoxColumn MGRS;
        private DataGridViewButtonColumn ClearBTN;
        private DataGridViewButtonColumn CoordinatesConvert;
        private DataGridViewButtonColumn AddToTable;
        private ToolStripMenuItem saveAsText;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem saveAsCSV;
    }
}
