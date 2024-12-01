namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {


                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(label4.Location.X, label4.Location.Y + 40);
                lbl.Size = new System.Drawing.Size(32, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(textBox2.Location.X, textBox2.Location.Y + 40);
                txt.Size = textBox2.Size;
                txt.Name = "textboxx";

                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
                //txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
                // Подписываем текстовое поле на событие Validating
                txt.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
                
            }
            else
            {
                /*
                 * Для удаления ЭУ с формы могут применяться методы: Clear (удаление всех элементов из коллекции), 
                 * Remove (удаление элемента из коллекции) и 
                 * RemoveAt (удаление элемента по заданному индексу). 
                 * В тело оператора else добавьте код для удаления ЭУ по индексу:
                 * */

                int lcv;
                lcv = groupBox1.Controls.Count;// определяется количество элементов
                while (lcv > 8)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //события KeyPress, возникающего при нажатии любой клавиши в поле.
        {
            if (char.IsDigit(e.KeyChar))
            /*
             * Этот метод проверяет, является ли символ, который был нажат (представленный e.KeyChar), цифрой (0-9).
e.KeyChar — это свойство объекта KeyPressEventArgs, которое содержит символ, связанный с событием нажатия клавиши.
              */
            {
                e.Handled = true;
                /*
                 * Установка e.Handled в true указывает системе, что событие обработки клавиши было обработано, и что дальнейшая обработка этого события не требуется.
В контексте текстового поля это означает, что символ, который пользователь пытался ввести (в данном случае цифра), не будет добавлен в текстовое поле.
Таким образом, фактически ввод цифры в текстовое поле отменяется.
                 * */
                MessageBox.Show("Поле Name не может содержать цифры");
                errorProvider1.SetError(textBox1, "Must be letter");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (!char.IsDigit(e.KeyChar))
                
{
                e.Handled = true;
                MessageBox.Show("Поле PIN не может содержать буквы");
            }*/

        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txt = sender as TextBox; //чтобы обработчик работал для нескольких боксов сделали универсальный метод
            if (txt.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(txt.Text);// попытка преобразовать текст из textBox2 в число типа double с помощью метода double.Parse.
                    e.Cancel = false; // Если преобразование успешно, устанавливается e.Cancel = false, что позволяет продолжить выполнение действия.
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                }
            }

            /*
             * e.Cancel = true: Это указывает, что действие должно быть отменено. 
             * Например, если это событие закрытия формы, установка e.Cancel в true предотвратит закрытие формы.
            e.Cancel = false: Это указывает, что действие может продолжаться. 
            Например, если валидация прошла успешно, и вы хотите разрешить переход к следующему элементу 
            управления или закрытие формы.
             * */
        }
    }
}