using System.Xml;
namespace ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0)
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            peopleList.Items.Clear();
            FileStream fStream = new FileStream("..\\..\\..\\XMLData.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            /*
             * FileMode.Open
FileMode: Это перечисление, которое определяет, как будет открываться файл.
Open: Указывает, что файл должен быть открыт. Если файл не существует, будет выброшено исключение. Этот режим позволяет открывать существующий файл для чтения или записи.
 FileAccess.Read
FileAccess: Это перечисление, которое определяет, какие операции разрешены с файлом.
Read: Указывает, что файл будет открыт только для чтения. Это означает, что вы сможете читать данные из файла, но не сможете их изменять или записывать.
FileShare.ReadWrite
FileShare: Это перечисление, которое определяет, как другие потоки могут получить доступ к файлу, когда он уже открыт.
ReadWrite: Указывает, что другие потоки могут читать и записывать в файл, даже когда он открыт в текущем потоке. Это позволяет нескольким процессам или потокам одновременно работать с файлом.
             */

            XmlDocument xmlDoc = new XmlDocument(); 
            xmlDoc.Load(fStream);
            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            }

            /*
             *  строка xmlDoc.DocumentElement.ChildNodes.Count:

Получает корневой элемент XML-документа, представленного переменной xmlDoc.
Извлекает коллекцию дочерних узлов (элементов) этого корневого элемента.
Возвращает количество дочерних узлов, то есть количество элементов, находящихся непосредственно внутри корневого элемента.
             * */
            fStream.Close();
        }
    }
}
