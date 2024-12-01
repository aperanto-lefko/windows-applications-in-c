using System.Text;
using System.Windows.Forms;

namespace ex_6
{
    public partial class Form1 : Form
    {
        public string Author // автор
        {

            get { return textBoxAuthor.Text; }
            set { textBoxAuthor.Text = value; }
        }
        public string Title // Название
        {
            get { return textBoxTitle.Text; }
            set { textBoxTitle.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBoxPubl.Text; }
            set { textBoxPubl.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDownPages.Value; }
            set { numericUpDownPages.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDownYear.Value; }
            set { numericUpDownYear.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDownInvNumb.Value; }
            set { numericUpDownInvNumb.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox_availability.Checked; }
            set { checkBox_availability.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox_sortedByInvNumb.Checked; }
            set { checkBox_sortedByInvNumb.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox_return_on_time.Checked; }
            set { checkBox_return_on_time.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)numericUpDownDayOfUse.Value; }
            set { numericUpDownDayOfUse.Value = value; }
        }
        List<Item> its = new List<Item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
Page, Year, InvNumber, Existence);
            if (ReturnTime)
            {
                b.ReturnSrok();
            }
            b.PriceBook(PeriodUse); //расчет стоимости с учетом срока пользования книгой
            its.Add(b);
            //очистите поля ввода для новой информации
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2020;
            Existence = ReturnTime = false;
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
            {
                its.Sort();
            }
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();  //После построения строки выводим ее в элемент richTextBox1
        }
    }
}
