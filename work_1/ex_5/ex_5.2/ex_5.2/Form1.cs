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
            diamondButton.Size = new Size(200, 100); //размер кнопки
            diamondButton.Location = new Point(this.Width/2 - diamondButton.Width/2, 
                                               this.Height/2 - diamondButton.Height/2); //место установки
            diamondButton.Text = "GREENPEACE";
            diamondButton.MouseEnter += DiamondButton_MouseEnter; //Ёффект при наведении
            diamondButton.Click += DiamondButton_Click; //подписка на событие при нажатии
            this.Controls.Add(diamondButton); //добавление кнопки  diamondButton на форму
            SetDiamondRegion(diamondButton); //устанавливаем форму кнопки

        }

        private void DiamondButton_Click(object? sender, EventArgs e)
        {
           Close();
        }

        private void DiamondButton_MouseEnter(object? sender, EventArgs e)
        {
            diamondButton.BackColor = Color.Gold; //цвет при наведении
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetDiamondRegion(Button button)
        {
            GraphicsPath path = new GraphicsPath(); //Ётот класс позвол€ет создавать сложные формы, комбиниру€
                                                    //различные геометрические фигуры.
            Point[] diamonPoints = new Point[] //точки дл€ определени€ формы кнопки
            {
                new Point(button.Width/2, 0),
                new Point(button.Width,button.Height/2),
                new Point(button.Width/2,button.Height),
                new Point(0,button.Height/2)
            };
            path.AddPolygon(diamonPoints);
            button.Region = new Region(path); //примен€ем регион к кнопке

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
