using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adilform
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        public prodotto[] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //funzione visualizza: fa stampare nella lista il nome e prezzo del prodotto
        public void visualizza(prodotto[] pp)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodString(p[i]));
            }

        }
        public string prodString(prodotto p)
        {
            return "Nome: " + p.nome + "  ----  Prezzo: " + p.prezzo.ToString();
        }
        //bottone per far inserire i prodotti e prezzi
        private void button1_Click(object sender, EventArgs e)
        {
            p[dim].nome = nome.Text;
            p[dim].prezzo = float.Parse(prezzo.Text);
            dim++;
            visualizza(p);

        }
        //lista dove visualizzare i prodotti e il prezzo
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //funzione ricerca elemento

        public void Modifica(prodotto[] pp)
        {
            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == nome.Text)
                {
                    p[i].nome = nuovonome.Text;
                    p[i].prezzo = float.Parse(nuovoprezzo.Text);
                }
            }
        }
        //casella inserimento nome da cercare
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //casella inserimento nome prodotto da sostituire
        private void nuovonome_TextChanged(object sender, EventArgs e)
        {

        }
        //casella inserimento prezzo prodotto da sostituire
        private void nuovoprezzo_TextChanged(object sender, EventArgs e)
        {

        }
        //bottone per far aggiornare il nome e il prezzo
        private void button2_Click(object sender, EventArgs e)
        {
            Modifica(p);
            visualizza(p);
        }

        //CALCOLO PREZZO DEI PRODOTTI
        public void Somma(prodotto[] pp)
        {

        }

        //bottone per far stampare la somma
        private void button3_Click(object sender, EventArgs e)
        {
            Somma(p);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        //cancellazione di un prodotto ricercato tramite nome
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

