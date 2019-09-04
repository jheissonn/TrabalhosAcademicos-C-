using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPuzzle8Arvore
{
    public partial class Form1 : Form
    {
        int[] puzzle,objetivo;
        public Form1()
        {
            InitializeComponent();
            preparaDtgs();
            puzzle = new int[9];
            objetivo = new int[9];
        }

        private void preparaDtgs() {

            dataGridView1.Rows.Add();
            dataGridView1.Rows.RemoveAt(0);

            DataGridViewRow row = dataGridView1.Rows[0];
            row = dataGridView1.Rows[0];
            row.Height = 45;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows[1];
            row.Height = 45;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows[2];
            row.Height = 45;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows[3];
            row.Height = 45;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView2.Rows.Add();
            dataGridView2.Rows.RemoveAt(0);
            row = dataGridView2.Rows[0];
            row.Height = 45;
            dataGridView2.Rows.Add();
            row = dataGridView2.Rows[1];
            row.Height = 45;
            dataGridView2.Rows.Add();
            row = dataGridView2.Rows[2];
            row.Height = 45;
            dataGridView2.Rows.Add();
            row = dataGridView2.Rows[3];
            row.Height = 45;
            dataGridView2.AllowUserToAddRows = false;

            dataGridView3.Rows.Add();
            dataGridView3.Rows.RemoveAt(0);
            row = dataGridView3.Rows[0];
            row.Height = 45;
            dataGridView3.Rows.Add();
            row = dataGridView3.Rows[1];
            row.Height = 45;
            dataGridView3.Rows.Add();
            row = dataGridView3.Rows[2];
            row.Height = 45;
            dataGridView3.Rows.Add();
            row = dataGridView3.Rows[3];
            row.Height = 45;
            dataGridView3.AllowUserToAddRows = false;
            prepararEstadoInicial();

        }

        private void prepararEstadoInicial() {
            int[] inicial = new int[] {0, 1, 2, 3, 4, 5 ,6,7,8};
            int[] final = new int[] { 1,4,2,6,3,7,8,5,0 };
            int contador = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    dataGridView2.Rows[i].Cells[j].Value = inicial[contador];
                    dataGridView1.Rows[i].Cells[j].Value = final[contador];
                   
                    contador++;
                }

            }


        }
        private Boolean proLerPuzzles() {
            String _rPuzzle = string.Empty;
            String _rObjetivo = string.Empty;
            String mensagem = "Valores inválidos.";
            try
            {
                int contador = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        _rPuzzle = _rPuzzle + dataGridView1.Rows[i].Cells[j].Value;
                        _rObjetivo = _rObjetivo + dataGridView2.Rows[i].Cells[j].Value;
                        puzzle[contador] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
                        objetivo[contador] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                        contador++;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(mensagem);
                return false;
            }
            if (_rPuzzle == string.Empty)
            {
                MessageBox.Show(mensagem);
                return false;
            }
            if (_rObjetivo == string.Empty)
            {
                MessageBox.Show(mensagem);
                return false;
            }
            if (!contains(_rPuzzle))
            {
                MessageBox.Show(mensagem);
                return false;
            }
            if (!contains(_rObjetivo)) {
                MessageBox.Show(mensagem);
                return false;
            }
            return true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!proLerPuzzles())
                return;

            if (!isSolvable(objetivo))
            {
                MessageBox.Show("Puzzle não é solucionável.");
                return;
            }
            label3.Text = "Resolvendo demora mas funciona.";
            Node root = new Node(puzzle, objetivo);
            Solve _rResolverPuzzle = new Solve();
            richTextBoxMostrar.Clear();
            List<Node> solution = _rResolverPuzzle.BreadthFirstSearch(root);

            if (solution.Count > 0)
            {
                solution.Reverse();
                Thread _rSolucionarSeparado = new Thread(() => mostrarPuzzle(solution));
                _rSolucionarSeparado.Start();
            }
            else
            {
                MessageBox.Show("Puzzle não é solucionável.");
                return;
            }
            label3.Text = "Inicie a solução.";
        }

        public bool isSolvable(int[] puzzle)
        {
            int parity = 0;
            int gridWidth = (int)Math.Sqrt(puzzle.Length);
            int row = 0; // Linha atual
            int blankRow = 0; //linha branca

            for (int i = 0; i < puzzle.Length; i++)
            {
                if (i % gridWidth == 0)
                { 
                    row++;
                }
                if (puzzle[i] == 0)
                { 
                    blankRow = row; // salva a linha que encontrou
                    continue;
                }
                for (int j = i + 1; j < puzzle.Length; j++)
                {
                    if (puzzle[i] > puzzle[j] && puzzle[j] != 0)
                    {
                        parity++;
                    }
                }
            }

            if (gridWidth % 2 == 0)
            { 
                if (blankRow % 2 == 0)
                { 
                    return parity % 2 == 0;
                }
                else
                { 
                    return parity % 2 != 0;
                }
            }
            else
            { 
                return parity % 2 == 0;
            }
        }

        private void mostrarPuzzle(List<Node> _rLista) {
            MethodInvoker metodoInvoker;
            for (int p = 0; p < _rLista.Count; p++)
            {
                int m = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (_rLista[p].puzzle[m] == 0)
                        {
                            metodoInvoker = new MethodInvoker(() => proAtualizaDtg(i, j, 11));
                            dataGridView3.Invoke(metodoInvoker);
                            Thread.Sleep(500);
                        }
                        metodoInvoker = new MethodInvoker(() => proAtualizaDtg(i, j, _rLista[p].puzzle[m]));
                        dataGridView3.Invoke(metodoInvoker);
                        metodoInvoker = new MethodInvoker(() => proAtualizarRichTexbox(_rLista[p].puzzle[m].ToString() + " "));
                        richTextBoxMostrar.Invoke(metodoInvoker);
                        m++;
                    }
                    metodoInvoker = new MethodInvoker(() => proAtualizarRichTexbox("\n"));
                    richTextBoxMostrar.Invoke(metodoInvoker);
                }
                metodoInvoker = new MethodInvoker(() => proAtualizarRichTexbox("\n"));
                richTextBoxMostrar.Invoke(metodoInvoker);
            }
        }
        private void proAtualizarRichTexbox(String texto) {
            richTextBoxMostrar.AppendText(texto);
        }

        private Boolean contains(String _rtexto) {
            int contador = 0;
            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 9; j++) {
                    if (_rtexto[i] == _rtexto[j])
                        contador++;
                    if (contador == 2) {
                        return false;
                    }
                }
                contador = 0;
            }
            return true;
        }

        private void proAtualizaDtg(int i, int j, int valor) {
            if (valor == 11)
                dataGridView3.CurrentCell = dataGridView3.Rows[i].Cells[j];
            else {
                dataGridView3.Rows[i].Cells[j].Value = valor;  
            }
        }
    }
}
