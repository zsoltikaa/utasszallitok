namespace utasszallitokGUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {

            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            btnCalculate.Click += BtnCalculateClick;

        }

        private void BtnCalculateClick(object sender, EventArgs e)
        {
            if (double.TryParse(tbxRamPressure.Text, out double qc) && double.TryParse(tbxStaticPressure.Text, out double p0))
            {
                double machNumber = CalculateMachNumber(qc, p0);
                lbxResult.Items.Add($"qc= {qc} | p0= {p0} | Ma= {machNumber}");
            }
            else
            {
                MessageBox.Show("Nem megfelelo a bemeneti karakterlanc formatuma. ");
            }
        }

        static double CalculateMachNumber(double qc, double p0)
        {
            return Math.Sqrt(5 * (Math.Pow(qc / p0 + 1, 0.2857142857142857) - 1));
        }

    }
}
