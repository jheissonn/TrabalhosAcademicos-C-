using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritimoDeOrdenacao
{
    public partial class Form1 : Form
    {
        Thread _rOrdenacao;

        public Form1()
        {
            InitializeComponent();
        }

        private Boolean Validar() {
            if (checkBoxBubble.Checked)
                return true;
            if (checkBoxSelection.Checked)
                return true;
            if (checkBoxInsertion.Checked)
                return true;
            if (checkBoxQuick.Checked) 
                return true;
            if (checkBoxCocktail.Checked)
                return true;
            return false;
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            /* método de validação */
            if (!Validar()) {
                MessageBox.Show("Selecione pelo menos um método de ordenação.");
                return;
            }
            /* chama open file dialog para pegar o arquivo a ser varrido. */
            openFileDialog1.ShowDialog();
            FileInfo oFile = new FileInfo(openFileDialog1.FileName);
            if (!oFile.Exists)
                return;
            /* seta os estados do form para não afetar no processo em progresso. */
            progressBarProgresso.Style = ProgressBarStyle.Marquee;
            btnOrdenar.Enabled = false;
            groupBoxMetodos.Enabled = false;

            _rOrdenacao = new Thread(() => Ordenar(oFile.ToString()));
            _rOrdenacao.Start();
        }


        private void Ordenar(String _rPath) {
            /* declaração de variaveis usadas no método de ordenação. */
            Int32[] _uListaBubble = null;
            string[] createText;
            AlgoritimosDeOrdenacao _uMetodosDe = new AlgoritimosDeOrdenacao();
            MethodInvoker metodoInvoker;
            String _rMsgRetorno = string.Empty;
            /* Se houver qualquer problema aoo ler o arquivo será considerado inválido*/
            try
            {
                createText = File.ReadAllLines(_rPath);
            }
            catch (Exception)
            {
                MessageBox.Show("Arquivo inválido.");
                metodoInvoker = new MethodInvoker(() => proAtualizarBtnOrdernar(btnOrdenar, false));
                btnOrdenar.Invoke(metodoInvoker);
                metodoInvoker = new MethodInvoker(() => proAtualizarGroupBox(groupBoxMetodos, false));
                groupBoxMetodos.Invoke(metodoInvoker);
                metodoInvoker = new MethodInvoker(() => proAtualizarProgresso(progressBarProgresso, ProgressBarStyle.Blocks));
                progressBarProgresso.Invoke(metodoInvoker);
                return;
            }

            _uListaBubble = new Int32[createText.Length];
            Int32[] _uListaQuick = new Int32[createText.Length];
            Int32[] _uListaselection = new Int32[createText.Length];
            Int32[] _uListaInsert = new Int32[createText.Length];
            Int32[] _uListaCocktail = new Int32[createText.Length];

            long contador = 0;

            foreach (String _rTemp in createText)
            {
                _uListaBubble[contador] = Convert.ToInt32(_rTemp);
                _uListaQuick[contador] = Convert.ToInt32(_rTemp);
                _uListaInsert[contador] = Convert.ToInt32(_rTemp);
                _uListaselection[contador] = Convert.ToInt32(_rTemp);
                _uListaCocktail[contador] = Convert.ToInt32(_rTemp);
                contador++;
            }
            
            if (checkBoxBubble.Checked) {
                _rMsgRetorno = _uMetodosDe.bubbleSortCmLog(_uListaBubble);
                metodoInvoker = new MethodInvoker(() => atualizarRichTextBox(richTextBoxMostrar, "\n" + _rMsgRetorno));
                richTextBoxMostrar.Invoke(metodoInvoker);
            }
            if (checkBoxQuick.Checked)
            {
                _rMsgRetorno = _rMsgRetorno + _uMetodosDe.quickSortComLog(_uListaQuick);
                metodoInvoker = new MethodInvoker(() => atualizarRichTextBox(richTextBoxMostrar, "\n" + _rMsgRetorno));
                richTextBoxMostrar.Invoke(metodoInvoker);
            }
            if (checkBoxSelection.Checked)
            {
                _rMsgRetorno = _rMsgRetorno +_uMetodosDe.selectionSortCmLog(_uListaselection);
                metodoInvoker = new MethodInvoker(() => atualizarRichTextBox(richTextBoxMostrar, "\n" + _rMsgRetorno));
                richTextBoxMostrar.Invoke(metodoInvoker);
            }
            if (checkBoxInsertion.Checked)
            {
                _rMsgRetorno = _rMsgRetorno + _uMetodosDe.insertionSort(_uListaInsert);
                metodoInvoker = new MethodInvoker(() => atualizarRichTextBox(richTextBoxMostrar, "\n" + _rMsgRetorno));
                richTextBoxMostrar.Invoke(metodoInvoker);
            }
            if (checkBoxCocktail.Checked) {
                _rMsgRetorno = _rMsgRetorno + _uMetodosDe.cocktailSortComLog(_uListaCocktail);
                metodoInvoker = new MethodInvoker(() => atualizarRichTextBox(richTextBoxMostrar, "\n" + _rMsgRetorno));
                richTextBoxMostrar.Invoke(metodoInvoker);
            }

            metodoInvoker = new MethodInvoker(() => proAtualizarBtnOrdernar(btnOrdenar, true));
            btnOrdenar.Invoke(metodoInvoker);
            metodoInvoker = new MethodInvoker(() => proAtualizarGroupBox(groupBoxMetodos, true));
            groupBoxMetodos.Invoke(metodoInvoker);
            metodoInvoker = new MethodInvoker(() => proAtualizarProgresso(progressBarProgresso, ProgressBarStyle.Blocks));
            progressBarProgresso.Invoke(metodoInvoker);
            MessageBox.Show("Ordenado");
        }

        private void proAtualizarGroupBox(GroupBox _rGroup, Boolean _rEstado) {
            _rGroup.Enabled = _rEstado;
        }
        private void proAtualizarBtnOrdernar(Button _rBtn, Boolean _rEstado) {
            _rBtn.Enabled = _rEstado;
        }
        private void proAtualizarProgresso(ProgressBar _rProgressBar, ProgressBarStyle _rEstado) {
            _rProgressBar.Style = _rEstado;
        }
        private void atualizarRichTextBox(RichTextBox _rRichTextBox, String _rTexto) {
            _rRichTextBox.Clear();
            _rRichTextBox.AppendText(_rTexto);
        }

    }
}
