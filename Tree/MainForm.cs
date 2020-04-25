using System;
using System.Windows.Forms;

namespace Tree
{
    public partial class MainForm : Form
    {
        BinaryTree tree = new BinaryTree();
        public MainForm()
        {
            InitializeComponent();
            cbTraversal.Items.Add("Обход в глубину");
            cbTraversal.Items.Add("Обход в ширину");
        }

        private void CbTraversal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = (string)cbTraversal.SelectedItem;
            tbOutput.Clear();
            switch (Item)
            {
                case "Обход в глубину":
                    tree.DFS(tbOutput);
                    break;
                case "Обход в ширину":
                    tree.BFS(tbOutput);
                    break;
                default:
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tree.Add(tbInput);
            tree.Print_DFS(tbPrint);
        }
    }
}
