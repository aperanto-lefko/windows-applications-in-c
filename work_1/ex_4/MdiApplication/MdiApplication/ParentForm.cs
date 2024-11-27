namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            //System.Windows.Forms.MdiLayout.Cascade: Это значение перечисления MdiLayout,
            //которое указывает, что дочерние формы должны быть расположены в виде каскада.
            //Это означает, что формы будут накладываться друг на друга, и каждая последующая
            //будет смещена на несколько пикселей вниз и вправо от предыдущей.
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            //Это значение перечисления MdiLayout, которое указывает, что дочерние формы
            //должны быть расположены горизонтально в виде плитки. Это означает, что все
            //открытые дочерние формы будут выровнены по горизонтали, и каждая форма будет
            //занимать всю ширину родительской формы, но высота будет равняться высоте самой формы
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocuments; //К свойству Text дочерней формы добавьте счетчик числа открываемых документов
        }
    }
}
