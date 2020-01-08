namespace Curs
{
    partial class UserForm
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
            this.saveUsersButton = new System.Windows.Forms.Button();
            this.censelUsersButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
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
            label1.Text = "Пользователи";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.saveUsersButton);
            this.panel3.Controls.Add(this.censelUsersButton);
            this.panel3.Controls.Add(this.deleteUserButton);
            this.panel3.Controls.Add(this.addUserButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 28);
            this.panel3.TabIndex = 2;
            // 
            // saveUsersButton
            // 
            this.saveUsersButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUsersButton.Location = new System.Drawing.Point(584, 0);
            this.saveUsersButton.Name = "saveUsersButton";
            this.saveUsersButton.Size = new System.Drawing.Size(75, 28);
            this.saveUsersButton.TabIndex = 3;
            this.saveUsersButton.Text = "Сохранить";
            this.saveUsersButton.UseVisualStyleBackColor = true;
            this.saveUsersButton.Click += new System.EventHandler(this.SaveUsersButton_Click);
            // 
            // censelUsersButton
            // 
            this.censelUsersButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.censelUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.censelUsersButton.Location = new System.Drawing.Point(659, 0);
            this.censelUsersButton.Name = "censelUsersButton";
            this.censelUsersButton.Size = new System.Drawing.Size(75, 28);
            this.censelUsersButton.TabIndex = 2;
            this.censelUsersButton.Text = "Отменить";
            this.censelUsersButton.UseVisualStyleBackColor = true;
            this.censelUsersButton.Click += new System.EventHandler(this.CenselUsersButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Location = new System.Drawing.Point(75, 0);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(75, 28);
            this.deleteUserButton.TabIndex = 1;
            this.deleteUserButton.Text = "Удалить";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Location = new System.Drawing.Point(0, 0);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 28);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
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
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.panel2.Controls.Add(this.userGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 332);
            this.panel2.TabIndex = 1;
            // 
            // userGridView
            // 
            this.userGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGridView.Location = new System.Drawing.Point(0, 0);
            this.userGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(740, 332);
            this.userGridView.TabIndex = 0;
            this.userGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserGridView_ColumnHeaderMouseClick);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Curs.Group);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(740, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveUsersButton;
        private System.Windows.Forms.Button censelUsersButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.BindingSource groupBindingSource;
    }
}