namespace ex_1
{
    public partial class Form1 : Form
    {
        Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что Вы так думаете!");
        }

        private void btnno_Click(object sender, MouseEventArgs e)
        {
            btnno.Top -= e.Y;
            btnno.Left += e.X;
            if (btnno.Top < -10 || btnno.Top > 100)
                btnno.Top = 60;
            if (btnno.Left < -80 || btnno.Left > 250)
                btnno.Left = 120;
        }

        private void btnno_MouseEnter(object sender, EventArgs e)
        {
            MoveButton();
        }

        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            if (btnno.Bounds.Contains(e.Location))
            {
                MoveButton();
            }
        }

        private void MoveButton()
        {
            int newX = random.Next(0, this.ClientSize.Width - btnno.Width);
            int newY = random.Next(0, this.ClientSize.Height - btnno.Height);

            // Перемещение кнопки
            btnno.Location = new Point(newX, newY);
        }
    }
}
