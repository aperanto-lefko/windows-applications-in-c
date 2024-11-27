namespace ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //��������� ����� ������ GraphicsPath, ������� ����� �������������� ��� ����������� ����������� ������
            //GraphicsPath ��������� ��������� ������� ����� ����� ���������� ��������� ����������, ����� ��� �����,
            //��������������, ������� � ��������������.
            System.Drawing.Drawing2D.GraphicsPath myPath =
            new System.Drawing.Drawing2D.GraphicsPath();

            //� ���� ��������� � ������� myPath ����������� �������������. �������������
            //������������ �������� ����� (Point[]), ������� ������� �� ���� �����:
            myPath.AddPolygon(new Point[] {

            //������� ����� ����.
            new Point(0, 0),

            //������ ����� ���� (�� ������ �������� ��������).this.Height ���������� �������� ������ �������� ����������
            new Point(0, this.Height),

            //������� ������ ���� (�� ������ �������� ��������).
            new Point(this.Width, 0) });

            //����� ��������� ������ Region, ������� ������������ ����� �������, ������������ �����
            //��������� GraphicsPath. ������� ����� �������������� ��� �����������, ����� ����� �������
            //����� ������������ ��� �������������� (��������, ��� ��������� ������� ����).
            Region myRegion = new Region(myPath);

            //� ���� ��������� ���� ������� myRegion ����������� � �������� �������� ���������� (this).
            //��� ��������, ��� ������ �������, ������������ �������������, ����� ������������ �� ������.
            //���, ��� ��������� �� ��������� ���� �������, ����� ������.
            this.Region = myRegion;
        }
    }
}
