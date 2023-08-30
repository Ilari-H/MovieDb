namespace ML_DB
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            MinimizeBtn = new Button();
            CloseBtn = new Button();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            UCLibraryBtn = new Button();
            UCSearchBtn = new Button();
            label1 = new Label();
            UCHomeBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(MinimizeBtn);
            panel1.Controls.Add(CloseBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 38);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_Move;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.BackColor = Color.FromArgb(0, 127, 255);
            MinimizeBtn.FlatStyle = FlatStyle.Flat;
            MinimizeBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MinimizeBtn.Location = new Point(722, 2);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(35, 35);
            MinimizeBtn.TabIndex = 1;
            MinimizeBtn.Text = "-";
            MinimizeBtn.UseVisualStyleBackColor = false;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.FromArgb(0, 127, 255);
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CloseBtn.Location = new Point(763, 2);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(35, 35);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(UCLibraryBtn);
            panel2.Controls.Add(UCSearchBtn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(UCHomeBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 412);
            panel2.TabIndex = 1;
            panel2.Click += panel2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Black;
            checkBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(0, 127, 255);
            checkBox1.Location = new Point(58, 375);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 25);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "TopMost";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // UCLibraryBtn
            // 
            UCLibraryBtn.AutoSize = true;
            UCLibraryBtn.BackColor = Color.FromArgb(0, 127, 255);
            UCLibraryBtn.FlatStyle = FlatStyle.Flat;
            UCLibraryBtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UCLibraryBtn.Location = new Point(40, 115);
            UCLibraryBtn.Name = "UCLibraryBtn";
            UCLibraryBtn.Size = new Size(140, 40);
            UCLibraryBtn.TabIndex = 5;
            UCLibraryBtn.Text = "Library";
            UCLibraryBtn.UseVisualStyleBackColor = false;
            UCLibraryBtn.Click += UCLibraryBtn_Click;
            // 
            // UCSearchBtn
            // 
            UCSearchBtn.AutoSize = true;
            UCSearchBtn.BackColor = Color.FromArgb(0, 127, 255);
            UCSearchBtn.FlatStyle = FlatStyle.Flat;
            UCSearchBtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UCSearchBtn.Location = new Point(40, 69);
            UCSearchBtn.Name = "UCSearchBtn";
            UCSearchBtn.Size = new Size(140, 40);
            UCSearchBtn.TabIndex = 4;
            UCSearchBtn.Text = "Search";
            UCSearchBtn.UseVisualStyleBackColor = false;
            UCSearchBtn.Click += UCSearchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 127, 255);
            label1.Location = new Point(3, 184);
            label1.Name = "label1";
            label1.Size = new Size(31, 32);
            label1.TabIndex = 2;
            label1.Text = ">";
            // 
            // UCHomeBtn
            // 
            UCHomeBtn.AutoSize = true;
            UCHomeBtn.BackColor = Color.FromArgb(0, 127, 255);
            UCHomeBtn.FlatStyle = FlatStyle.Flat;
            UCHomeBtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UCHomeBtn.Location = new Point(40, 23);
            UCHomeBtn.Name = "UCHomeBtn";
            UCHomeBtn.Size = new Size(140, 40);
            UCHomeBtn.TabIndex = 3;
            UCHomeBtn.Text = "Home";
            UCHomeBtn.UseVisualStyleBackColor = false;
            UCHomeBtn.Click += UCHomeBtn_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(27, 27, 27);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(194, 38);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(606, 412);
            panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "DBFIM";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button MinimizeBtn;
        private Button CloseBtn;
        private Panel panel2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button UCLibraryBtn;
        private Button UCSearchBtn;
        private Button UCHomeBtn;
        private PictureBox pictureBox1;
        private Panel panelContainer;
        private CheckBox checkBox1;
    }
}