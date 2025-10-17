using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Arboles
{
    class TreeNode
    {
        private string _strData;
        private List<TreeNode> _children;

        public string StrData
        {
            get { return _strData; }
            set { _strData = value; }
        }

        public IReadOnlyList<TreeNode> Children => _children.AsReadOnly();

        public TreeNode(string data)
        {
            _strData = data;
            _children = new List<TreeNode>();
        }

        public void AddChild(TreeNode child)
        {
            _children.Add(child);
        }

        // Print tree hierarchically with indentation
        public void PrintTree(int level = 0)
        {
            Console.WriteLine(new string(' ', level * 2) + _strData);
            foreach (var child in _children)
            {
                child.PrintTree(level + 1);
            }
        }
    }

}
