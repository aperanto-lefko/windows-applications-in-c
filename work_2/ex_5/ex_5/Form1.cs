namespace ex_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                this.but.Text = "First";
            else if (radioButton2.Checked == true)
                this.but.Text = "Second";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SetFlowBreak(button6, true);
            //SetFlowBreak(Control child, bool break) ������������ ��� ���������� ���, ��� �������� ������������� ������ FlowLayoutPanel.
            //Control child: ��� ������� ����������, ��� �������� �� ������ ���������� ������ ������. � ������ ������
            //��� button6.
            // bool break: ���������� ��������, �����������, ����� �� ���������� ������ ������ �����
            // ���������� ��������.���� true, ��� ��������, ��� ��������� ������� ���������� �����
            // ������������� �� ����� ������(��� � ����� �������, � ����������� �� ����������� ������).
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button aButton = new Button();
            tableLayoutPanel1.Controls.Add(aButton, 1, 1);
            //��������� 1, 1 ���������, � ����� ������ ������� ����� ��������� ������:
            // ������ ��������(1) � ��� ������ �������(��������� ���������� � 0).
            //������ ��������(1) � ��� ������ ������(����� ���������� � 0).
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (splitContainer1.FixedPanel == FixedPanel.Panel1)

                /*
                 * ����� �����������, �������� �� ������������� ������� Panel1 � �������� 
                 * ���������� SplitContainer (� ������ ������ splitContainer1).
                FixedPanel � ��� ��������, ������� ����������, ����� ������ (���� ������� �������) ����� 
                ������������� � �� ����� �������� ���� ������ ��� ��������� ������� ����������.
                 * */

                splitContainer1.FixedPanel = FixedPanel.None;
            else
                splitContainer1.FixedPanel = FixedPanel.Panel1;

            /*
             *  ��� ������ ��� ������������ ������������� ������ � SplitContainer ����� Panel1 � 
             *  ����������, ����� ������������� ������ �����������. ��� ����� ���� ������� 
             *  ��� ������������� ��������� ���������� ������������, �������� ������������ 
             *  ��������, ����� ������ �� ����� �������� �������������, � ����� � �������� �� �������.
             * */
        }

        private void button11_Click(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed = !(splitContainer1.IsSplitterFixed);
            /*
             * IsSplitterFixed � ��� ���������� ��������, ������� ����������, ����� �� ������������ ���������� ����������� ����� ����� �������� � SplitContainer.
             ���� IsSplitterFixed ����������� � true, ����������� ����������, � ������������ �� ����� �������� ��� ���������.
             ���� IsSplitterFixed ����������� � false, ����������� ����� ���� ���������, � ������������ ����� �������� ������� �������.
             * */

        }

        private void button12_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !(splitContainer1.Panel1Collapsed);
            /*
             * Panel1Collapsed � ��� ���������� ��������, ������� ����������, ������ �� ������ 1 (Panel1) � �������� ���������� SplitContainer.
             ���� Panel1Collapsed ����������� � true, ������ 1 ������, � �� ������� �� ������������.
             ���� Panel1Collapsed ����������� � false, ������ 1 ������ � �������� ���� ����� � ����������.
             * 
             * */
        }
    }
}
