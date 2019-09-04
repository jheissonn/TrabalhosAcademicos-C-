using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArvoreBináriaCSharp.Classes
{
    class Node
    {
        public int item;
        public RichTextBox _rmostrador = new RichTextBox();
        public Node esquerda;
        public Node direita;
        public Node raiz;
        static readonly int COUNT = 10;

        public Node() { }
        public Node(int item) {
            this.item = item;
        }

        public  void inserir(int item) {
            inserir(raiz, item);
        }
        public Node getRais() {
            return raiz;
        }

        public  String inserir(Node node, int valor) {
            if (node == null)
            {
                this.raiz = new Node(valor);
                return "Inserido item: " + this.raiz.item.ToString() + ".";
            }
            else
            {
                if (valor < node.item)
                {
                    if (node.esquerda != null)
                    {
                        return inserir(node.esquerda, valor);
                    }
                    else
                    {
                        node.esquerda = new Node(valor);
                        return "Inserindo " + valor + " a esquerda de " + node.item;
                    }
                }
                else if (valor > node.item)
                {
                    if (node.direita != null)
                    {
                        return inserir(node.direita, valor);
                    }
                    else
                    {
                        node.direita = new Node(valor);
                        return "Inserindo " + valor + " a direita de " + node.item;
                    }
                }
                else {
                    return "Item ja existente.";
                }
            }
        }
        public  void preordem(Node node)
        {
            if (node != null)
            {
                _rmostrador.AppendText(node.item + ", ");
                preordem(node.esquerda);
                preordem(node.direita);
            }
        }

        public  void posordem(Node node)
        {
            if (node != null)
            {
                posordem(node.esquerda);
                posordem(node.direita);
                _rmostrador.AppendText(node.item + ", ");
            }
        }

        public  void ordem(Node node)
        {
            if (node != null)
            {
                ordem(node.esquerda);
                _rmostrador.AppendText(node.item + ", ");
                ordem(node.direita);
            }
        }

        public String remover(int v)
        {
            if (raiz == null)
              return "Item não encontrado"; // se arvore vazia

            Node atual = raiz;
            Node pai = raiz;
            Boolean filho_esq = true;
            // Busca valor
            while (atual.item != v)
            { 
                pai = atual;
                if (v < atual.item)
                { 
                    atual = atual.esquerda;
                    filho_esq = true; // é filho a esquerda? sim// caminha para a esquerda
                }
                else
                { // caminha para direita
                    atual = atual.direita;
                    filho_esq = false; // é filho a direitta? NAO //procura a direita
                }
                if (atual == null) return "Item não encontrado"; // encontrou uma folha -> sai
            } 

            // atual: contem a referencia ao No a ser eliminado
            // pai: contem a referencia para o pai do No a ser eliminado
            // filho_esq: é verdadeiro se atual é filho a esquerda do pai
            
            // Sem filhos
            if (atual.esquerda == null && atual.direita == null)
            {
                if (atual == raiz)
                  raiz = null; 
                else if (filho_esq)
                  pai.esquerda = null; 
                else
                  pai.direita = null; 
            }
            // QUANDO TEM FILHO A ESQUERDA
            else if (atual.direita == null)
            {
                if (atual == raiz)
                  raiz = atual.esquerda; 
                else if (filho_esq)
                  pai.esquerda = atual.esquerda; 
                else
                  pai.direita = atual.esquerda; 
            }

            // TEM FILHO  ESTÁ A DIREITA
            else if (atual.esquerda == null)
            {
                if (atual == raiz)
                  raiz = atual.direita; 
                else if (filho_esq)
                  pai.esquerda = atual.direita; 
                else
                  pai.direita = atual.direita; 
            }

            // SE POSSUI MAIS DE UM FILHO
            else
            {
                Node sucessor = no_sucessor(atual);
                // USANDO SUCESSOR QUE SERIA O NÓ MAIS A ESQUERDA DA SUBARVORE A DIREITA DO NO QUE DESEJA-SE REMOVER
                if (atual == raiz)
                  raiz = sucessor; 
                else if (filho_esq)
                  pai.esquerda = sucessor; 
                else
                  pai.direita = sucessor; 
                sucessor.esquerda = atual.esquerda; 
            }

            return "Item removido com sucesso.";
        }

        // OBUSCA  O NÓ MAIS A ESQUERDA PARA FAZER A TROCA
        public Node no_sucessor(Node apaga)
        { 
            Node paidosucessor = apaga;
            Node sucessor = apaga;
            Node atual = apaga.direita; 
            //BUSCA O NO A ESQUERDA
            while (atual != null)
            { 
                paidosucessor = sucessor;
                sucessor = atual;
                atual = atual.esquerda; 
            }
            // ACHOU O SUCESSOR
            // PAIDOSUCESSOR SERÁ O O PAI DE SUCESSOR E APAGA O NÓ QUE DEVERÁ SER ELIMINADO
            if (sucessor != apaga.direita)
            { 
                paidosucessor.esquerda = sucessor.direita; 
                // PAI HERDA OS FILHOS DO SUCESSOR QUE SEMPRE SERÃO A DIREITA
                // LEMBRANDO QUE O SUCESSOR NUNCA PODERÁ TER FILHOS A ESQUERDA, POIS, ELE SEMPRE SERÁ O
                // NÓ MAIS A ESQUERDA DA SUBARVORE A DIREITA DO NÓ APAGA.
                // LEMBRANDO TAMBÉM QUE SUCESSOR SEMPRE SERÁ O FILHO A ESQUERDA DO PAI

                sucessor.direita = apaga.direita; 
                // GUARDANDO A REFERENCIA A DIREITA DO SUCESSOR PARA 
                // QUANDO ELE ASSUMIR A POSIÇÃO CORRETA NA ARVORE
            }
            return sucessor;
        }

        public String pesquisar(int k, Node n)
        {
            if (n == null)
            {
                return "Item não encontrado.";
            }
            else if (k < n.item)
            {
                return pesquisar(k, n.esquerda);
            }
            else if (k > n.item)
            {
                return pesquisar(k, n.direita);
            }
            else
            {
                return "Item encontrado. " + n.item.ToString();
            }
        }

        public  void desenharArvore(Node root, int espaco)
        {
            // Caso esteja nulla retorna 
            if (root == null)
                return;
            // Incremente os níveis
            espaco += COUNT;
            // Processa o filho a direita 
            desenharArvore(root.direita, espaco);
            //Imprimir nó atual após dar espaço
            _rmostrador.AppendText("\n");
            for (int i = COUNT; i < espaco; i++)
            {
                _rmostrador.AppendText(" ");
            }
            _rmostrador.AppendText(root.item + "\n");

            // Processar filho a esquerda 
            desenharArvore(root.esquerda, espaco);
        }

        public void desenhaArvoreHorizontal(Node root)
        {
            // Passe a contagem inicial de espaço como 0
            desenharArvore(root, 0);
        }


        public void ImprimirArvoreNormal(Node no)
        {
            _rmostrador.Clear();
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(no);
            while (q.Count != 0)
            {
                _rmostrador.AppendText((no = q.Dequeue() as Node).item.ToString() + ", ");
                if (no.esquerda != null)
                {
                    q.Enqueue(no.esquerda as Node);
                }
                if (no.direita != null)
                {
                    q.Enqueue(no.direita as Node);
                }
            }
        }
    }
}
