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
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveGroupsButton = new System.Windows.Forms.Button();
            this.censelGroupsButton = new System.Windows.Forms.Button();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupGridView = new System.Windows.Forms.DataGridView();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.saveGroupsButton);
            this.panel3.Controls.Add(this.censelGroupsButton);
            this.panel3.Controls.Add(this.deleteGroupButton);
            this.panel3.Controls.Add(this.addGroupButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 28);
            this.panel3.TabIndex = 2;
            // 
            // saveGroupsButton
            // 
            this.saveGroupsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveGroupsButton.Location = new System.Drawing.Point(644, 0);
            this.saveGroupsButton.Name = "saveGroupsButton";
            this.saveGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.saveGroupsButton.TabIndex = 3;
            this.saveGroupsButton.Text = "Сохранить";
            this.saveGroupsButton.UseVisualStyleBackColor = true;
            this.saveGroupsButton.Click += new System.EventHandler(this.SaveGroupsButton_Click);
            // 
            // censelGroupsButton
            // 
            this.censelGroupsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.censelGroupsButton.Location = new System.Drawing.Point(719, 0);
            this.censelGroupsButton.Name = "censelGroupsButton";
            this.censelGroupsButton.Size = new System.Drawing.Size(75, 28);
            this.censelGroupsButton.TabIndex = 2;
            this.censelGroupsButton.Text = "Отменить";
            this.censelGroupsButton.UseVisualStyleBackColor = true;
            this.censelGroupsButton.Click += new System.EventHandler(this.CenselGroupsButton_Click);
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteGroupButton.Location = new System.Drawing.Point(75, 0);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(75, 28);
            this.deleteGroupButton.TabIndex = 1;
            this.deleteGroupButton.Text = "Удалить";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.DeleteGroupButton_Click);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addGroupButton.Location = new System.Drawing.Point(0, 0);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(75, 28);
            this.addGroupButton.TabIndex = 0;
            this.addGroupButton.Text = "Добавить";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 410);
            this.panel2.TabIndex = 1;
            // 
            // groupGridView
            // 
            this.groupGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGridView.Location = new System.Drawing.Point(0, 0);
            this.groupGridView.Name = "groupGridView";
            this.groupGridView.Size = new System.Drawing.Size(794, 410);
            this.groupGridView.TabIndex = 0;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(Curs.Group);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GroupForm";
            this.Text = "Группы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GroupForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupForm_FormClosed);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
    }
}