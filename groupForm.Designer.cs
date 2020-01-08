namespace Curs
{
    partial class GroupForm
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
            this.saveGroupsButton = new System.Windows.Forms.Button();
            this.censelGroupsButton = new System.Windows.Forms.Button();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupGridView = new System.Windows.Forms.DataGridView();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
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
            label1.Text = "Группы";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.saveGroupsButton);
            this.panel3.Controls.Add(this.censelGroupsButton);
            this.panel3.Controls.Add(this.deleteGroupButton);
            this.panel3.Controls.Add(this.addGroupButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 28);
            this.panel3.TabIndex = 2;
            // 
            // saveGroupsButton
            // 
            this.saveGroupsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveGroupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveGroupsButton.Location = new System.Drawing.Point(584, 0);
            this.saveGroupsButton.Name = "saveGroupsButton";
            this.saveGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.saveGroupsButton.TabIndex = 3;
            this.saveGroupsButton.Text = "Сохранить";
            this.saveGroupsButton.UseVisualStyleBackColor = true;
            this.saveGroupsButton.Click += new System.EventHandler(this.SaveGroupsButton_Click);
            this.saveGroupsButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            // 
            // censelGroupsButton
            // 
            this.censelGroupsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.censelGroupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.censelGroupsButton.Location = new System.Drawing.Point(659, 0);
            this.censelGroupsButton.Name = "censelGroupsButton";
            this.censelGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.censelGroupsButton.TabIndex = 2;
            this.censelGroupsButton.Text = "Отменить";
            this.censelGroupsButton.UseVisualStyleBackColor = true;
            this.censelGroupsButton.Click += new System.EventHandler(this.CenselGroupsButton_Click);
            this.censelGroupsButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGroupButton.Location = new System.Drawing.Point(75, 0);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(75, 28);
            this.deleteGroupButton.TabIndex = 1;
            this.deleteGroupButton.Text = "Удалить";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.DeleteGroupButton_Click);
            this.deleteGroupButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGroupButton.Location = new System.Drawing.Point(0, 0);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(75, 28);
            this.addGroupButton.TabIndex = 0;
            this.addGroupButton.Text = "Добавить";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            this.addGroupButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 406);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.panel4.TabIndex = 5;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseMove);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.groupGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 332);
            this.panel2.TabIndex = 1;
            // 
            // groupGridView
            // 
            this.groupGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGridView.Location = new System.Drawing.Point(0, 0);
            this.groupGridView.Name = "groupGridView";
            this.groupGridView.Size = new System.Drawing.Size(740, 332);
            this.groupGridView.TabIndex = 0;
            this.groupGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GroupGridView_ColumnHeaderMouseClick);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Curs.Group);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(740, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GroupForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupForm_FormClosed);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveGroupsButton;
        private System.Windows.Forms.Button censelGroupsButton;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView groupGridView;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
    }
}