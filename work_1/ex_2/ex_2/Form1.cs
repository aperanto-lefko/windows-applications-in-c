namespace ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //создается новый объект GraphicsPath, который будет использоваться для определения графической фигуры
            //GraphicsPath позволяет создавать сложные формы путем добавления различных примитивов, таких как линии,
            //прямоугольники, эллипсы и многоугольники.
            System.Drawing.Drawing2D.GraphicsPath myPath =
            new System.Drawing.Drawing2D.GraphicsPath();

            //В этом фрагменте к объекту myPath добавляется многоугольник. Многоугольник
            //определяется массивом точек (Point[]), который состоит из трех точек:
            myPath.AddPolygon(new Point[] {

            //верхний левый угол.
            new Point(0, 0),

            //нижний левый угол (по высоте текущего элемента).this.Height возвращает значение высоты элемента управления
            new Point(0, this.Height),

            //верхний правый угол (по ширине текущего элемента).
            new Point(this.Width, 0) });

            //Здесь создается объект Region, который представляет собой область, определенную ранее
            //созданным GraphicsPath. Область может использоваться для определения, какие части графики
            //будут отображаться или обрабатываться (например, для обработки событий мыши).
            Region myRegion = new Region(myPath);

            //В этом последнем шаге область myRegion применяется к текущему элементу управления (this).
            //Это означает, что только область, определенная треугольником, будет отображаться на экране.
            //Все, что находится за пределами этой области, будет скрыто.
            this.Region = myRegion;
        }
    }
}
