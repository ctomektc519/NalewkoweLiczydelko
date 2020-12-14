/* CREATED BY: Tomasz Cieślik
 * DATE: 01.12.2020
 * DESCRIPTION: Program do wyliczania alkoholu w Nalewce
 * */

// changelog 14.12.2020 Wprowadzono własny wyjątek do obsługi niezgodności


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

  
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.ApplicationExit+=OnExit;
        }
      
        // przycisk Wyczyść

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "0";
            textBox4.Text = "40";
            textBox3.Text = "0";
            textBox2.Text = "95";
            textBox1.Text = "0";
            label14.Text = "0,00 %";

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        // zamknięcie programu - przycisk Zamknij

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dziękujemy za skorzystanie z programu", "Koniec");
            Application.Exit();
        }
        // zamknięcie programu - menu górne

        private void zamknijToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dziękujemy za skorzystanie z programu", "Koniec");
            Application.Exit();
        }

        // Zamykanie programu krzyzyk
        private void OnExit(Object sender, EventArgs ea)
        {
            MessageBox.Show("Dziękujemy za skorzystanie programu.", "Koniec");
        }

        // Wyliczanie ilości alkoholu w nalewce przycisk Wylicz

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                double xSpiryt = Double.Parse(textBox1.Text);
                double procentspiryt = Double.Parse(textBox2.Text);
                double ywodka = Double.Parse(textBox3.Text);
                double procentwodka = Double.Parse(textBox4.Text);

                double ilnalewki = Double.Parse(textBox5.Text);
                if (ilnalewki <= 0)
                {
                    //Dodano własny wyjątek

                    throw new Wyjatek("Proszę uzupełnić pole: \"Ilość wyprodukowanej nalewki\"");
                 
                    // MessageBox.Show("Proszę uzupełnić pole: \"Ilość wyprodukowanej nalewki\"");
                 
                }
                else
                {
                    double procent = ((xSpiryt * procentspiryt) + (ywodka * procentwodka)) / ilnalewki;

                    if ((procent >= 100) || (procentspiryt >= 100) || (procentwodka >= 100))
                    {
                        throw new Wyjatek("Zbyt duża ilość alkoholu w nalewce - zweryfikuj wprowadzone dane.");
                       
                        //MessageBox.Show("Zbyt duża ilość alkoholu w nalewce - zweryfikuj wprowadzone dane");
                    }
                    else if ((procentspiryt < 0) || (procentwodka < 0) || (xSpiryt < 0) || (ywodka < 0))
                    {
                        throw new Wyjatek("Proszę wprowadzić wartości dodatnie.");
                     
                        // MessageBox.Show("Proszę wprowadzić wartości dodatnie.");
                    }
                    else
                    {
                        String wynik = String.Format("{0:N2}", procent);
                        label14.Text = wynik + " %";

                        MessageBox.Show("Wyprodukowana przez Ciebie Nalewka ma " + wynik.ToUpper() + " % alkoholu.");
                    }
                }
            }
            catch(Wyjatek w)
            {
                MessageBox.Show(w.Message);
            }

            catch (Exception)
            {
                MessageBox.Show("Wprowadzono nieprawidłowe dane, w polach do uzupełnienia należy wprowadzać dodatnie liczby całkowite");
            }
                                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
