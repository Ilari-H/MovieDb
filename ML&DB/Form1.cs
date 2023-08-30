using ML_DB.Tabs;

namespace ML_DB
{
    public partial class Form1 : Form
    {
        public Point mouseLocation;


        public Form1()
        {
            InitializeComponent();
            panel2.Size = new System.Drawing.Size(27, 418);
            UC_Home uc = new UC_Home();
            addUserControll(uc);
        }


        private void addUserControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void UCHomeBtn_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControll(uc);
        }

        private void UCSearchBtn_Click(object sender, EventArgs e)
        {
            UC_Search uc = new UC_Search();
            addUserControll(uc);
        } 

        private void UCLibraryBtn_Click(object sender, EventArgs e)
        {
            UC_Library uc = new UC_Library();
            addUserControll(uc);

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        } //muuttaa Top most

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        } //sulkee ohjelman

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } //pienent‰‰ ohjelman

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }



        //Panels 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        } //Dragbar

        private void panel1_Move(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        } //dradgbar

        private void panel2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        } //menu panel

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (panel2.Width < 28)
            {
                int PanelSizeX = 27;
                int labelX = 3;
                while (PanelSizeX < 200)
                {
                    panel2.Size = new Size(PanelSizeX + 1, 418);
                    PanelSizeX++;
                    label1.Location = new Point(labelX + 1, 170);
                    labelX++;
                }
                label1.Text = "<";
                timer1.Stop();
            }
            else
            {
                int PanelSizeX = 200;
                int labelX = 176;
                while (PanelSizeX > 27)
                {
                    panel2.Size = new Size(PanelSizeX - 1, 418);
                    PanelSizeX--;
                    label1.Location = new Point(labelX - 1, 170);
                    labelX--;
                }
                label1.Text = ">";
                timer1.Stop();
            }


        } //Muuttaa menun kokoa

    }
}