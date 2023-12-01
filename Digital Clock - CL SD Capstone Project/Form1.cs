namespace Digital_Clock___CL_SD_Capstone_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}