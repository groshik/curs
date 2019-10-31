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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveStudentsButton = new System.Windows.Forms.Button();
            this.censelStudentsButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupComboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.saveStudentsButton);
            this.panel3.Controls.Add(this.censelStudentsButton);
            this.panel3.Controls.Add(this.deleteStudentButton);
            this.panel3.Controls.Add(this.addStudentButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 28);
            this.panel3.TabIndex = 2;
            // 
            // saveStudentsButton
            // 
            this.saveStudentsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveStudentsButton.Location = new System.Drawing.Point(446, 0);
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
            this.censelStudentsButton.Location = new System.Drawing.Point(521, 0);
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
            this.panel2.Location = new System.Drawing.Point(3, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 201);
            this.panel2.TabIndex = 1;
            // 
            // studentGridView
            // 
            this.studentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGridView.Location = new System.Drawing.Point(0, 0);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.Size = new System.Drawing.Size(596, 201);
            this.studentGridView.TabIndex = 0;
            this.studentGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupComboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 21);
            this.panel1.TabIndex = 0;
            // 
            // groupComboBox1
            // 
            this.groupComboBox1.DataSource = this.groupBindingSource;
            this.groupComboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupComboBox1.FormattingEnabled = true;
            this.groupComboBox1.Location = new System.Drawing.Point(451, 0);
            this.groupComboBox1.Name = "groupComboBox1";
            this.groupComboBox1.Size = new System.Drawing.Size(145, 21);
            this.groupComboBox1.TabIndex = 0;
            this.groupComboBox1.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox1_SelectedIndexChanged);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Curs.Group);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Студенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox groupComboBox1;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Button saveStudentsButton;
        private System.Windows.Forms.Button censelStudentsButton;
    }
}