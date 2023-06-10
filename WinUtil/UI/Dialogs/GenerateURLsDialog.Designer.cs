namespace WinUtil.UI.Dialogs
{
    partial class GenerateURLsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateURLsDialog));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tB_UrlPrefix = new TextBox();
            label2 = new Label();
            nUD_StartNumber = new NumericUpDown();
            TB_UrlSuffix = new TextBox();
            label3 = new Label();
            nUD_EndNumber = new NumericUpDown();
            label4 = new Label();
            b_OK = new Button();
            b_Cancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_StartNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_EndNumber).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(tB_UrlPrefix, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(nUD_StartNumber, 2, 2);
            tableLayoutPanel1.Controls.Add(TB_UrlSuffix, 2, 4);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(nUD_EndNumber, 2, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(b_OK, 2, 6);
            tableLayoutPanel1.Controls.Add(b_Cancel, 3, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(509, 158);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(104, 27);
            label1.TabIndex = 0;
            label1.Text = "URL prefix:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_UrlPrefix
            // 
            tB_UrlPrefix.Dock = DockStyle.Fill;
            tB_UrlPrefix.Location = new Point(118, 8);
            tB_UrlPrefix.Name = "tB_UrlPrefix";
            tB_UrlPrefix.Size = new Size(305, 21);
            tB_UrlPrefix.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(8, 32);
            label2.Name = "label2";
            label2.Size = new Size(104, 27);
            label2.TabIndex = 1;
            label2.Text = "Start number:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nUD_StartNumber
            // 
            nUD_StartNumber.Location = new Point(118, 35);
            nUD_StartNumber.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nUD_StartNumber.Name = "nUD_StartNumber";
            nUD_StartNumber.Size = new Size(120, 21);
            nUD_StartNumber.TabIndex = 6;
            // 
            // TB_UrlSuffix
            // 
            TB_UrlSuffix.Dock = DockStyle.Fill;
            TB_UrlSuffix.Location = new Point(118, 89);
            TB_UrlSuffix.Name = "TB_UrlSuffix";
            TB_UrlSuffix.Size = new Size(305, 21);
            TB_UrlSuffix.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(8, 59);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 2;
            label3.Text = "End number:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nUD_EndNumber
            // 
            nUD_EndNumber.Location = new Point(118, 62);
            nUD_EndNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nUD_EndNumber.Name = "nUD_EndNumber";
            nUD_EndNumber.Size = new Size(120, 21);
            nUD_EndNumber.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(8, 86);
            label4.Name = "label4";
            label4.Size = new Size(104, 27);
            label4.TabIndex = 3;
            label4.Text = "URL suffix:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // b_OK
            // 
            b_OK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            b_OK.Location = new Point(348, 131);
            b_OK.Name = "b_OK";
            b_OK.Size = new Size(75, 23);
            b_OK.TabIndex = 11;
            b_OK.Text = "OK";
            b_OK.UseVisualStyleBackColor = true;
            b_OK.Click += OK_Click;
            // 
            // b_Cancel
            // 
            b_Cancel.Location = new Point(429, 131);
            b_Cancel.Name = "b_Cancel";
            b_Cancel.Size = new Size(75, 23);
            b_Cancel.TabIndex = 12;
            b_Cancel.Text = "Cancel";
            b_Cancel.UseVisualStyleBackColor = true;
            b_Cancel.Click += Cancel_Click;
            // 
            // GenerateURLsDialog
            // 
            AcceptButton = b_OK;
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_Cancel;
            ClientSize = new Size(509, 158);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GenerateURLsDialog";
            Text = "Generate URLs";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_StartNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_EndNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox tB_UrlPrefix;
        private Label label2;
        private NumericUpDown nUD_StartNumber;
        private TextBox TB_UrlSuffix;
        private Label label3;
        private NumericUpDown nUD_EndNumber;
        private Label label4;
        private Button b_OK;
        private Button b_Cancel;
    }
}