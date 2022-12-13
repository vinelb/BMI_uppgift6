namespace BMI_uppgift6
{
    public partial class Form1 : Form
    {
        List<float> BmiList = new List<float>();
        
        
    
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtWeight.Text = "";
            txtHeight.Text = "";
            txtResults.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Weight;
            float Height;
            float Bmi;

            Height = int.Parse(txtHeight.Text);
            Weight = int.Parse(txtWeight.Text);
            Bmi = Weight / Height / Height * 10000;
            
            if (Bmi < 18.5)
            {
                txtResults.Text = "Your Bmi is: " + Bmi + " You are underweight";
            }

            else if (Bmi > 18.5 && Bmi < 24.9)
            {
                txtResults.Text = "Your Bmi is: " + Bmi + " You have normal weight";
            }

            else if (Bmi > 25)
            {
                txtResults.Text = "Your Bmi is " + Bmi + " You are overweight";
            }

            BmiList.Add(Bmi);
            
            

            
            
        }

        

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}