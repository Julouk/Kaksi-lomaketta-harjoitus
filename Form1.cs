namespace Kaksi_lomaketta_harjoitus
{
    public partial class Form1 : Form
    {
         string Käyttätunnusjulius = "";
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
            Käyttätunnusjulius = textKäyttäjätunnus.Text;
            password = textSalasana.Text;
            
            if ("admin" == Käyttätunnusjulius && "password" == password)
            {
                Form lomake2 = new Form2();
                lomake2.Show();
                this.Hide();
            }
            if ("Julius" == Käyttätunnusjulius && "Qwerty123" == password)
            {
                Form lomake2 = new Form2();
                lomake2.Show();
                this.Hide();
            }
            if ("Julle" == Käyttätunnusjulius && "Salasana" == password)
            {
                Form lomake2 = new Form2();
                lomake2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Väärä käyttäjätunnus tai salasana");
            }
        }
    }
}