namespace HomeWork4_6_5 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ListViewGroup listViewGroup1 = new ListViewGroup("Методи", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("Властивості", HorizontalAlignment.Left);
            ListViewGroup listViewGroup3 = new ListViewGroup("Поля", HorizontalAlignment.Left);
            ListViewGroup listViewGroup4 = new ListViewGroup("Події", HorizontalAlignment.Left);
            toolStrip1 = new ToolStrip();
            menuOpenFile = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            lvTypes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lblFileName = new Label();
            lvMembers = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { menuOpenFile });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // menuOpenFile
            // 
            menuOpenFile.Image = Properties.Resources.document__1_;
            menuOpenFile.ImageTransparentColor = Color.Magenta;
            menuOpenFile.Name = "menuOpenFile";
            menuOpenFile.Size = new Size(100, 22);
            menuOpenFile.Text = "Обрати файл";
            menuOpenFile.Click += menuOpenFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Пошук dll|*.dll|Пошук exe|*.exe";
            // 
            // lvTypes
            // 
            lvTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lvTypes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvTypes.FullRowSelect = true;
            lvTypes.GridLines = true;
            lvTypes.Location = new Point(12, 62);
            lvTypes.MultiSelect = false;
            lvTypes.Name = "lvTypes";
            lvTypes.Size = new Size(408, 376);
            lvTypes.TabIndex = 1;
            lvTypes.UseCompatibleStateImageBehavior = false;
            lvTypes.View = View.Details;
            lvTypes.SelectedIndexChanged += lvTypes_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Type";
            columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Is Public";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileName.Location = new Point(12, 35);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(16, 21);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "-";
            // 
            // lvMembers
            // 
            lvMembers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvMembers.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            lvMembers.FullRowSelect = true;
            lvMembers.GridLines = true;
            listViewGroup1.Header = "Методи";
            listViewGroup1.Name = "grpMethods";
            listViewGroup2.Header = "Властивості";
            listViewGroup2.Name = "grpProps";
            listViewGroup3.Header = "Поля";
            listViewGroup3.Name = "grpFields";
            listViewGroup4.Header = "Події";
            listViewGroup4.Name = "grpEvents";
            lvMembers.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3, listViewGroup4 });
            lvMembers.Location = new Point(435, 62);
            lvMembers.MultiSelect = false;
            lvMembers.Name = "lvMembers";
            lvMembers.Size = new Size(341, 376);
            lvMembers.TabIndex = 3;
            lvMembers.UseCompatibleStateImageBehavior = false;
            lvMembers.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Type";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Is Public";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvMembers);
            Controls.Add(lblFileName);
            Controls.Add(lvTypes);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton menuOpenFile;
        private OpenFileDialog openFileDialog1;
        private ListView lvTypes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label lblFileName;
        private ListView lvMembers;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
