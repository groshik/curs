namespace Curs
{
    partial class GreetingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SerchBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SerchBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.StudentListBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupComboBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 302);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SerchBox
            // 
            this.SerchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SerchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SerchBox.Location = new System.Drawing.Point(0, 21);
            this.SerchBox.Margin = new System.Windows.Forms.Padding(0);
            this.SerchBox.Name = "SerchBox";
            this.SerchBox.Size = new System.Drawing.Size(239, 20);
            this.SerchBox.TabIndex = 3;
            this.SerchBox.Tag = "";
            this.SerchBox.Text = "Поиск...";
            this.SerchBox.Enter += new System.EventHandler(this.SerchBox_Enter);
            this.SerchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerchBox_KeyUp);
            this.SerchBox.Leave += new System.EventHandler(this.SerchBox_Leave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CancelDialogButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.OKButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 268);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(239, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDialogButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelDialogButton.Location = new System.Drawing.Point(119, 0);
            this.CancelDialogButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(120, 34);
            this.CancelDialogButton.TabIndex = 1;
            this.CancelDialogButton.Text = "Отмена";
            this.CancelDialogButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKButton.Location = new System.Drawing.Point(0, 0);
            this.OKButton.Margin = new System.Windows.Forms.Padding(0);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(119, 34);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // StudentListBox
            // 
            this.StudentListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.Location = new System.Drawing.Point(0, 41);
            this.StudentListBox.Margin = new System.Windows.Forms.Padding(0);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.StudentListBox.Size = new System.Drawing.Size(239, 227);
            this.StudentListBox.TabIndex = 1;
            // 
            // groupComboBox
            // 
            this.groupComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(0, 0);
            this.groupComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(239, 21);
            this.groupComboBox.TabIndex = 4;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox_SelectedIndexChanged);
            // 
            // GreetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 302);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GreetingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор студента";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CancelDialogButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.TextBox SerchBox;
        private System.Windows.Forms.ComboBox groupComboBox;
    }
}