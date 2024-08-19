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

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = ofd.FileNames;

                foreach (string p in filePaths)
                {
                    Panel pnl = new Panel();
                    pnl.BorderStyle = BorderStyle.FixedSingle;
                    pnl.Height = 75;
                    pnl.Width = 75;

                    PictureBox pb = new PictureBox();
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.ImageLocation = p;
                    pb.Dock = DockStyle.Fill;   

                    pnl.Controls.Add(pb);

                    flowLayoutPanel.Controls.Add(pnl);
                }

            }
        }
    }
}
