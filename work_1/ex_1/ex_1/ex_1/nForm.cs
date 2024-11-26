using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_1
{
    public partial class nForm : Form
    {
        private bool nclose = false;
        public nForm()
        {
            InitializeComponent();
        }
        /*
         Второй вариант решения проблемы будет основан на обработке события, 
        возникающее перед закрытием второй формы – закрытие формы будет подменено 
        его скрытием (Hide).
         */
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //Эта строка отменяет закрытие формы. Когда вы устанавливаете
                             //e.Cancel в true, это говорит системе, что вы не хотите,
                             //чтобы форма закрывалась
            Hide(); //Эта строка скрывает форму, не закрывая её. Это означает,
                    //что форма не будет видна пользователю, но при этом все её
                    //данные и состояние сохранятся в памяти. Вы можете позже показать
                    //форму снова, вызвав метод Show().
            /*if (checkBoxClose.Checked)
            {
                // Если CheckBox установлен, разрешаем закрытие формы
                e.Cancel = false; // Устанавливаем Cancel в false, чтобы форма закрылась
            }
            else
            {
                // Если CheckBox не установлен, отменяем закрытие и скрываем форму
                e.Cancel = true; // Отменяем закрытие формы
                Hide(); // Скрываем форму
            }*/
            if (nclose) return;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Closed_Click(object sender, EventArgs e)
        {
            nclose = true;
            base.Close();
        }
     
    }
}

