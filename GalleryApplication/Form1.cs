using Microsoft.VisualBasic;

namespace GalleryApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG Images(*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Images(*.png)|*.png|All Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.FilterIndex = 3;
            ofd.Title = "Select Images";
            ofd.Multiselect = true;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = ofd.FileNames;

                foreach (string p in filePaths)
                {
                    AddPictureBox(p);
                }

            }
        }


        private void Pb_Click(object? sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            PictureBox pbCopy = new PictureBox();
            pbCopy.ImageLocation = pb.ImageLocation;
            pbCopy.SizeMode = pb.SizeMode;
            pbCopy.Dock = DockStyle.Fill;

            Form popUp = new Form();
            popUp.Text = "Image Preview";
            popUp.Width = 500;
            popUp.Height = 500;

            popUp.Controls.Add(pbCopy);

            popUp.Show();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            List<string> filePathsToSave = new List<string>();

            foreach (Panel pnl in flowLayoutPanel.Controls) 
            {

                PictureBox pb = pnl.Controls[0] as PictureBox;
                filePathsToSave.Add(pb.ImageLocation);
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Images";
            sfd.Filter = "Gallery Files(*.glr)|*.glr";
            sfd.FilterIndex = 1;
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // write the file paths into the file with the name specified in the Save File Dialog
                System.IO.File.WriteAllLines(sfd.FileName, filePathsToSave);
                MessageBox.Show("Gallery saved.");
            }
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Gallery";
            ofd.Filter = "Gallery Files(*.glr)|*.glr";
            ofd.FilterIndex = 1;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] filesToOpen = System.IO.File.ReadAllLines(ofd.FileName);

                flowLayoutPanel.Controls.Clear();

                foreach (string path in filesToOpen)
                {
                    AddPictureBox(path);
                }
            }
           
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
        private void AddPictureBox(string p)
        {
            Panel pnl = new Panel();
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Height = 75;
            pnl.Width = 75;

            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.ImageLocation = p;
            pb.Dock = DockStyle.Fill;

            pb.Click += Pb_Click;

            pnl.Controls.Add(pb);

            flowLayoutPanel.Controls.Add(pnl);
        }

    }
}
