using ArvoreBináriaCSharp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArvoreBináriaCSharp
{
    public partial class Form1 : Form
    {
        Node arvoreBinaria = new Node();
        public Form1()
        {
            InitializeComponent();
            arvoreBinaria._rmostrador = richTextBoxMostrar;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            MessageBox.Show(arvoreBinaria.inserir(arvoreBinaria.raiz, Convert.ToInt16(numericUpDownItem.Value)));
            richTextBoxMostrar.Clear();
            arvoreBinaria.desenhaArvoreHorizontal(arvoreBinaria.raiz);
        }
        
        private void btnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arvoreBinaria.remover(Convert.ToInt16(numericUpDownItem.Value)));
            richTextBoxMostrar.Clear();
            arvoreBinaria.desenhaArvoreHorizontal(arvoreBinaria.raiz);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arvoreBinaria.pesquisar(Convert.ToInt16(numericUpDownItem.Value),arvoreBinaria.raiz));
        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            arvoreBinaria.ordem(arvoreBinaria.raiz);
        }

        private void btnPosOrdem_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            arvoreBinaria.posordem(arvoreBinaria.raiz);
        }

        private void btnPreOrdem_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            arvoreBinaria.preordem(arvoreBinaria.raiz);
        }

        private void btnLargura_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            arvoreBinaria.desenhaArvoreHorizontal(arvoreBinaria.raiz);
        }
    }
}
