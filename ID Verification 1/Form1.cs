namespace ID_Verification_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {

            string idNumber = txtIdNumber.Text.Trim();


                if (IsNumeric(idNumber) && idNumber.Length >= 13)
                {
                    MessageBox.Show("The South African ID number is valid and numeric.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The South African ID number is not numeric or does not contain at least 13 digits.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private bool IsNumeric(string input)
            {
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }


    
