namespace Curs
{
    partial class DialogAddSubject
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
            this.SubjectListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SerchBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubjectListBox
            // 
            this.SubjectListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectListBox.FormattingEnabled = true;
            this.SubjectListBox.Location = new System.Drawing.Point(0, 20);
            this.SubjectListBox.Margin = new System.Windows.Forms.Padding(0);
            this.SubjectListBox.Name = "SubjectListBox";
            this.SubjectListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.SubjectListBox.Size = new System.Drawing.Size(239, 248);
            this.SubjectListBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SubjectListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SerchBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 302);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CancelButton, 1, 0);
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
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButton.Location = new System.Drawing.Point(119, 0);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 34);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
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
            // SerchBox
            // 
            this.SerchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SerchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SerchBox.Location = new System.Drawing.Point(0, 0);
            this.SerchBox.Margin = new System.Windows.Forms.Padding(0);
            this.SerchBox.Name = "SerchBox";
            this.SerchBox.Size = new System.Drawing.Size(239, 20);
            this.SerchBox.TabIndex = 2;
            this.SerchBox.Tag = "";
            this.SerchBox.Text = "Поиск...";
            this.SerchBox.Enter += new System.EventHandler(this.SerchBox_Enter);
            this.SerchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerchBox_KeyUp);
            this.SerchBox.Leave += new System.EventHandler(this.SerchBox_Leave);
            // 
            // DialogAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 302);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogAddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор предмета";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SubjectListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox SerchBox;
    }
}