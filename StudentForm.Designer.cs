namespace Curs
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupComboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveStudentsButton = new System.Windows.Forms.Button();
            this.censelStudentsButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.CausesValidation = false;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            label1.Size = new System.Drawing.Size(112, 30);
            label1.TabIndex = 1;
            label1.Text = "Студенты";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.flowLayoutPanel1.Controls.Add(this.groupComboBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 27);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupComboBox1
            // 
            this.groupComboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupComboBox1.FormattingEnabled = true;
            this.groupComboBox1.Location = new System.Drawing.Point(592, 4);
            this.groupComboBox1.Name = "groupComboBox1";
            this.groupComboBox1.Size = new System.Drawing.Size(145, 21);
            this.groupComboBox1.TabIndex = 1;
            this.groupComboBox1.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.saveStudentsButton);
            this.panel3.Controls.Add(this.censelStudentsButton);
            this.panel3.Controls.Add(this.deleteStudentButton);
            this.panel3.Controls.Add(this.addStudentButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 28);
            this.panel3.TabIndex = 2;
            // 
            // saveStudentsButton
            // 
            this.saveStudentsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveStudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveStudentsButton.Location = new System.Drawing.Point(584, 0);
            this.saveStudentsButton.Name = "saveStudentsButton";
            this.saveStudentsButton.Size = new System.Drawing.Size(75, 28);
            this.saveStudentsButton.TabIndex = 3;
            this.saveStudentsButton.Text = "Сохранить";
            this.saveStudentsButton.UseVisualStyleBackColor = true;
            this.saveStudentsButton.Click += new System.EventHandler(this.SaveStudentsButton_Click);
            // 
            // censelStudentsButton
            // 
            this.censelStudentsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.censelStudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.censelStudentsButton.Location = new System.Drawing.Point(659, 0);
            this.censelStudentsButton.Name = "censelStudentsButton";
            this.censelStudentsButton.Size = new System.Drawing.Size(75, 28);
            this.censelStudentsButton.TabIndex = 2;
            this.censelStudentsButton.Text = "Отменить";
            this.censelStudentsButton.UseVisualStyleBackColor = true;
            this.censelStudentsButton.Click += new System.EventHandler(this.CenselStudentsButton_Click);
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStudentButton.Location = new System.Drawing.Point(75, 0);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(75, 28);
            this.deleteStudentButton.TabIndex = 1;
            this.deleteStudentButton.Text = "Удалить";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Location = new System.Drawing.Point(0, 0);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 28);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.Text = "Добавить";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.studentGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 305);
            this.panel2.TabIndex = 1;
            // 
            // studentGridView
            // 
            this.studentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.studentGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGridView.Location = new System.Drawing.Point(0, 0);
            this.studentGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.Size = new System.Drawing.Size(740, 305);
            this.studentGridView.TabIndex = 0;
            this.studentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellContentClick);
            this.studentGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudentGridView_ColumnHeaderMouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(label1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 30);
            this.panel4.TabIndex = 3;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(711, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(740, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StudentForm_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.ComboBox groupComboBox1;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button saveStudentsButton;
        private System.Windows.Forms.Button censelStudentsButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}