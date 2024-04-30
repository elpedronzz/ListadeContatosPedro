﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListadeContatosPedro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private contato[] listaDeContatos = new contato[1];

        private void Escrever(contato contato)
        {
            StreamWriter escrever = new StreamWriter("Contato.txt");

            escrever.WriteLine(listaDeContatos.Length + 1);
            escrever.WriteLine(contato.Nome);
            escrever.WriteLine(contato.Sobrenome);
            escrever.WriteLine(contato.Telefone);

            for (int x = 0; x < listaDeContatos.Length; x++) 
            {
                escrever.WriteLine(listaDeContatos[x].Nome);
                escrever.WriteLine(listaDeContatos[x].Sobrenome);
                escrever.WriteLine(listaDeContatos[x].Telefone);
            }

            escrever.Close();
        }

        private void Ler ()
        {
            StreamReader ler = new StreamReader("contato.txt");

            listaDeContatos = new contato[Convert.ToInt32(ler.ReadLine())];
        }

        private void buttonIncluirContato_Click(object sender, EventArgs e)
        {
            contato contato = new contato();

            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;

            listBoxContatos.Items.Add(contato);

        }
    }
}
