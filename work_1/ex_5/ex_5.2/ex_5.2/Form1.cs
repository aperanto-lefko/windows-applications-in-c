using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ex_5._2
{
    public partial class Form1 : Form
    {
        private Button diamondButton;
        public Form1()
        {
            InitializeComponent();
            this.diamondButton = new Button();
            diamondButton.Size = new Size(200, 100); //������ ������
            diamondButton.Location = new Point(this.Width/2 - diamondButton.Width/2, 
                                               this.Height/2 - diamondButton.Height/2); //����� ���������
            diamondButton.Text = "GREENPEACE";
            diamondButton.MouseEnter += DiamondButton_MouseEnter; //������ ��� ���������
            diamondButton.Click += DiamondButton_Click; //�������� �� ������� ��� �������
            this.Controls.Add(diamondButton); //���������� ������  diamondButton �� �����
            SetDiamondRegion(diamondButton); //������������� ����� ������

        }

        private void DiamondButton_Click(object? sender, EventArgs e)
        {
           Close();
        }

        private void DiamondButton_MouseEnter(object? sender, EventArgs e)
        {
            diamondButton.BackColor = Color.Gold; //���� ��� ���������
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetDiamondRegion(Button button)
        {
            GraphicsPath path = new GraphicsPath(); //���� ����� ��������� ��������� ������� �����, ����������
                                                    //��������� �������������� ������.
            Point[] diamonPoints = new Point[] //����� ��� ����������� ����� ������
            {
                new Point(button.Width/2, 0),
                new Point(button.Width,button.Height/2),
                new Point(button.Width/2,button.Height),
                new Point(0,button.Height/2)
            };
            path.AddPolygon(diamonPoints);
            button.Region = new Region(path); //��������� ������ � ������

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, this.Height/2),
                              new Point(this.Width/2, this.Height),
                              new Point(this.Width, this.Height/2),
                              new Point(this.Width/2,0)});
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
