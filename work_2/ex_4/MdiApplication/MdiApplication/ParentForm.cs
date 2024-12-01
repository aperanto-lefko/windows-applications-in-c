namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();
            // Свойству Text панели spData устанавливается текущая дата
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            spWin.Text = "Windows is cascade";
            //System.Windows.Forms.MdiLayout.Cascade: Это значение перечисления MdiLayout,
            //которое указывает, что дочерние формы должны быть расположены в виде каскада.
            //Это означает, что формы будут накладываться друг на друга, и каждая последующая
            //будет смещена на несколько пикселей вниз и вправо от предыдущей.
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            spWin.Text = "Windows is horizontal";
            //Это значение перечисления MdiLayout, которое указывает, что дочерние формы
            //должны быть расположены горизонтально в виде плитки. Это означает, что все
            //открытые дочерние формы будут выровнены по горизонтали, и каждая форма будет
            //занимать всю ширину родительской формы, но высота будет равняться высоте самой формы
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocuments; //К свойству Text дочерней формы добавьте счетчик числа открываемых документов
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)//обработчик события, происходящего при нажатии кнопки на панели инструментов
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm(); // Создаем новый экземпляр дочерней формы
                    newChild.MdiParent = this; // Устанавливаем родительскую форму как текущую MDI-форму
                    newChild.Show();// Показываем дочернюю форму
                    newChild.Text = newChild.Text + " " + ++openDocuments;// Обновляем заголовок формы, добавляя количество открытых документов
                   
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);// Устанавливаем каскадное расположение дочерних форм
                    spWin.Text = "Windows is cascade";
                    break;
                case "Title":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal); // Устанавливаем горизонтальное расположение дочерних форм\
                    spWin.Text = "Windows is horizontal";
                    break;
            }
        }
    }
}
