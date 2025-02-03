namespace Kaksi_lomaketta_harjoitus
{
    public partial class Form1 : Form
    {
         string K‰ytt‰tunnusjulius = "";
        string password = "";
      
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            K‰ytt‰tunnusjulius = textK‰ytt‰j‰tunnus.Text;
            password = textSalasana.Text;
            
            if ("admin" == K‰ytt‰tunnusjulius && "password" == password)
            {
                Form lomake2 = new Form2(K‰ytt‰tunnusjulius);
                lomake2.Show();
                this.Hide();
            }
           
           else if ("Julius" == K‰ytt‰tunnusjulius && "Qwerty123" == password)
            {
                Form lomake2 = new Form2(K‰ytt‰tunnusjulius);
                lomake2.Show();
                this.Hide();
            }
            
          else if ("Julle" == K‰ytt‰tunnusjulius && "Salasana" == password)
            {
                Form lomake2 = new Form2(K‰ytt‰tunnusjulius);
                lomake2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("V‰‰r‰ k‰ytt‰j‰tunnus tai salasana");
            }
        }
    }
}