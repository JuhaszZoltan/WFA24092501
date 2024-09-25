namespace WFA24092501
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnBlueForeColor_Click(object sender, EventArgs e)
        {
            lblText.ForeColor = Color.Blue;
        }

        private void btnWhiteBackColor_Click(object sender, EventArgs e)
        {
            lblText.BackColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblText.Text = string.Empty;
        }

        private void btnMiddleLeft_Click(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void btnMiddleCenter_Click(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnMiddleRight_Click(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnUpperCase_Click(object sender, EventArgs e)
        {
            lblText.Text = lblText.Text.ToUpper();
        }

        private void btnFontSizeGrow_Click(object sender, EventArgs e)
        {
            lblText.Font = new(
                family: lblText.Font.FontFamily,
                emSize: lblText.Font.Size + 2);
        }

        private void btnFontSizeLow_Click(object sender, EventArgs e)
        {
            if (lblText.Font.Size - 2 > 0)
            {
                lblText.Font = new(
                    family: lblText.Font.FontFamily,
                    emSize: lblText.Font.Size - 2);
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            lblText.ForeColor = Color.Black;
            lblText.TextAlign = ContentAlignment.TopLeft;
            lblText.BackColor = Color.Silver;
            lblText.Font = new(lblText.Font.FontFamily, 14);
            lblText.Text = "Helló Világ!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
            //this.Dispose();
        }
    }
}
