using System.Data;

namespace DiemSinhVien
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUers.Text;
            string pass = txtPass.Text;
            int cb = comboBox1.SelectedIndex;
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass)|| cb == -1)
            {
                MessageBox.Show("Login failed!");
            }
            else if (cb == 0)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else if ( cb == 1)
            {
               
                Form2 form2 = new Form2();
                form2.Show();
            }
            MessageBox.Show("Login successfully!");



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn là:  " + comboBox1.SelectedItem);
            
        }
    }

}