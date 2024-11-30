namespace ex_2
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
            groupBox1 = new GroupBox();
            memberList = new CheckedListBox();
            peopleList = new ComboBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSort = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(memberList);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список участников";
            // 
            // memberList
            // 
            memberList.FormattingEnabled = true;
            memberList.Location = new Point(31, 31);
            memberList.Name = "memberList";
            memberList.Size = new Size(120, 94);
            memberList.TabIndex = 0;
            // 
            // peopleList
            // 
            peopleList.FormattingEnabled = true;
            peopleList.Items.AddRange(new object[] { "Иванов Иван Иванович", "Петров Петр Петрович", "Сидоров Сидор Сидорович" });
            peopleList.Location = new Point(12, 222);
            peopleList.Name = "peopleList";
            peopleList.Size = new Size(193, 23);
            peopleList.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(244, 33);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(91, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(244, 88);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(91, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(244, 153);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(91, 23);
            buttonSort.TabIndex = 4;
            buttonSort.Text = "Сортировка";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // button1
            // 
            button1.Location = new Point(232, 222);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 1;
            button1.Text = "Загрузить данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 257);
            Controls.Add(button1);
            Controls.Add(buttonSort);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(peopleList);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Работа со списками";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckedListBox memberList;
        private ComboBox peopleList;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSort;
        private Button button1;
    }
}
