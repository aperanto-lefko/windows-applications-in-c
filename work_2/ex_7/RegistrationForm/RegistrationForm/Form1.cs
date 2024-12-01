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
                lbl.Location = new System.Drawing.Point(label4.Location.X, label4.Location.Y+40);
                lbl.Size = new System.Drawing.Size(32, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(textBox2.Location.X, textBox2.Location.Y+40);
                txt.Size =textBox2.Size;
                txt.Name = "textboxx";
                
txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
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
    }
}