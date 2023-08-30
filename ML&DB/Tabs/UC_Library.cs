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



namespace ML_DB.Tabs
{
    public partial class UC_Library : UserControl
    {
        private string targetFolderPath;

        public UC_Library()
        {
            InitializeComponent();

            MovieFolderTxtBox.Text = Properties.Settings.Default.FileSave;

            targetFolderPath = MovieFolderTxtBox.Text;


            AllowDrop = true;
            DragEnter += UC_Library_DragEnter;
            DragDrop += UC_Library_DragDrop;
        }

        private void FileSelectBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    MovieFolderTxtBox.Text = fbd.SelectedPath;

                    Properties.Settings.Default.FileSave = MovieFolderTxtBox.Text;
                    Properties.Settings.Default.Save(); //tallentaa uuden Folderin!
                }
            }

        } //Selecting folder & saving it

        private void LibraryMovieSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(MovieFolderTxtBox.Text);
                FileInfo[] Files = d.GetFiles();
                if (MovieNameTxtBox.Text == "")
                {
                    FileitemsTxtBox.Text = "                    -Movies-";
                    foreach (FileInfo file in Files)
                    {
                        string name = file.Name;
                        FileitemsTxtBox.Text += "\r" + name;


                    }
                }
                else
                {
                    FileitemsTxtBox.Text = "                    -Movies-";
                    foreach (FileInfo file in Files)
                    {
                        string name = file.Name;
                        if (MovieNameTxtBox.Text.Contains(name.FirstOrDefault()))
                        {
                            FileitemsTxtBox.Text += "\r" + name;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                return;
            }

        } //Gets all files from selected folder

        private void PlayMovieBtn_Click(object sender, EventArgs e)
        {
            string Path = MovieFolderTxtBox.Text + "/" + RunMovieNameTxtBox.Text;

            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = Path;
            p.StartInfo = psi;

            try
            {
                p.Start();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        } //Runs given file


        //Dropbox
        private void UC_Library_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (!Directory.Exists(targetFolderPath))
                    Directory.CreateDirectory(targetFolderPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destinationPath = Path.Combine(targetFolderPath, fileName);

                    if (File.Exists(destinationPath))
                    {
                        return;
                    }

                    File.Move(file, destinationPath);
                }
                
            }
            catch(Exception)
            {
                return;
            }
        }

        private void UC_Library_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}
