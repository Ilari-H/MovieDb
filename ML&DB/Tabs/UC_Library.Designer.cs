namespace ML_DB.Tabs
{
    partial class UC_Library
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
            PlayMovieBtn = new Button();
            RunMovieNameTxtBox = new TextBox();
            MovieNameTxtBox = new TextBox();
            label2 = new Label();
            LibraryMovieSearchBtn = new Button();
            FileitemsTxtBox = new RichTextBox();
            FileSelectBtn = new Button();
            MovieFolderTxtBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 27, 27);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(PlayMovieBtn);
            panel1.Controls.Add(RunMovieNameTxtBox);
            panel1.Controls.Add(MovieNameTxtBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LibraryMovieSearchBtn);
            panel1.Controls.Add(FileitemsTxtBox);
            panel1.Controls.Add(FileSelectBtn);
            panel1.Controls.Add(MovieFolderTxtBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 412);
            panel1.TabIndex = 0;
            // 
            // PlayMovieBtn
            // 
            PlayMovieBtn.BackColor = Color.FromArgb(0, 127, 255);
            PlayMovieBtn.FlatStyle = FlatStyle.Flat;
            PlayMovieBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PlayMovieBtn.ForeColor = Color.Black;
            PlayMovieBtn.Location = new Point(183, 382);
            PlayMovieBtn.Name = "PlayMovieBtn";
            PlayMovieBtn.Size = new Size(67, 26);
            PlayMovieBtn.TabIndex = 17;
            PlayMovieBtn.Text = "Play";
            PlayMovieBtn.UseVisualStyleBackColor = false;
            PlayMovieBtn.Click += PlayMovieBtn_Click;
            // 
            // RunMovieNameTxtBox
            // 
            RunMovieNameTxtBox.BackColor = Color.FromArgb(27, 27, 27);
            RunMovieNameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            RunMovieNameTxtBox.Cursor = Cursors.IBeam;
            RunMovieNameTxtBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RunMovieNameTxtBox.ForeColor = Color.FromArgb(0, 127, 255);
            RunMovieNameTxtBox.Location = new Point(3, 383);
            RunMovieNameTxtBox.Name = "RunMovieNameTxtBox";
            RunMovieNameTxtBox.PlaceholderText = "Plays given movie";
            RunMovieNameTxtBox.Size = new Size(174, 23);
            RunMovieNameTxtBox.TabIndex = 16;
            // 
            // MovieNameTxtBox
            // 
            MovieNameTxtBox.BackColor = Color.FromArgb(27, 27, 27);
            MovieNameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            MovieNameTxtBox.Cursor = Cursors.IBeam;
            MovieNameTxtBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MovieNameTxtBox.ForeColor = Color.FromArgb(0, 127, 255);
            MovieNameTxtBox.Location = new Point(13, 121);
            MovieNameTxtBox.Name = "MovieNameTxtBox";
            MovieNameTxtBox.PlaceholderText = "Leave empty for all movies";
            MovieNameTxtBox.Size = new Size(232, 23);
            MovieNameTxtBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 127, 255);
            label2.Location = new Point(3, 98);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 14;
            label2.Text = "Title";
            // 
            // LibraryMovieSearchBtn
            // 
            LibraryMovieSearchBtn.BackColor = Color.FromArgb(0, 127, 255);
            LibraryMovieSearchBtn.FlatStyle = FlatStyle.Flat;
            LibraryMovieSearchBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LibraryMovieSearchBtn.ForeColor = Color.Black;
            LibraryMovieSearchBtn.Location = new Point(181, 144);
            LibraryMovieSearchBtn.Name = "LibraryMovieSearchBtn";
            LibraryMovieSearchBtn.Size = new Size(64, 23);
            LibraryMovieSearchBtn.TabIndex = 13;
            LibraryMovieSearchBtn.Text = "search";
            LibraryMovieSearchBtn.UseVisualStyleBackColor = false;
            LibraryMovieSearchBtn.Click += LibraryMovieSearchBtn_Click;
            // 
            // FileitemsTxtBox
            // 
            FileitemsTxtBox.BackColor = Color.FromArgb(27, 27, 27);
            FileitemsTxtBox.BorderStyle = BorderStyle.FixedSingle;
            FileitemsTxtBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FileitemsTxtBox.ForeColor = Color.FromArgb(0, 127, 255);
            FileitemsTxtBox.Location = new Point(3, 173);
            FileitemsTxtBox.Name = "FileitemsTxtBox";
            FileitemsTxtBox.ReadOnly = true;
            FileitemsTxtBox.Size = new Size(247, 204);
            FileitemsTxtBox.TabIndex = 12;
            FileitemsTxtBox.Text = "                    -Movies-";
            // 
            // FileSelectBtn
            // 
            FileSelectBtn.BackColor = Color.FromArgb(0, 127, 255);
            FileSelectBtn.FlatStyle = FlatStyle.Flat;
            FileSelectBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FileSelectBtn.ForeColor = Color.Black;
            FileSelectBtn.Location = new Point(165, 56);
            FileSelectBtn.Name = "FileSelectBtn";
            FileSelectBtn.Size = new Size(80, 23);
            FileSelectBtn.TabIndex = 11;
            FileSelectBtn.Text = "Select file";
            FileSelectBtn.UseVisualStyleBackColor = false;
            FileSelectBtn.Click += FileSelectBtn_Click;
            // 
            // MovieFolderTxtBox
            // 
            MovieFolderTxtBox.BackColor = Color.FromArgb(27, 27, 27);
            MovieFolderTxtBox.BorderStyle = BorderStyle.FixedSingle;
            MovieFolderTxtBox.Cursor = Cursors.IBeam;
            MovieFolderTxtBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MovieFolderTxtBox.ForeColor = Color.FromArgb(0, 127, 255);
            MovieFolderTxtBox.Location = new Point(13, 33);
            MovieFolderTxtBox.Name = "MovieFolderTxtBox";
            MovieFolderTxtBox.PlaceholderText = "C:\\...";
            MovieFolderTxtBox.ReadOnly = true;
            MovieFolderTxtBox.Size = new Size(232, 23);
            MovieFolderTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 127, 255);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Select file";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(67, 67, 67);
            label3.Location = new Point(349, 176);
            label3.Name = "label3";
            label3.Size = new Size(337, 20);
            label3.TabIndex = 18;
            label3.Text = "Drop files here to move them to movie folder";
            // 
            // UC_Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "UC_Library";
            Size = new Size(773, 412);
            DragDrop += UC_Library_DragDrop;
            DragEnter += UC_Library_DragEnter;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox MovieFolderTxtBox;
        private Button FileSelectBtn;
        private RichTextBox FileitemsTxtBox;
        private Button LibraryMovieSearchBtn;
        private TextBox MovieNameTxtBox;
        private Label label2;
        private Button PlayMovieBtn;
        private TextBox RunMovieNameTxtBox;
        private Label label3;
    }
}
