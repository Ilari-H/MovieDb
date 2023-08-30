namespace ML_DB.Tabs
{
    partial class UC_Search
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            RatingStyleComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            MovieLengthComboBox = new ComboBox();
            panel3 = new Panel();
            ApiKeylabel = new Label();
            label6 = new Label();
            SaveKeyBtn = new Button();
            HelpKeyBtn = new Button();
            label2 = new Label();
            ApiKeyTxtBox = new TextBox();
            MovieNameTxtBox = new TextBox();
            label1 = new Label();
            SearchBtn = new Button();
            MoviePanel = new Panel();
            GenreTxtBox = new RichTextBox();
            MovieRatedTxtBox = new Label();
            MovieInfoTxtBox = new RichTextBox();
            MoviePictureBox = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            MoviePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MoviePictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 27, 27);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(RatingStyleComboBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(MovieLengthComboBox);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(MovieNameTxtBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SearchBtn);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 412);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 127, 255);
            label5.Location = new Point(5, 249);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 14;
            label5.Text = "Rating style";
            // 
            // RatingStyleComboBox
            // 
            RatingStyleComboBox.BackColor = Color.FromArgb(0, 127, 255);
            RatingStyleComboBox.DisplayMember = "Short";
            RatingStyleComboBox.FlatStyle = FlatStyle.Flat;
            RatingStyleComboBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RatingStyleComboBox.ForeColor = Color.Black;
            RatingStyleComboBox.FormattingEnabled = true;
            RatingStyleComboBox.Items.AddRange(new object[] { "European", "USA" });
            RatingStyleComboBox.Location = new Point(103, 249);
            RatingStyleComboBox.Name = "RatingStyleComboBox";
            RatingStyleComboBox.RightToLeft = RightToLeft.No;
            RatingStyleComboBox.Size = new Size(121, 25);
            RatingStyleComboBox.TabIndex = 13;
            RatingStyleComboBox.Text = "European";
            RatingStyleComboBox.ValueMember = "Short";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 127, 255);
            label4.Location = new Point(2, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 21);
            label4.TabIndex = 11;
            label4.Text = "Free Key: 5110b6d3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 127, 255);
            label3.Location = new Point(5, 200);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 12;
            label3.Text = "Plot";
            // 
            // MovieLengthComboBox
            // 
            MovieLengthComboBox.BackColor = Color.FromArgb(0, 127, 255);
            MovieLengthComboBox.DisplayMember = "Short";
            MovieLengthComboBox.FlatStyle = FlatStyle.Flat;
            MovieLengthComboBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MovieLengthComboBox.ForeColor = Color.Black;
            MovieLengthComboBox.FormattingEnabled = true;
            MovieLengthComboBox.Items.AddRange(new object[] { "Short", "Full" });
            MovieLengthComboBox.Location = new Point(51, 200);
            MovieLengthComboBox.Name = "MovieLengthComboBox";
            MovieLengthComboBox.RightToLeft = RightToLeft.No;
            MovieLengthComboBox.Size = new Size(121, 25);
            MovieLengthComboBox.TabIndex = 11;
            MovieLengthComboBox.Text = "Short";
            MovieLengthComboBox.ValueMember = "Short";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(ApiKeylabel);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(SaveKeyBtn);
            panel3.Controls.Add(HelpKeyBtn);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(ApiKeyTxtBox);
            panel3.ForeColor = Color.FromArgb(0, 127, 255);
            panel3.Location = new Point(38, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(143, 83);
            panel3.TabIndex = 10;
            // 
            // ApiKeylabel
            // 
            ApiKeylabel.AutoSize = true;
            ApiKeylabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ApiKeylabel.ForeColor = Color.FromArgb(0, 127, 255);
            ApiKeylabel.Location = new Point(70, 55);
            ApiKeylabel.Name = "ApiKeylabel";
            ApiKeylabel.Size = new Size(33, 17);
            ApiKeylabel.TabIndex = 12;
            ApiKeylabel.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 127, 255);
            label6.Location = new Point(4, 55);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 11;
            label6.Text = "Using key: ";
            // 
            // SaveKeyBtn
            // 
            SaveKeyBtn.BackColor = Color.FromArgb(0, 127, 255);
            SaveKeyBtn.FlatStyle = FlatStyle.Flat;
            SaveKeyBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveKeyBtn.ForeColor = Color.Black;
            SaveKeyBtn.Location = new Point(85, 29);
            SaveKeyBtn.Name = "SaveKeyBtn";
            SaveKeyBtn.Size = new Size(53, 23);
            SaveKeyBtn.TabIndex = 10;
            SaveKeyBtn.Text = "Use";
            SaveKeyBtn.UseVisualStyleBackColor = false;
            SaveKeyBtn.Click += SaveKeyBtn_Click;
            // 
            // HelpKeyBtn
            // 
            HelpKeyBtn.BackColor = Color.Black;
            HelpKeyBtn.FlatStyle = FlatStyle.Flat;
            HelpKeyBtn.Font = new Font("Calibri Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            HelpKeyBtn.ForeColor = Color.FromArgb(0, 127, 255);
            HelpKeyBtn.Location = new Point(118, 0);
            HelpKeyBtn.Name = "HelpKeyBtn";
            HelpKeyBtn.Size = new Size(23, 23);
            HelpKeyBtn.TabIndex = 9;
            HelpKeyBtn.Text = "?";
            HelpKeyBtn.UseVisualStyleBackColor = false;
            HelpKeyBtn.Click += HelpKeyBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 127, 255);
            label2.Location = new Point(19, 2);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 7;
            label2.Text = "OMDB KEY";
            // 
            // ApiKeyTxtBox
            // 
            ApiKeyTxtBox.BackColor = Color.Black;
            ApiKeyTxtBox.BorderStyle = BorderStyle.FixedSingle;
            ApiKeyTxtBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ApiKeyTxtBox.ForeColor = Color.FromArgb(0, 127, 255);
            ApiKeyTxtBox.Location = new Point(4, 29);
            ApiKeyTxtBox.Name = "ApiKeyTxtBox";
            ApiKeyTxtBox.PlaceholderText = "XXXXXXXX";
            ApiKeyTxtBox.Size = new Size(75, 23);
            ApiKeyTxtBox.TabIndex = 8;
            ApiKeyTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MovieNameTxtBox
            // 
            MovieNameTxtBox.BackColor = Color.FromArgb(27, 27, 27);
            MovieNameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            MovieNameTxtBox.Cursor = Cursors.IBeam;
            MovieNameTxtBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MovieNameTxtBox.ForeColor = Color.FromArgb(0, 127, 255);
            MovieNameTxtBox.Location = new Point(51, 150);
            MovieNameTxtBox.Name = "MovieNameTxtBox";
            MovieNameTxtBox.Size = new Size(173, 23);
            MovieNameTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 127, 255);
            label1.Location = new Point(5, 150);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // SearchBtn
            // 
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.FromArgb(0, 127, 255);
            SearchBtn.Location = new Point(3, 371);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(232, 36);
            SearchBtn.TabIndex = 0;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // MoviePanel
            // 
            MoviePanel.BackColor = Color.FromArgb(27, 27, 27);
            MoviePanel.Controls.Add(GenreTxtBox);
            MoviePanel.Controls.Add(MovieRatedTxtBox);
            MoviePanel.Controls.Add(MovieInfoTxtBox);
            MoviePanel.Controls.Add(MoviePictureBox);
            MoviePanel.Dock = DockStyle.Fill;
            MoviePanel.Location = new Point(240, 0);
            MoviePanel.Name = "MoviePanel";
            MoviePanel.Size = new Size(533, 412);
            MoviePanel.TabIndex = 1;
            MoviePanel.Visible = false;
            // 
            // GenreTxtBox
            // 
            GenreTxtBox.BackColor = Color.FromArgb(27, 27, 27);
            GenreTxtBox.BorderStyle = BorderStyle.None;
            GenreTxtBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenreTxtBox.ForeColor = Color.White;
            GenreTxtBox.Location = new Point(373, 263);
            GenreTxtBox.Name = "GenreTxtBox";
            GenreTxtBox.ReadOnly = true;
            GenreTxtBox.RightToLeft = RightToLeft.No;
            GenreTxtBox.ScrollBars = RichTextBoxScrollBars.None;
            GenreTxtBox.ShortcutsEnabled = false;
            GenreTxtBox.ShowSelectionMargin = true;
            GenreTxtBox.Size = new Size(148, 109);
            GenreTxtBox.TabIndex = 0;
            GenreTxtBox.Text = "Genres";
            // 
            // MovieRatedTxtBox
            // 
            MovieRatedTxtBox.AutoSize = true;
            MovieRatedTxtBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MovieRatedTxtBox.ForeColor = Color.White;
            MovieRatedTxtBox.Location = new Point(370, 238);
            MovieRatedTxtBox.Name = "MovieRatedTxtBox";
            MovieRatedTxtBox.Size = new Size(67, 21);
            MovieRatedTxtBox.TabIndex = 3;
            MovieRatedTxtBox.Text = "Rated: ";
            // 
            // MovieInfoTxtBox
            // 
            MovieInfoTxtBox.BackColor = Color.FromArgb(27, 27, 27);
            MovieInfoTxtBox.BorderStyle = BorderStyle.FixedSingle;
            MovieInfoTxtBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MovieInfoTxtBox.ForeColor = Color.FromArgb(0, 127, 255);
            MovieInfoTxtBox.Location = new Point(6, 12);
            MovieInfoTxtBox.Name = "MovieInfoTxtBox";
            MovieInfoTxtBox.ReadOnly = true;
            MovieInfoTxtBox.Size = new Size(358, 360);
            MovieInfoTxtBox.TabIndex = 1;
            MovieInfoTxtBox.Text = "";
            // 
            // MoviePictureBox
            // 
            MoviePictureBox.BorderStyle = BorderStyle.FixedSingle;
            MoviePictureBox.Location = new Point(370, 12);
            MoviePictureBox.Name = "MoviePictureBox";
            MoviePictureBox.Size = new Size(151, 214);
            MoviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MoviePictureBox.TabIndex = 0;
            MoviePictureBox.TabStop = false;
            // 
            // UC_Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MoviePanel);
            Controls.Add(panel1);
            Name = "UC_Search";
            Size = new Size(773, 412);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            MoviePanel.ResumeLayout(false);
            MoviePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MoviePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button SearchBtn;
        private TextBox MovieNameTxtBox;
        private Label label1;
        private Panel MoviePanel;
        private RichTextBox MovieInfoTxtBox;
        private PictureBox MoviePictureBox;
        private Label MovieRatedTxtBox;
        private RichTextBox GenreTxtBox;
        private Panel panel3;
        private Button SaveKeyBtn;
        private Button HelpKeyBtn;
        private Label label2;
        private TextBox ApiKeyTxtBox;
        private Label label3;
        private ComboBox MovieLengthComboBox;
        private Label label4;
        private Label label5;
        private ComboBox RatingStyleComboBox;
        private Label ApiKeylabel;
        private Label label6;
    }
}
