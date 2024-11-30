using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_5._2
{
    public partial class Form2 : Form
    {
        Button buttonOpenForm1;
        public Form2()
        {
            InitializeComponent();
            this.buttonOpenForm1 = new Button();
            buttonOpenForm1.Size = new Size(200, 100); //размер кнопки
            buttonOpenForm1.Text = "Open next Window";
            buttonOpenForm1.Click += ButtonOpenForm1_Click;
            this.Controls.Add(buttonOpenForm1); //добавление кнопки на форму
            this.Resize += Form2_Resize; //подписка обработчика на изменение размера формы
            CenterButton();
        }

        private void ButtonOpenForm1_Click(object? sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); //открытие Form 1
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterButton();
        }
        private void CenterButton()
        {
            buttonOpenForm1.Location = new Point(this.Width / 2 - buttonOpenForm1.Width / 2,
                                               this.Height / 2 - buttonOpenForm1.Height / 2); //место установки
        }
    }
}
