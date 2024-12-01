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
                // ����������� ��������� ���� �� ������� Validating
                txt.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
                
            }
            else
            {
                /*
                 * ��� �������� �� � ����� ����� ����������� ������: Clear (�������� ���� ��������� �� ���������), 
                 * Remove (�������� �������� �� ���������) � 
                 * RemoveAt (�������� �������� �� ��������� �������). 
                 * � ���� ��������� else �������� ��� ��� �������� �� �� �������:
                 * */

                int lcv;
                lcv = groupBox1.Controls.Count;// ������������ ���������� ���������
                while (lcv > 8)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //������� KeyPress, ������������ ��� ������� ����� ������� � ����.
        {
            if (char.IsDigit(e.KeyChar))
            /*
             * ���� ����� ���������, �������� �� ������, ������� ��� ����� (�������������� e.KeyChar), ������ (0-9).
e.KeyChar � ��� �������� ������� KeyPressEventArgs, ������� �������� ������, ��������� � �������� ������� �������.
              */
            {
                e.Handled = true;
                /*
                 * ��������� e.Handled � true ��������� �������, ��� ������� ��������� ������� ���� ����������, � ��� ���������� ��������� ����� ������� �� ���������.
� ��������� ���������� ���� ��� ��������, ��� ������, ������� ������������ ������� ������ (� ������ ������ �����), �� ����� �������� � ��������� ����.
����� �������, ���������� ���� ����� � ��������� ���� ����������.
                 * */
                MessageBox.Show("���� Name �� ����� ��������� �����");
                errorProvider1.SetError(textBox1, "Must be letter");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (!char.IsDigit(e.KeyChar))
                
{
                e.Handled = true;
                MessageBox.Show("���� PIN �� ����� ��������� �����");
            }*/

        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txt = sender as TextBox; //����� ���������� ������� ��� ���������� ������ ������� ������������� �����
            if (txt.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(txt.Text);// ������� ������������� ����� �� textBox2 � ����� ���� double � ������� ������ double.Parse.
                    e.Cancel = false; // ���� �������������� �������, ��������������� e.Cancel = false, ��� ��������� ���������� ���������� ��������.
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("���� PIN �� ����� ��������� �����");
                }
            }

            /*
             * e.Cancel = true: ��� ���������, ��� �������� ������ ���� ��������. 
             * ��������, ���� ��� ������� �������� �����, ��������� e.Cancel � true ������������ �������� �����.
            e.Cancel = false: ��� ���������, ��� �������� ����� ������������. 
            ��������, ���� ��������� ������ �������, � �� ������ ��������� ������� � ���������� �������� 
            ���������� ��� �������� �����.
             * */
        }
    }
}