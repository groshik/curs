namespace Curs
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ReportCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subjectsButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.ReportCardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.StipendBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateStartPicker = new System.Windows.Forms.DateTimePicker();
            this.DateFinishPicker = new System.Windows.Forms.DateTimePicker();
            this.AssessmentGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.AddGroupStudentsButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ReportCardPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentGrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportCardMenuItem
            // 
            this.ReportCardMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.SaveAsMenuItem});
            this.ReportCardMenuItem.Name = "ReportCardMenuItem";
            this.ReportCardMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ReportCardMenuItem.Text = "Табель";
            // 
            // CreateMenuItem
            // 
            this.CreateMenuItem.Name = "CreateMenuItem";
            this.CreateMenuItem.Size = new System.Drawing.Size(154, 22);
            this.CreateMenuItem.Text = "Создать";
            this.CreateMenuItem.Click += new System.EventHandler(this.CreateMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(154, 22);
            this.OpenMenuItem.Text = "Открыть";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SaveMenuItem.Text = "Сохранить";
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SaveAsMenuItem.Text = "Сохранить как";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportCardMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReportCardPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.subjectsButton);
            this.panel1.Controls.Add(this.groupButton);
            this.panel1.Controls.Add(this.studentsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(161, 327);
            this.panel1.TabIndex = 0;
            // 
            // subjectsButton
            // 
            this.subjectsButton.AutoSize = true;
            this.subjectsButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.subjectsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectsButton.FlatAppearance.BorderSize = 0;
            this.subjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectsButton.Location = new System.Drawing.Point(0, 58);
            this.subjectsButton.Margin = new System.Windows.Forms.Padding(10);
            this.subjectsButton.Name = "subjectsButton";
            this.subjectsButton.Size = new System.Drawing.Size(161, 25);
            this.subjectsButton.TabIndex = 2;
            this.subjectsButton.Text = "Предметы";
            this.subjectsButton.UseVisualStyleBackColor = false;
            this.subjectsButton.Click += new System.EventHandler(this.SubjectsButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.AutoSize = true;
            this.groupButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupButton.FlatAppearance.BorderSize = 0;
            this.groupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupButton.Location = new System.Drawing.Point(0, 35);
            this.groupButton.Margin = new System.Windows.Forms.Padding(10);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(161, 23);
            this.groupButton.TabIndex = 1;
            this.groupButton.Text = "Группы";
            this.groupButton.UseVisualStyleBackColor = false;
            this.groupButton.Click += new System.EventHandler(this.GroupButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.AutoSize = true;
            this.studentsButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.studentsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentsButton.FlatAppearance.BorderSize = 0;
            this.studentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsButton.Location = new System.Drawing.Point(0, 10);
            this.studentsButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(161, 25);
            this.studentsButton.TabIndex = 0;
            this.studentsButton.Text = "Студенты";
            this.studentsButton.UseVisualStyleBackColor = false;
            this.studentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
            // 
            // ReportCardPanel
            // 
            this.ReportCardPanel.ColumnCount = 1;
            this.ReportCardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ReportCardPanel.Controls.Add(this.panel2, 0, 0);
            this.ReportCardPanel.Controls.Add(this.AssessmentGrid, 0, 1);
            this.ReportCardPanel.Controls.Add(this.panel3, 0, 2);
            this.ReportCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportCardPanel.Location = new System.Drawing.Point(164, 3);
            this.ReportCardPanel.Name = "ReportCardPanel";
            this.ReportCardPanel.RowCount = 3;
            this.ReportCardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.ReportCardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ReportCardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.ReportCardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ReportCardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ReportCardPanel.Size = new System.Drawing.Size(581, 321);
            this.ReportCardPanel.TabIndex = 1;
            this.ReportCardPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.StipendBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.DateStartPicker);
            this.panel2.Controls.Add(this.DateFinishPicker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 48);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ставка стипендии";
            // 
            // StipendBox
            // 
            this.StipendBox.Location = new System.Drawing.Point(203, 20);
            this.StipendBox.Name = "StipendBox";
            this.StipendBox.Size = new System.Drawing.Size(100, 20);
            this.StipendBox.TabIndex = 6;
            this.StipendBox.TextChanged += new System.EventHandler(this.StipendBox_TextChanged);
            this.StipendBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Scholarship_KeyDown);
            this.StipendBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Scholarship_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Конец периода";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Начало периода";
            // 
            // DateStartPicker
            // 
            this.DateStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStartPicker.Location = new System.Drawing.Point(3, 20);
            this.DateStartPicker.Name = "DateStartPicker";
            this.DateStartPicker.Size = new System.Drawing.Size(94, 20);
            this.DateStartPicker.TabIndex = 3;
            this.DateStartPicker.Value = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            this.DateStartPicker.ValueChanged += new System.EventHandler(this.DateStartPicker_ValueChanged);
            // 
            // DateFinishPicker
            // 
            this.DateFinishPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinishPicker.Location = new System.Drawing.Point(103, 20);
            this.DateFinishPicker.Name = "DateFinishPicker";
            this.DateFinishPicker.Size = new System.Drawing.Size(94, 20);
            this.DateFinishPicker.TabIndex = 2;
            // 
            // AssessmentGrid
            // 
            this.AssessmentGrid.AllowUserToAddRows = false;
            this.AssessmentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AssessmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssessmentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssessmentGrid.Location = new System.Drawing.Point(3, 57);
            this.AssessmentGrid.Name = "AssessmentGrid";
            this.AssessmentGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssessmentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AssessmentGrid.Size = new System.Drawing.Size(575, 227);
            this.AssessmentGrid.TabIndex = 1;
            this.AssessmentGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssessmentGrid_CellValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddSubjectButton);
            this.panel3.Controls.Add(this.AddGroupStudentsButton);
            this.panel3.Controls.Add(this.AddStudentButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 28);
            this.panel3.TabIndex = 2;
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.AutoSize = true;
            this.AddSubjectButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddSubjectButton.Location = new System.Drawing.Point(462, 0);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(113, 28);
            this.AddSubjectButton.TabIndex = 2;
            this.AddSubjectButton.Text = "Добавить предмет";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // AddGroupStudentsButton
            // 
            this.AddGroupStudentsButton.AutoSize = true;
            this.AddGroupStudentsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddGroupStudentsButton.Location = new System.Drawing.Point(115, 0);
            this.AddGroupStudentsButton.Name = "AddGroupStudentsButton";
            this.AddGroupStudentsButton.Size = new System.Drawing.Size(103, 28);
            this.AddGroupStudentsButton.TabIndex = 1;
            this.AddGroupStudentsButton.Text = "Добавить группу";
            this.AddGroupStudentsButton.UseVisualStyleBackColor = true;
            this.AddGroupStudentsButton.Click += new System.EventHandler(this.AddGroupStudentsButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.AutoSize = true;
            this.AddStudentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddStudentButton.Location = new System.Drawing.Point(0, 0);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(115, 28);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.Text = "Добваить студента";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.groupCollectionBindingSource;
            // 
            // groupCollectionBindingSource
            // 
            this.groupCollectionBindingSource.DataSource = typeof(Curs.GroupCollection);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Curs.Group);
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(748, 351);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система расчёта стипендии";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ReportCardPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource groupCollectionBindingSource;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.ToolStripMenuItem ReportCardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button subjectsButton;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.TableLayoutPanel ReportCardPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DateStartPicker;
        private System.Windows.Forms.DateTimePicker DateFinishPicker;
        private System.Windows.Forms.DataGridView AssessmentGrid;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.Button AddGroupStudentsButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StipendBox;
        private System.Windows.Forms.Label label2;
    }
}

