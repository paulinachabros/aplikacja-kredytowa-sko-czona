using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Maximum = 100000;
            trackBar1.Minimum = 1000;
            trackBar2.Maximum = 72;
            trackBar2.Minimum = 12;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxilosc.Text = "" + trackBar1.Value + " zł";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBoxokres.Text = "" + trackBar2.Value + " m-cy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string Format = @"D:\test\{0}_{1}.txt";
            string path = string.Format(Format, textBoxName.Text, textBoxForename.Text);
            
            string tekst = "Dane klienta : \r\n";
            tekst += "Imię : " + textBoxName.Text + " Nazwisko : " + textBoxForename.Text + " \r\n";
            tekst += "Dane Kontaktowe : \r\n";
            tekst += "Telefon : " + textBoxTelefon.Text + " E-Mail : " + textBoxEmail.Text + " \r\n";
            tekst += "Kwota Kredytu : " + textBoxilosc.Text + " Okres Kredytowania : " + textBoxokres.Text + " \r\n";
            tekst += "Godzina Kontaktu : " + comboBox1.Text + " \r\n";
            tekst += "Zgoda na przetwarzanie danych osobowych: " + ((checkBox1.Checked) ? "TAK" : "NIE") +"\r\n";
            tekst += "Zgoda na przetwarzanie danych handlowych: " + ((checkBox2.Checked) ? "TAK" : "NIE") + "\r\n";
            tekst += "Złożono : " + DateTime.Now.ToString("F") + " \r\n";

            if (File.Exists(path))
            {
                string zmiana = "Kwota Kredytu : " + textBoxilosc.Text + " Okres Kredytowania : " + textBoxokres.Text + " \r\n";
                zmiana += "Godzina Kontaktu : " + comboBox1.Text + " \r\n";
                zmiana += "Złożono : " + DateTime.Now.ToString("F") + " \r\n";
                File.AppendAllText(path, zmiana);
            }
            else
            {
                File.WriteAllText(path, tekst);
            }



            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxilosc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxForename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
