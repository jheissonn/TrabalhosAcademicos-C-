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

namespace sudokuProntoFuncionando
{
    public partial class Form1 : Form
    {
        int[,] sudoku ={{0, 7, 0, 0, 0, 0, 0, 2, 0},
                        {2, 0, 0, 0, 0, 0, 0, 0, 3},
                        {3, 0, 5, 2, 0, 6, 9, 0, 8},
                        {0, 9, 0, 0, 2, 0, 0, 1, 0},
                        {0, 0, 0, 0, 4, 0, 0, 0, 0},
                        {0, 8, 0, 0, 1, 0, 0, 3, 0},
                        {1, 0, 7, 4, 0, 5, 6, 0, 2},
                        {8, 0, 0, 0, 0, 0, 0, 0, 1},
                        {0, 6, 0, 0, 0, 0, 0, 9, 0 } };
        object matrizFixa;
        public Form1()
        {
            InitializeComponent();
            proMostrar();
            matrizFixa = sudoku.Clone();   //Salva em uma matriz para pdoer reiniciar o jogo
            
        }

        public void proMostrar()
        {
         //   dataGridSudoku = new DataGridView();
            dataGridSudoku.RowCount = 9;
            dataGridSudoku.ColumnCount = 9;
            for (int y = 0; y <= 8; y++)
            {
                for (int x = 0; x <= 8; x++)
                {
                    if(sudoku[y, x] == 0)
                      dataGridSudoku.Rows[y].Cells[x].Value = "";
                    else
                      dataGridSudoku.Rows[y].Cells[x].Value = sudoku[y, x];
                }
            }
        }

        private Boolean verifica(int linha, int coluna, int numeroValidar)
        {
            if (sudoku[linha, coluna] != 0)
            {
                return false;// valores vazios serão colocados como 0 caso o valor seja diferente de 0 significa que não está vazio
            }
            for (int colTemp = 0; colTemp < 9; colTemp++)
            {
                if (sudoku[linha, colTemp] == numeroValidar)
                {
                    return false;//Verifica se existe já o número na coluna
                }
            }
            for (int linhaTemp = 0; linhaTemp < 9; linhaTemp++)
            {

                if (sudoku[linhaTemp, coluna] == numeroValidar)
                {
                    return false;//Verifica se existe já o número na linha
                }
            }
            int comecoLinha = linha / 3; /*ex: 4/3 = 1*/
            int comecoColuna = coluna / 3;/*para sempre começar no 3 ou no 6 ou no 9*/
            for (int linhaTemp = comecoLinha * 3; linhaTemp < (comecoLinha + 1) * 3; linhaTemp++)
            {
                for (int colunaTemp = comecoColuna * 3; colunaTemp < (comecoColuna + 1) * 3; colunaTemp++)
                {
                    if (sudoku[linhaTemp, colunaTemp] == numeroValidar)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        Boolean PreencheSudoku(int linha, int coluna)
        {
            if (linha < 9 && coluna < 9)
            {
                if (sudoku[linha, coluna] != 0)
                {
                     if (linha + 1 < 9)
                        return PreencheSudoku(linha + 1, coluna);
                    else if(coluna + 1 < 9)
                        return PreencheSudoku(0,coluna +1);
                    else
                        return true;
                }
                else
                {
                    for (int i = 0; i < 9; ++i)
                    {
                        if (verifica(linha, coluna, i + 1))
                        {   /* Se ele entrar neste if significa que o número pode ser inserido na matriz */
                            sudoku[linha, coluna] = i + 1;
                            
                             if (linha + 1 < 9)
                            {   /* Se a linha for de 0 a 8 ele irá tentar a resolução na próxima linha */
                                if (PreencheSudoku(linha + 1, coluna))
                                    return true;
                                else
                                {   /*Caso a resolução do if não dê certo significa que ele precisa pegar o próximo então ele irá zerar a variavel*/
                                    sudoku[linha, coluna] = 0;
                                   
                                }
                            }
                            else if(coluna + 1 < 9)
                            {
                                if (PreencheSudoku( 0, coluna + 1))
                                    return true;
                                else
                                { /*Caso a resolução do if não dê certo significa que ele precisa pegar o próximo então ele irá zerar a variavel*/
                                    /*Passa linha como 0 para voltar do inicio a próxima coluna*/
                                    
                                    sudoku[linha, coluna] = 0;
                                }
                            }
                            else
                                return true;
                        }
                    }
                }
                return false;
            }
            else
                return true;
        }

        private void buttonResolver_Click(object sender, EventArgs e)
        {
            if (PreencheSudoku(0, 0))
                MessageBox.Show("Resolvido com suceso");
            else 
                MessageBox.Show("Sem solução");
            proMostrar();
        }

        private void dataGridSudoku_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 120, 0, 120, 360);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 240, 0, 240, 360);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 105, 360, 105);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 210, 360, 210);
        }

        private void dataGridSudoku_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numero;
                String valor = dataGridSudoku.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (valor.Length > 1)
                {
                    MessageBox.Show("usar apenas caracteres de 1 a 9");
                    dataGridSudoku.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                    return;
                }
                bool resultado = Int32.TryParse(valor, out numero);
                if (Int32.TryParse(valor, out numero))
                {
                    if (numero > 0)
                    {
                        if (verifica(e.RowIndex, e.ColumnIndex, Int32.Parse(dataGridSudoku.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())))
                        {
                            sudoku[e.RowIndex, e.ColumnIndex] = Int32.Parse(dataGridSudoku.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("o caracter '" + dataGridSudoku.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' não pode ser inserido");
                            dataGridSudoku.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("usar apenas caracteres de 1 a 9");
                        dataGridSudoku.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Caracter inválido.");
                    dataGridSudoku.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                }
            }
            catch { }
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogPrincipal.ShowDialog();//abre janela windows padrão
                string caminho = openFileDialogPrincipal.FileName;
                string tente = System.IO.File.ReadAllText(caminho, Encoding.UTF8);//le o arquivo
                tente = tente.Replace("\r\n", "");
                tente = tente.Replace(" ","");
                int contador = 0;
                for (int y = 0; y <= 8; y++)
                {
                    for (int x = 0; x <= 8; x++)
                    {
                        sudoku[y, x] = int.Parse(tente[contador].ToString());
                        contador++;
                    }
                }
                proMostrar();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao importar  matriz desejada.");
            }
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            sudoku = (int[,])matrizFixa;
            matrizFixa = sudoku.Clone();//Salva em uma matriz para pdoer reiniciar o jogo
            proMostrar();
        }
    }
}
