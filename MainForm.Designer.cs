using System.Drawing;
using System.Windows.Forms;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ReportCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new Curs.MenuStripAllowsCustomHighlight();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.DeleteSubjectButton = new System.Windows.Forms.Button();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userButton = new System.Windows.Forms.Button();
            this.subjectsButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ReportCardPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.ReportCardMenuItem.ForeColor = System.Drawing.Color.White;
            this.ReportCardMenuItem.Name = "ReportCardMenuItem";
            this.ReportCardMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ReportCardMenuItem.Text = "Файл";
            // 
            // CreateMenuItem
            // 
            this.CreateMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CreateMenuItem.ForeColor = System.Drawing.Color.White;
            this.CreateMenuItem.Name = "CreateMenuItem";
            this.CreateMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CreateMenuItem.Text = "Создать";
            this.CreateMenuItem.Click += new System.EventHandler(this.CreateMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.ForeColor = System.Drawing.Color.White;
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenMenuItem.Text = "Открыть";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Enabled = false;
            this.SaveMenuItem.ForeColor = System.Drawing.Color.White;
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuItem.Text = "Сохранить";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Enabled = false;
            this.SaveAsMenuItem.ForeColor = System.Drawing.Color.White;
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveAsMenuItem.Text = "Сохранить как";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportCardMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "Спарвка";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.71632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.28368F));
            this.tableLayoutPanel1.Controls.Add(this.ReportCardPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ReportCardPanel
            // 
            this.ReportCardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ReportCardPanel.ColumnCount = 1;
            this.ReportCardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ReportCardPanel.Controls.Add(this.panel2, 0, 0);
            this.ReportCardPanel.Controls.Add(this.AssessmentGrid, 0, 1);
            this.ReportCardPanel.Controls.Add(this.panel3, 0, 2);
            this.ReportCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportCardPanel.Location = new System.Drawing.Point(156, 3);
            this.ReportCardPanel.Name = "ReportCardPanel";
            this.ReportCardPanel.RowCount = 3;
            this.ReportCardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.ReportCardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ReportCardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.ReportCardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ReportCardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ReportCardPanel.Size = new System.Drawing.Size(583, 321);
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
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 48);
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
            this.AssessmentGrid.AllowUserToDeleteRows = false;
            this.AssessmentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AssessmentGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AssessmentGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssessmentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AssessmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AssessmentGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.AssessmentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssessmentGrid.GridColor = System.Drawing.Color.DarkGray;
            this.AssessmentGrid.Location = new System.Drawing.Point(3, 57);
            this.AssessmentGrid.Name = "AssessmentGrid";
            this.AssessmentGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssessmentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.AssessmentGrid.Size = new System.Drawing.Size(577, 227);
            this.AssessmentGrid.TabIndex = 1;
            this.AssessmentGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssessmentGrid_CellValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DeleteStudentButton);
            this.panel3.Controls.Add(this.DeleteSubjectButton);
            this.panel3.Controls.Add(this.AddSubjectButton);
            this.panel3.Controls.Add(this.AddStudentButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 28);
            this.panel3.TabIndex = 2;
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.AutoSize = true;
            this.DeleteStudentButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteStudentButton.Location = new System.Drawing.Point(351, 0);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(113, 28);
            this.DeleteStudentButton.TabIndex = 4;
            this.DeleteStudentButton.Text = "Удалить студента";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // DeleteSubjectButton
            // 
            this.DeleteSubjectButton.AutoSize = true;
            this.DeleteSubjectButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSubjectButton.Location = new System.Drawing.Point(464, 0);
            this.DeleteSubjectButton.Name = "DeleteSubjectButton";
            this.DeleteSubjectButton.Size = new System.Drawing.Size(113, 28);
            this.DeleteSubjectButton.TabIndex = 3;
            this.DeleteSubjectButton.TabStop = false;
            this.DeleteSubjectButton.Text = "Удалить предмет";
            this.DeleteSubjectButton.UseVisualStyleBackColor = true;
            this.DeleteSubjectButton.Click += new System.EventHandler(this.DeleteSubjectButton_Click);
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.AutoSize = true;
            this.AddSubjectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSubjectButton.Location = new System.Drawing.Point(117, 0);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(115, 28);
            this.AddSubjectButton.TabIndex = 2;
            this.AddSubjectButton.Text = "Добавить предмет";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.AutoSize = true;
            this.AddStudentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentButton.Location = new System.Drawing.Point(0, 0);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(117, 28);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.Text = "Добваить студента";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.subjectsButton);
            this.panel1.Controls.Add(this.groupButton);
            this.panel1.Controls.Add(this.studentsButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 327);
            this.panel1.TabIndex = 2;
            // 
            // userButton
            // 
            this.userButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.userButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Location = new System.Drawing.Point(0, 93);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(153, 31);
            this.userButton.TabIndex = 14;
            this.userButton.Text = "Пользователи";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // subjectsButton
            // 
            this.subjectsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subjectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.subjectsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectsButton.FlatAppearance.BorderSize = 0;
            this.subjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectsButton.Location = new System.Drawing.Point(0, 62);
            this.subjectsButton.Name = "subjectsButton";
            this.subjectsButton.Size = new System.Drawing.Size(153, 31);
            this.subjectsButton.TabIndex = 12;
            this.subjectsButton.Text = "Предметы";
            this.subjectsButton.UseVisualStyleBackColor = false;
            this.subjectsButton.Click += new System.EventHandler(this.SubjectsButton_Click);
            this.subjectsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuButton_Paint);
            // 
            // groupButton
            // 
            this.groupButton.AutoSize = true;
            this.groupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.groupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupButton.FlatAppearance.BorderSize = 0;
            this.groupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupButton.Location = new System.Drawing.Point(0, 31);
            this.groupButton.Name = "groupButton";
            this.groupButton.Padding = new System.Windows.Forms.Padding(3);
            this.groupButton.Size = new System.Drawing.Size(153, 31);
            this.groupButton.TabIndex = 11;
            this.groupButton.Text = "Группы";
            this.groupButton.UseVisualStyleBackColor = false;
            this.groupButton.Click += new System.EventHandler(this.GroupsButton_Click);
            this.groupButton.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuButton_Paint);
            // 
            // studentsButton
            // 
            this.studentsButton.AutoSize = true;
            this.studentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.studentsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentsButton.FlatAppearance.BorderSize = 0;
            this.studentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsButton.Location = new System.Drawing.Point(0, 0);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Padding = new System.Windows.Forms.Padding(3);
            this.studentsButton.Size = new System.Drawing.Size(153, 31);
            this.studentsButton.TabIndex = 10;
            this.studentsButton.Text = "Студенты";
            this.studentsButton.UseVisualStyleBackColor = false;
            this.studentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
            this.studentsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuButton_Paint);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(0, 296);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(3);
            this.ExitButton.Size = new System.Drawing.Size(153, 31);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файлы табеля|*.hav";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Файлы табеля|*.hav|Все файлы|*.*";
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(742, 351);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(670, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система расчёта стипендии";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ReportCardPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private MenuStripAllowsCustomHighlight menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel ReportCardPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DateStartPicker;
        private System.Windows.Forms.DateTimePicker DateFinishPicker;
        private System.Windows.Forms.DataGridView AssessmentGrid;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StipendBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button DeleteSubjectButton;
        private ToolStripMenuItem CreateMenuItem;
        private ToolStripMenuItem OpenMenuItem;
        private ToolStripMenuItem SaveMenuItem;
        private ToolStripMenuItem SaveAsMenuItem;
        private Panel panel1;
        private Button subjectsButton;
        private Button groupButton;
        private Button studentsButton;
        private Button ExitButton;
        private Button userButton;
        private ToolStripMenuItem HelpToolStripMenuItem;
    }
    public class MyRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Selected)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size - new Size(1,1));
                Brush b = new SolidBrush(Color.FromArgb(33,33,33));     
                e.Graphics.FillRectangle(b, rc);
                Pen p = new Pen(Color.FromArgb(22, 22, 22));
                e.Graphics.DrawLine(p,new Point(0, e.Item.Size.Height - 1), new Point(e.Item.Size.Width, e.Item.Size.Height- 1));
            }
            else
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(Brushes.White, rc);
            }

        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            if (!(e.Item.Selected))
            {
                e.Item.ForeColor = Color.White;
            }
            else
            {
                e.Item.ForeColor = Color.FromArgb(22, 22, 22);
            }
        }
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.ToolStrip.Size);
            Brush b = new SolidBrush(Color.FromArgb(33, 33, 33));
            e.Graphics.FillRectangle(b, rc);
        }

    }
    public class MenuStripAllowsCustomHighlight : MenuStrip
    {
        public MenuStripAllowsCustomHighlight()
        {
            this.Renderer = new MyRenderer();
        }

    }
}

