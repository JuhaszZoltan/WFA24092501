namespace WFA24092501
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblText = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBlueForeColor = new Button();
            btnWhiteBackColor = new Button();
            btnDelete = new Button();
            btnMiddleRight = new Button();
            btnMiddleCenter = new Button();
            btnMiddleLeft = new Button();
            btnUpperCase = new Button();
            btnFontSizeGrow = new Button();
            btnFontSizeLow = new Button();
            btnExit = new Button();
            btnDefault = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.BackColor = Color.Silver;
            lblText.Location = new Point(12, 9);
            lblText.Name = "lblText";
            lblText.Size = new Size(518, 235);
            lblText.TabIndex = 0;
            lblText.Text = "Helló Világ!";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(btnBlueForeColor, 0, 0);
            tableLayoutPanel1.Controls.Add(btnWhiteBackColor, 1, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel1.Controls.Add(btnMiddleRight, 2, 1);
            tableLayoutPanel1.Controls.Add(btnMiddleCenter, 1, 1);
            tableLayoutPanel1.Controls.Add(btnMiddleLeft, 0, 1);
            tableLayoutPanel1.Controls.Add(btnUpperCase, 0, 2);
            tableLayoutPanel1.Controls.Add(btnFontSizeGrow, 1, 2);
            tableLayoutPanel1.Controls.Add(btnFontSizeLow, 2, 2);
            tableLayoutPanel1.Controls.Add(btnExit, 2, 3);
            tableLayoutPanel1.Controls.Add(btnDefault, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 269);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(518, 215);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnBlueForeColor
            // 
            btnBlueForeColor.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnBlueForeColor.Location = new Point(3, 3);
            btnBlueForeColor.Name = "btnBlueForeColor";
            btnBlueForeColor.Size = new Size(166, 47);
            btnBlueForeColor.TabIndex = 0;
            btnBlueForeColor.Text = "kék betű";
            btnBlueForeColor.UseVisualStyleBackColor = true;
            btnBlueForeColor.Click += btnBlueForeColor_Click;
            // 
            // btnWhiteBackColor
            // 
            btnWhiteBackColor.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnWhiteBackColor.Location = new Point(175, 3);
            btnWhiteBackColor.Name = "btnWhiteBackColor";
            btnWhiteBackColor.Size = new Size(166, 47);
            btnWhiteBackColor.TabIndex = 0;
            btnWhiteBackColor.Text = "fehér háttér";
            btnWhiteBackColor.UseVisualStyleBackColor = true;
            btnWhiteBackColor.Click += btnWhiteBackColor_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDelete.Location = new Point(347, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 47);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "töröl";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMiddleRight
            // 
            btnMiddleRight.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMiddleRight.Location = new Point(347, 56);
            btnMiddleRight.Name = "btnMiddleRight";
            btnMiddleRight.Size = new Size(166, 47);
            btnMiddleRight.TabIndex = 0;
            btnMiddleRight.Text = "jobbközép";
            btnMiddleRight.UseVisualStyleBackColor = true;
            btnMiddleRight.Click += btnMiddleRight_Click;
            // 
            // btnMiddleCenter
            // 
            btnMiddleCenter.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMiddleCenter.Location = new Point(175, 56);
            btnMiddleCenter.Name = "btnMiddleCenter";
            btnMiddleCenter.Size = new Size(166, 47);
            btnMiddleCenter.TabIndex = 0;
            btnMiddleCenter.Text = "közép-közép";
            btnMiddleCenter.UseVisualStyleBackColor = true;
            btnMiddleCenter.Click += btnMiddleCenter_Click;
            // 
            // btnMiddleLeft
            // 
            btnMiddleLeft.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMiddleLeft.Location = new Point(3, 56);
            btnMiddleLeft.Name = "btnMiddleLeft";
            btnMiddleLeft.Size = new Size(166, 47);
            btnMiddleLeft.TabIndex = 0;
            btnMiddleLeft.Text = "balközép";
            btnMiddleLeft.UseVisualStyleBackColor = true;
            btnMiddleLeft.Click += btnMiddleLeft_Click;
            // 
            // btnUpperCase
            // 
            btnUpperCase.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnUpperCase.Location = new Point(3, 109);
            btnUpperCase.Name = "btnUpperCase";
            btnUpperCase.Size = new Size(166, 47);
            btnUpperCase.TabIndex = 0;
            btnUpperCase.Text = "nagybetűs";
            btnUpperCase.UseVisualStyleBackColor = true;
            btnUpperCase.Click += btnUpperCase_Click;
            // 
            // btnFontSizeGrow
            // 
            btnFontSizeGrow.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnFontSizeGrow.Location = new Point(175, 109);
            btnFontSizeGrow.Name = "btnFontSizeGrow";
            btnFontSizeGrow.Size = new Size(166, 47);
            btnFontSizeGrow.TabIndex = 0;
            btnFontSizeGrow.Text = "nagyít";
            btnFontSizeGrow.UseVisualStyleBackColor = true;
            btnFontSizeGrow.Click += btnFontSizeGrow_Click;
            // 
            // btnFontSizeLow
            // 
            btnFontSizeLow.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnFontSizeLow.Location = new Point(347, 109);
            btnFontSizeLow.Name = "btnFontSizeLow";
            btnFontSizeLow.Size = new Size(166, 47);
            btnFontSizeLow.TabIndex = 0;
            btnFontSizeLow.Text = "kicsinyít";
            btnFontSizeLow.UseVisualStyleBackColor = true;
            btnFontSizeLow.Click += btnFontSizeLow_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnExit.Location = new Point(347, 162);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(166, 47);
            btnExit.TabIndex = 0;
            btnExit.Text = "kilép";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDefault
            // 
            btnDefault.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDefault.Location = new Point(3, 162);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(166, 47);
            btnDefault.TabIndex = 0;
            btnDefault.Text = "alaphelyzet";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.Click += btnDefault_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 496);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblText);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "szövegszerkesztő";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblText;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBlueForeColor;
        private Button btnWhiteBackColor;
        private Button btnDelete;
        private Button btnMiddleRight;
        private Button btnMiddleCenter;
        private Button btnMiddleLeft;
        private Button btnUpperCase;
        private Button btnFontSizeGrow;
        private Button btnFontSizeLow;
        private Button btnExit;
        private Button btnDefault;
    }
}
