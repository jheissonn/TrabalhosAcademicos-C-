using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoDeOrdenacao
{


    public class AlgoritimosDeOrdenacao
    {

        public String bubbleSortCmLog(int[] vetor) {
            String retorno = string.Empty;
            int tamanho = vetor.Length;
            long comparacoes = 0;
            long trocas = 0;
            Stopwatch _rStopWatch = new Stopwatch(); 
            _rStopWatch.Start();
            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }
            _rStopWatch.Stop();
            TimeSpan _rtimeSpan = _rStopWatch.Elapsed;
            retorno = "Tempo para ordenação por bubble: " + _rtimeSpan.ToString() + "\n";
            retorno = retorno + "Ocorreram :" + trocas.ToString() + " trocas." + "\n";
            retorno = retorno + "Ocorreram :" + comparacoes.ToString() + " Comparações." + "\n";
            return retorno;
        }

        public String selectionSortCmLog(int[] vetor)
        {
            String _rRetorno = string.Empty;
            Stopwatch _rStopWatch = new Stopwatch();
            int min, aux;
            long comparacoes = 0;
            long trocas = 0;
            _rStopWatch.Start();

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    comparacoes++;
                    if (vetor[j] < vetor[min])
                    {
                        min = j;
                        trocas++;
                    }
                }
                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }

            _rStopWatch.Stop();
            TimeSpan _rtimeSpan = _rStopWatch.Elapsed;
            _rRetorno = "Tempo para ordenação por selection: " + _rtimeSpan.ToString() + "\n";
            _rRetorno = _rRetorno + "Ocorreram :" + trocas.ToString() + " trocas." + "\n";
            _rRetorno = _rRetorno + "Ocorreram :" + comparacoes.ToString() + " Comparações." + "\n";
            return _rRetorno;
        }

        public String insertionSort(int[] vetor)
        {
            int i, j, atual;
            long comparacoes = 0;
            long trocas = 0;
            Stopwatch _rStopWatch = new Stopwatch();
            _rStopWatch.Start();
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                comparacoes++;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                    trocas++;
                }
                vetor[j] = atual;
            }
            _rStopWatch.Stop();
            TimeSpan _rtimeSpan = _rStopWatch.Elapsed;
            String _rRetorno = string.Empty;
            _rRetorno = "Tempo para ordenação por insert: " + _rtimeSpan.ToString() + "\n";
            _rRetorno = _rRetorno + "Ocorreram :" + trocas.ToString() + " trocas." + "\n";
            _rRetorno = _rRetorno + "Ocorreram :" + comparacoes.ToString() + " Comparações." + "\n";
            return _rRetorno;
        }
        

        public static long comparacoesQuick;
        public static long trocasQuick;
        public String quickSortComLog(int[] vetor) {
            Stopwatch _rStopWatch = new Stopwatch();
            _rStopWatch.Start();
            QuickSort_Recursive(vetor, 0, vetor.Length - 1);
            _rStopWatch.Stop();
            TimeSpan _rtimeSpan = _rStopWatch.Elapsed;
            String _rRetorno = string.Empty;
            _rRetorno = "Tempo para ordenação por Quick: " + _rtimeSpan.ToString() + "\n";
            _rRetorno = _rRetorno + "Ocorreram :" + trocasQuick.ToString() + " trocas." + "\n";
            _rRetorno = _rRetorno + "Ocorreram :" + comparacoesQuick.ToString() + " Comparações." + "\n";

            return _rRetorno;
        }
        static public void QuickSort_Recursive(int[] vetor, int primeiro, int ultimo)
        {
            //https://code.msdn.microsoft.com/windowsdesktop/Exemplo-de-mtodo-recursivo-1f51a7d8#content
            int baixo, alto, meio, pivo, repositorio;
            baixo = primeiro;
            alto = ultimo;
            meio = (int)((baixo + alto) / 2);
            /* PEga o pivo */
            pivo = vetor[meio];
            /* */
            while (baixo <= alto)
            {
                while (vetor[baixo] < pivo)
                {
                    comparacoesQuick++;
                    baixo++;
                }
                while (vetor[alto] > pivo)
                {
                    comparacoesQuick++;
                    alto--;
                }
                comparacoesQuick++;
                if (baixo < alto)
                {
                    /* joga de um lado ou para outro */
                    repositorio = vetor[baixo];
                    vetor[baixo++] = vetor[alto];
                    vetor[alto--] = repositorio;
                    trocasQuick++;
                }
                else
                {
                    comparacoesQuick++;
                    if (baixo == alto)
                    {
                        baixo++;
                        alto--;
                    }
                }
            }
            comparacoesQuick++;
            if (alto > primeiro)
                QuickSort_Recursive(vetor, primeiro, alto);
            comparacoesQuick++;
            if (baixo < ultimo)
                QuickSort_Recursive(vetor, baixo, ultimo);
        }
    
    public String cocktailSortComLog(int[] a)
        {
            bool swapped = true;
            int start = 0;
            int end = a.Length;
            long comparacoes, trocas;
            comparacoes = trocas = 0;
            Stopwatch _rStopWatch = new Stopwatch();
            _rStopWatch.Start();

            while (swapped == true)
            {
                // redefinir a bandeira trocada ao entrar no
                // loop,porque pode ser verdadeiro de uma
                // interação anterior 
                swapped = false;

                // loop de baixo para cima o mesmo que
                // tipo de bubble sort 
                for (int i = start; i < end - 1; ++i)
                {
                    comparacoes++;
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        trocas++;
                        swapped = true;
                    }
                }
                // se nada for movido, a matriz será classificada.
                if (swapped == false)
                    break;
                // caso contrário, redefina o sinalizador de troca para que
                // pode ser usado na próxima etapa
                swapped = false;

                //  mover o ponto final de volta por um, porque
                // item no final está em seu devido lugar
                end = end - 1;

                //de cima para baixo, fazendo o
                //  mesma comparação que na etapa anterior
                for (int i = end - 1; i >= start; i--)
                {
                    comparacoes++; 
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        trocas++;
                        swapped = true;
                    }
                }
                // aumentar o ponto de partida, porque
                // o último estágio teria movido o próximo
                // menor número ao seu devido lugar.
                start = start + 1;
            }

            _rStopWatch.Stop();
            TimeSpan _rtimeSpan = _rStopWatch.Elapsed;
            String _rRetorno = string.Empty;
            _rRetorno = "Tempo para ordenação por cocktail: " + _rtimeSpan.ToString() + "\n";
            _rRetorno = _rRetorno + "Ocorreram :" + trocas.ToString() + " trocas." + "\n";
            _rRetorno = _rRetorno + "Ocorreram :" + comparacoes.ToString() + " Comparações." + "\n";
            return _rRetorno;
        }
    }
}
