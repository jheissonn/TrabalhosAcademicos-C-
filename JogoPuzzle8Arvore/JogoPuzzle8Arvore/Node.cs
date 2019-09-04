using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPuzzle8Arvore
{
    class Node
    {
        public List<Node> children = new List<Node>();
        public Node parent;
        public int[] Objetivo = new int[9];
        public int[] puzzle = new int[9];
        public int x = 0;
        public int col = 3;

        public Node(int[] p, int[] Objetivo)
        {
            SetPuzzle(p, Objetivo); 
        }

        public void SetPuzzle(int[] p, int [] Objetivo)
        {
            for (int i = 0; i < puzzle.Length; i++)
            {
                this.Objetivo[i] = Objetivo[i];
                this.puzzle[i] = p[i];
            }
        }

        public void ExpandNode()
        {
            for (int i = 0; i < puzzle.Length; i++)
            {
                if (puzzle[i] == 0)
                    x = i;

            }
            MoveToRight(puzzle, x);
            MoveToLeft(puzzle, x);
            MoveToUp(puzzle, x);
            MoveToDown(puzzle, x);
        }

        public void MoveToRight(int[] p, int i)
        {
            if (i % col < col - 1)
            {
                int[] pc = new int[9];
                CopyPuzzle(pc, p);
                int temp = pc[i + 1];
                pc[i + 1] = pc[i];
                pc[i] = temp;

                Node child = new Node(pc, this.Objetivo);
                children.Add(child);
                child.parent = this;
            }
        }
        public void MoveToLeft(int[] p, int i)
        {
            if (i % col > 0)
            {
                int[] pc = new int[9];
                CopyPuzzle(pc, p);

                int temp = pc[i - 1];
                pc[i - 1] = pc[i];
                pc[i] = temp;

                Node child = new Node(pc, this.Objetivo);
                children.Add(child);
                child.parent = this;
            }
        }
        public void MoveToUp(int[] p, int i)
        {
            if (i - col >= 0)
            {
                int[] pc = new int[9];
                CopyPuzzle(pc, p);

                int temp = pc[i - 3];
                pc[i - 3] = pc[i];
                pc[i] = temp;

                Node child = new Node(pc, this.Objetivo);
                children.Add(child);
                child.parent = this;
            }
        }
        public void MoveToDown(int[] p, int i)
        {
            if (i + col < puzzle.Length)
            {
                int[] pc = new int[9];
                CopyPuzzle(pc, p);
                int temp = pc[i + 3];
                pc[i + 3] = pc[i];
                pc[i] = temp;
                Node child = new Node(pc, this.Objetivo);
                children.Add(child);
                child.parent = this;
            }
        }
        public void CopyPuzzle(int[] a, int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                a[i] = b[i];
            }
        }

        public bool IsSamePuzzle(int[] p)
        {
            bool samePuzzle = true;
            for (int i = 0; i < p.Length; i++)
            {
                if (puzzle[i] != p[i])
                {
                    samePuzzle = false;
                }
            }
            return samePuzzle;
        }

        public bool GoalTest()
        {
            bool samePuzzle = true;
            for (int i = 0; i < puzzle.Length; i++)
            {
                if (Objetivo[i] != puzzle[i])
                {
                    samePuzzle = false;
                }
            }
            return samePuzzle;
            /*
            bool goal = true;
            int m = puzzle[0];
            for (int i = 1; i < puzzle.Length; i++)
            {
                if (m > puzzle[i])
                {
                    goal = false;
                }
                m = puzzle[i];
            }
            return goal;
            */
        }


    }
}
