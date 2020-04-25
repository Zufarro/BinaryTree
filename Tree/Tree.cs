using System;
using System.Collections.Generic;

namespace Tree
{
    //Класс узла дерева
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        // Корень дерева
        Node root;

        // конструктор
        public BinaryTree(int key)
        {
            root = new Node(key);
        }

        public BinaryTree()
        {
            root = null;
        }

        private Node AddNode(int item, Node node)
        {
            if (node == null)
            {
                node = new Node(item);
                return node;
            }
            else
            {
                if (item > node.key)
                {
                    node.right = AddNode(item, node.right);
                }
                else
                {
                    node.left = AddNode(item, node.left);
                }
                return node;
            }
        }


        // обход дерева в ширину (итерационно, используется очередь)
        private string Across(Node node)
        {
            /*
             Аргументы метода:
               Node node - текущий "элемент дерева"       
            */
            string s = "";
            var queue = new Queue<Node>(); // создать новую очередь
            queue.Enqueue(node); // поместить в очередь первый уровень
            while (queue.Count != 0) // пока очередь не пуста
            {
                //если у текущей ветви есть листья, их тоже добавить в очередь
                if (queue.Peek().left != null)
                { 
                    queue.Enqueue(queue.Peek().left);
                }
                if (queue.Peek().right != null)
                {
                    queue.Enqueue(queue.Peek().right);
                }
                //извлечь из очереди информационное поле последнего элемента
                s += queue.Peek().key.ToString() + " "; // убрать последний элемент очереди
                queue.Dequeue();
            }
            return s;
        }

        private void CLR(Node node, ref string s)
        {
            /*
             Аргументы метода:
             1. Node node - текущий "элемент дерева"       
            */
            if (node != null)
            {
                s += node.key.ToString() + " "; // запомнить текущее значение
                CLR(node.left, ref s); // обойти левое поддерево
                CLR(node.right, ref s); // обойти правое поддерево
            }
        }


        //Обход в ширину
        public void Add(System.Windows.Forms.TextBox tbInput)
        {
            string str = tbInput.Text;
            int item = Int32.Parse(str);
            root = AddNode(item, root);
            tbInput.Clear();
        }

        //Обход в ширину
        public void BFS(System.Windows.Forms.TextBox tbOutput)
        {
            tbOutput.Clear();
            string str = Across(root);
            tbOutput.Text = str;
        }

        //Обход в глубину
        public void DFS(System.Windows.Forms.TextBox tbOutput)
        {
            tbOutput.Clear();
            string s = "";
            CLR(root, ref s);
            tbOutput.Text = s;
        }
        //private string Print(Node node)
        //{
        //    string s = "";
        //    int depth = 0;
        //    var queue = new Queue<Node>();
        //    var queue_depth = new Queue<int>();
        //    queue.Enqueue(node);
        //    queue_depth.Enqueue(depth);

        //    while (queue.Count != 0) 
        //    {
        //        if (queue.Peek().left != null)
        //        {
        //            queue.Enqueue(queue.Peek().left);
        //            queue_depth.Enqueue(depth);
        //        }
        //        if (queue.Peek().right != null)
        //        {
        //            queue.Enqueue(queue.Peek().right);
        //            queue_depth.Enqueue(depth);
        //        }
        //        for (int i = 0; i<depth; i++) 
        //            s+='-';
        //        s += queue.Peek().key.ToString() + Environment.NewLine; 
        //        queue.Dequeue();
        //        depth = queue_depth.Dequeue();
        //        depth++;

        //    }
        //    return s;
        //}

        private void Print(Node node, ref string s, int depth)
        {
            if (node != null)
            {
                for (int i = 0; i < depth; i++)
                    s += '-';
                s += node.key.ToString() + " "+ Environment.NewLine;
                depth++;
                Print(node.left, ref s,depth);
                Print(node.right, ref s,depth); 
            }
        }

        public void Print_DFS(System.Windows.Forms.TextBox tbOutput)
        {
            tbOutput.Clear();
            int depth = 0;
            string str = "";
            Print(root, ref str, depth);
            tbOutput.Text = str;
        }
    }
}


