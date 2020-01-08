namespace Curs
{
    partial class SubjectForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveSubjectsButton = new System.Windows.Forms.Button();
            this.censelSubjectsButton = new System.Windows.Forms.Button();
            this.deleteSubjectButton = new System.Windows.Forms.Button();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subjectGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGridView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.saveSubjectsButton);
            this.panel3.Controls.Add(this.censelSubjectsButton);
            this.panel3.Controls.Add(this.deleteSubjectButton);
            this.panel3.Controls.Add(this.addSubjectButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 28);
            this.panel3.TabIndex = 2;
            // 
            // saveSubjectsButton
            // 
            this.saveSubjectsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveSubjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSubjectsButton.Location = new System.Drawing.Point(584, 0);
            this.saveSubjectsButton.Name = "saveSubjectsButton";
            this.saveSubjectsButton.Size = new System.Drawing.Size(75, 28);
            this.saveSubjectsButton.TabIndex = 3;
            this.saveSubjectsButton.Text = "Сохранить";
            this.saveSubjectsButton.UseVisualStyleBackColor = true;
            this.saveSubjectsButton.Click += new System.EventHandler(this.SaveSubjectsButton_Click);
            this.saveSubjectsButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            // 
            // censelSubjectsButton
            // 
            this.censelSubjectsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.censelSubjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.censelSubjectsButton.Location = new System.Drawing.Point(659, 0);
            this.censelSubjectsButton.Name = "censelSubjectsButton";
            this.censelSubjectsButton.Size = new System.Drawing.Size(75, 28);
            this.censelSubjectsButton.TabIndex = 2;
            this.censelSubjectsButton.Text = "Отменить";
            this.censelSubjectsButton.UseVisualStyleBackColor = true;
            this.censelSubjectsButton.Click += new System.EventHandler(this.CenselSubjectsButton_Click);
            this.censelSubjectsButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            // 
            // deleteSubjectButton
            // 
            this.deleteSubjectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSubjectButton.Location = new System.Drawing.Point(75, 0);
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(75, 28);
            this.deleteSubjectButton.TabIndex = 1;
            this.deleteSubjectButton.Text = "Удалить";
            this.deleteSubjectButton.UseVisualStyleBackColor = true;
            this.deleteSubjectButton.Click += new System.EventHandler(this.DeleteSubjectButton_Click);
            // addSubjectButton
            // 
            this.addSubjectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSubjectButton.Location = new System.Drawing.Point(0, 0);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(75, 28);
            this.addSubjectButton.TabIndex = 0;
            this.addSubjectButton.Text = "Добавить";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            this.addSubjectButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 406);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.subjectGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 332);
            this.panel2.TabIndex = 1;
            // 
            // subjectGridView
            // 
            this.subjectGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.subjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectGridView.Location = new System.Drawing.Point(0, 0);
            this.subjectGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.subjectGridView.Name = "subjectGridView";
            this.subjectGridView.Size = new System.Drawing.Size(740, 332);
            this.subjectGridView.TabIndex = 0;
            this.subjectGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SubjectGridView_ColumnHeaderMouseClick);
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
            this.panel4.TabIndex = 4;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseMove);
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
            label1.Text = "Предметы";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
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
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Curs.Group);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(740, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предметы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubjectForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubjectForm_FormClosed);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveSubjectsButton;
        private System.Windows.Forms.Button censelSubjectsButton;
        private System.Windows.Forms.Button deleteSubjectButton;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView subjectGridView;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
    }
}