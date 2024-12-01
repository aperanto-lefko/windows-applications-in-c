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
            //SetFlowBreak(Control child, bool break) используется для управления тем, как элементы располагаются внутри FlowLayoutPanel.
            //Control child: Это элемент управления, для которого вы хотите установить разрыв потока. В данном случае
            //это button6.
            // bool break: Логическое значение, указывающее, нужно ли установить разрыв потока после
            // указанного элемента.Если true, это означает, что следующий элемент управления будет
            // располагаться на новой строке(или в новом столбце, в зависимости от направления потока).
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button aButton = new Button();
            tableLayoutPanel1.Controls.Add(aButton, 1, 1);
            //Параметры 1, 1 указывают, в какую ячейку таблицы будет добавлена кнопка:
            // Первый параметр(1) — это индекс столбца(нумерация начинается с 0).
            //Второй параметр(1) — это индекс строки(также начинается с 0).
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (splitContainer1.FixedPanel == FixedPanel.Panel1)

                /*
                 * Здесь проверяется, является ли фиксированной панелью Panel1 в элементе 
                 * управления SplitContainer (в данном случае splitContainer1).
                FixedPanel — это свойство, которое определяет, какая панель (если таковая имеется) будет 
                фиксированной и не будет изменять свой размер при изменении размера контейнера.
                 * */

                splitContainer1.FixedPanel = FixedPanel.None;
            else
                splitContainer1.FixedPanel = FixedPanel.Panel1;

            /*
             *  код служит для переключения фиксированной панели в SplitContainer между Panel1 и 
             *  состоянием, когда фиксированная панель отсутствует. Это может быть полезно 
             *  для динамического изменения интерфейса пользователя, позволяя пользователю 
             *  выбирать, какую панель он хочет оставить фиксированной, а какую — изменять по размеру.
             * */
        }

        private void button11_Click(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed = !(splitContainer1.IsSplitterFixed);
            /*
             * IsSplitterFixed — это логическое свойство, которое определяет, может ли пользователь перемещать разделитель между двумя панелями в SplitContainer.
             Если IsSplitterFixed установлено в true, разделитель фиксирован, и пользователь не может изменять его положение.
             Если IsSplitterFixed установлено в false, разделитель может быть перемещен, и пользователь может изменять размеры панелей.
             * */

        }

        private void button12_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !(splitContainer1.Panel1Collapsed);
            /*
             * Panel1Collapsed — это логическое свойство, которое определяет, скрыта ли панель 1 (Panel1) в элементе управления SplitContainer.
             Если Panel1Collapsed установлено в true, панель 1 скрыта, и ее размеры не отображаются.
             Если Panel1Collapsed установлено в false, панель 1 видима и занимает свое место в интерфейсе.
             * 
             * */
        }
    }
}
