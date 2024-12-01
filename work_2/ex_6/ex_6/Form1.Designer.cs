namespace ex_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Add = new Button();
            View = new Button();
            richTextBox1 = new RichTextBox();
            checkBox_sortedByInvNumb = new CheckBox();
            checkBox_return_on_time = new CheckBox();
            checkBox_availability = new CheckBox();
            numericUpDownDayOfUse = new NumericUpDown();
            numericUpDownInvNumb = new NumericUpDown();
            numericUpDownYear = new NumericUpDown();
            numericUpDownPages = new NumericUpDown();
            textBoxPubl = new TextBox();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDayOfUse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInvNumb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPages).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(654, 411);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Add);
            tabPage1.Controls.Add(View);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(checkBox_sortedByInvNumb);
            tabPage1.Controls.Add(checkBox_return_on_time);
            tabPage1.Controls.Add(checkBox_availability);
            tabPage1.Controls.Add(numericUpDownDayOfUse);
            tabPage1.Controls.Add(numericUpDownInvNumb);
            tabPage1.Controls.Add(numericUpDownYear);
            tabPage1.Controls.Add(numericUpDownPages);
            tabPage1.Controls.Add(textBoxPubl);
            tabPage1.Controls.Add(textBoxTitle);
            tabPage1.Controls.Add(textBoxAuthor);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(646, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Книги";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(24, 342);
            Add.Name = "Add";
            Add.Size = new Size(270, 23);
            Add.TabIndex = 19;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // View
            // 
            View.Location = new Point(417, 339);
            View.Name = "View";
            View.Size = new Size(115, 23);
            View.TabIndex = 18;
            View.Text = "Посмотреть";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(319, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(319, 300);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // checkBox_sortedByInvNumb
            // 
            checkBox_sortedByInvNumb.AutoSize = true;
            checkBox_sortedByInvNumb.Location = new Point(319, 314);
            checkBox_sortedByInvNumb.Name = "checkBox_sortedByInvNumb";
            checkBox_sortedByInvNumb.Size = new Size(242, 19);
            checkBox_sortedByInvNumb.TabIndex = 16;
            checkBox_sortedByInvNumb.Text = "Сортировать по инвентарному номеру";
            checkBox_sortedByInvNumb.UseVisualStyleBackColor = true;
            // 
            // checkBox_return_on_time
            // 
            checkBox_return_on_time.AutoSize = true;
            checkBox_return_on_time.Location = new Point(164, 314);
            checkBox_return_on_time.Name = "checkBox_return_on_time";
            checkBox_return_on_time.Size = new Size(130, 19);
            checkBox_return_on_time.TabIndex = 15;
            checkBox_return_on_time.Text = "Возвращает в срок";
            checkBox_return_on_time.UseVisualStyleBackColor = true;
            // 
            // checkBox_availability
            // 
            checkBox_availability.AutoSize = true;
            checkBox_availability.Location = new Point(39, 312);
            checkBox_availability.Name = "checkBox_availability";
            checkBox_availability.Size = new Size(75, 19);
            checkBox_availability.TabIndex = 14;
            checkBox_availability.Text = "Наличие";
            checkBox_availability.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDayOfUse
            // 
            numericUpDownDayOfUse.Location = new Point(154, 271);
            numericUpDownDayOfUse.Name = "numericUpDownDayOfUse";
            numericUpDownDayOfUse.Size = new Size(147, 23);
            numericUpDownDayOfUse.TabIndex = 13;
            // 
            // numericUpDownInvNumb
            // 
            numericUpDownInvNumb.Location = new Point(154, 227);
            numericUpDownInvNumb.Name = "numericUpDownInvNumb";
            numericUpDownInvNumb.Size = new Size(147, 23);
            numericUpDownInvNumb.TabIndex = 12;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(154, 187);
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(147, 23);
            numericUpDownYear.TabIndex = 11;
            // 
            // numericUpDownPages
            // 
            numericUpDownPages.Location = new Point(154, 147);
            numericUpDownPages.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPages.Name = "numericUpDownPages";
            numericUpDownPages.Size = new Size(147, 23);
            numericUpDownPages.TabIndex = 10;
            // 
            // textBoxPubl
            // 
            textBoxPubl.Location = new Point(154, 107);
            textBoxPubl.Name = "textBoxPubl";
            textBoxPubl.Size = new Size(147, 23);
            textBoxPubl.TabIndex = 9;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(154, 61);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(147, 23);
            textBoxTitle.TabIndex = 8;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(154, 21);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(147, 23);
            textBoxAuthor.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 273);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 6;
            label7.Text = "Срок пользования";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 229);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 5;
            label6.Text = "Инвентарный номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 189);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Год издания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 149);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Страниц";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 110);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Издательство";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 64);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Автор";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(646, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Журналы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 411);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Библиотека";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDayOfUse).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInvNumb).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private CheckBox checkBox_sortedByInvNumb;
        private CheckBox checkBox_return_on_time;
        private CheckBox checkBox_availability;
        private NumericUpDown numericUpDownDayOfUse;
        private NumericUpDown numericUpDownInvNumb;
        private NumericUpDown numericUpDownYear;
        private NumericUpDown numericUpDownPages;
        private TextBox textBoxPubl;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private Button View;
        private RichTextBox richTextBox1;
        private Button Add;
    }
}
