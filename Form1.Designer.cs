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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            αρχείοToolStripMenuItem = new ToolStripMenuItem();
            άνοιγμαΑρχείουKMLToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            βοήθειαToolStripMenuItem = new ToolStripMenuItem();
            πληροφορίεςToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 439);
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
            αρχείοToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { άνοιγμαΑρχείουKMLToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            αρχείοToolStripMenuItem.Name = "αρχείοToolStripMenuItem";
            αρχείοToolStripMenuItem.Size = new Size(55, 20);
            αρχείοToolStripMenuItem.Text = "Αρχείο";
            // 
            // άνοιγμαΑρχείουKMLToolStripMenuItem
            // 
            άνοιγμαΑρχείουKMLToolStripMenuItem.Name = "άνοιγμαΑρχείουKMLToolStripMenuItem";
            άνοιγμαΑρχείουKMLToolStripMenuItem.Size = new Size(191, 22);
            άνοιγμαΑρχείουKMLToolStripMenuItem.Text = "Άνοιγμα Αρχείου KML";
            άνοιγμαΑρχείουKMLToolStripMenuItem.Click += άνοιγμαΑρχείουKMLToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(188, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(191, 22);
            saveToolStripMenuItem.Text = "Αποθήκευση";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(191, 22);
            saveAsToolStripMenuItem.Text = "Αποθήκευση ως...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(188, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(191, 22);
            exitToolStripMenuItem.Text = "Έξοδος";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // βοήθειαToolStripMenuItem
            // 
            βοήθειαToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { πληροφορίεςToolStripMenuItem });
            βοήθειαToolStripMenuItem.Name = "βοήθειαToolStripMenuItem";
            βοήθειαToolStripMenuItem.Size = new Size(62, 20);
            βοήθειαToolStripMenuItem.Text = "Βοήθεια";
            // 
            // πληροφορίεςToolStripMenuItem
            // 
            πληροφορίεςToolStripMenuItem.Name = "πληροφορίεςToolStripMenuItem";
            πληροφορίεςToolStripMenuItem.Size = new Size(180, 22);
            πληροφορίεςToolStripMenuItem.Text = "Πληροφορίες";
            πληροφορίεςToolStripMenuItem.Click += πληροφορίεςToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1084, 415);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 461);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "KML Builder WGS 84";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem αρχείοToolStripMenuItem;
        private ToolStripMenuItem άνοιγμαΑρχείουKMLToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem βοήθειαToolStripMenuItem;
        private ToolStripMenuItem πληροφορίεςToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripStatusLabel statusLabel;
    }
}
