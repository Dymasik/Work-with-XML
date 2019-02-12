namespace XML_LABA
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.NAME = new System.Windows.Forms.CheckBox();
            this.Faculty = new System.Windows.Forms.CheckBox();
            this.FacultyBox = new System.Windows.Forms.ComboBox();
            this.Department = new System.Windows.Forms.CheckBox();
            this.DepartmentBox = new System.Windows.Forms.ComboBox();
            this.Degree = new System.Windows.Forms.CheckBox();
            this.DegreeBox = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.CheckBox();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.Search = new System.Windows.Forms.Button();
            this.ToHTML = new System.Windows.Forms.Button();
            this.openFileXML = new System.Windows.Forms.OpenFileDialog();
            this.openXSL = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(379, 426);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // NameBox
            // 
            this.NameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(533, 29);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 21);
            this.NameBox.TabIndex = 1;
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Location = new System.Drawing.Point(415, 31);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(45, 17);
            this.NAME.TabIndex = 2;
            this.NAME.Text = "ПІП";
            this.NAME.UseVisualStyleBackColor = true;
            // 
            // Faculty
            // 
            this.Faculty.AutoSize = true;
            this.Faculty.Location = new System.Drawing.Point(415, 58);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(82, 17);
            this.Faculty.TabIndex = 4;
            this.Faculty.Text = "Факультет";
            this.Faculty.UseVisualStyleBackColor = true;
            // 
            // FacultyBox
            // 
            this.FacultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyBox.FormattingEnabled = true;
            this.FacultyBox.Location = new System.Drawing.Point(533, 56);
            this.FacultyBox.Name = "FacultyBox";
            this.FacultyBox.Size = new System.Drawing.Size(121, 21);
            this.FacultyBox.TabIndex = 3;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(415, 85);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(71, 17);
            this.Department.TabIndex = 6;
            this.Department.Text = "Кафедра";
            this.Department.UseVisualStyleBackColor = true;
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentBox.FormattingEnabled = true;
            this.DepartmentBox.Location = new System.Drawing.Point(533, 83);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(121, 21);
            this.DepartmentBox.TabIndex = 5;
            // 
            // Degree
            // 
            this.Degree.AutoSize = true;
            this.Degree.Location = new System.Drawing.Point(415, 112);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(114, 17);
            this.Degree.TabIndex = 8;
            this.Degree.Text = "Науковий ступінь";
            this.Degree.UseVisualStyleBackColor = true;
            // 
            // DegreeBox
            // 
            this.DegreeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DegreeBox.FormattingEnabled = true;
            this.DegreeBox.Location = new System.Drawing.Point(533, 110);
            this.DegreeBox.Name = "DegreeBox";
            this.DegreeBox.Size = new System.Drawing.Size(121, 21);
            this.DegreeBox.TabIndex = 7;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(415, 139);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(95, 17);
            this.Status.TabIndex = 10;
            this.Status.Text = "Вчене звання";
            this.Status.UseVisualStyleBackColor = true;
            this.Status.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // StatusBox
            // 
            this.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(533, 137);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(121, 21);
            this.StatusBox.TabIndex = 9;
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(430, 278);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(46, 17);
            this.SAX.TabIndex = 11;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(482, 278);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(50, 17);
            this.LINQ.TabIndex = 12;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(536, 278);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(50, 17);
            this.DOM.TabIndex = 13;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(457, 301);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(104, 87);
            this.Search.TabIndex = 14;
            this.Search.Text = "Пошук";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ToHTML
            // 
            this.ToHTML.Location = new System.Drawing.Point(664, 301);
            this.ToHTML.Name = "ToHTML";
            this.ToHTML.Size = new System.Drawing.Size(104, 87);
            this.ToHTML.TabIndex = 15;
            this.ToHTML.Text = "Створити     HTML";
            this.ToHTML.UseVisualStyleBackColor = true;
            this.ToHTML.Click += new System.EventHandler(this.ToHTML_Click);
            // 
            // openFileXML
            // 
            this.openFileXML.FileName = "openFileDialog1";
            // 
            // openXSL
            // 
            this.openXSL.FileName = "openFileDialog1";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToHTML);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.DegreeBox);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.FacultyBox);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.TextBox);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form";
            this.Text = "XML_LABA";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.CheckBox NAME;
        private System.Windows.Forms.CheckBox Faculty;
        private System.Windows.Forms.ComboBox FacultyBox;
        private System.Windows.Forms.CheckBox Department;
        private System.Windows.Forms.ComboBox DepartmentBox;
        private System.Windows.Forms.CheckBox Degree;
        private System.Windows.Forms.ComboBox DegreeBox;
        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button ToHTML;
        private System.Windows.Forms.OpenFileDialog openFileXML;
        private System.Windows.Forms.OpenFileDialog openXSL;
    }
}

