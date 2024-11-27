namespace ex_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path =
new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            this.Region = new Region(path);

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
