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
            //System.Windows.Forms.MdiLayout.Cascade: ��� �������� ������������ MdiLayout,
            //������� ���������, ��� �������� ����� ������ ���� ����������� � ���� �������.
            //��� ��������, ��� ����� ����� ������������� ���� �� �����, � ������ �����������
            //����� ������� �� ��������� �������� ���� � ������ �� ����������.
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            //��� �������� ������������ MdiLayout, ������� ���������, ��� �������� �����
            //������ ���� ����������� ������������� � ���� ������. ��� ��������, ��� ���
            //�������� �������� ����� ����� ��������� �� �����������, � ������ ����� �����
            //�������� ��� ������ ������������ �����, �� ������ ����� ��������� ������ ����� �����
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocuments; //� �������� Text �������� ����� �������� ������� ����� ����������� ����������
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)//���������� �������, ������������� ��� ������� ������ �� ������ ������������
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm(); // ������� ����� ��������� �������� �����
                    newChild.MdiParent = this; // ������������� ������������ ����� ��� ������� MDI-�����
                    newChild.Show();// ���������� �������� �����
                    newChild.Text = newChild.Text + " " + ++openDocuments;// ��������� ��������� �����, �������� ���������� �������� ����������
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);// ������������� ��������� ������������ �������� ����
                    break;
                case "Title":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal); // ������������� �������������� ������������ �������� ����
                    break;
            }
        }
    }
}
