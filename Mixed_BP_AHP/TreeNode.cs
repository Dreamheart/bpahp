using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mixed_BP_AHP
{
    public class TreeNode
    {
        private Control ctrl = null;
        private List<TreeNode> children = null;

        public TreeNode(Control _ctrl)
        {
            this.ctrl = _ctrl;
        }

        public bool HasChild()
        {
            return this.children != null;
        }

        public TreeNode FirstChild()
        {
            return this.children.First<TreeNode>();
        }

        public TreeNode AddChild(Control _newChild)
        {
            if (this.children == null)
            {
                this.children = new List<TreeNode>();
            }
            TreeNode tmp = new TreeNode(_newChild);
            this.children.Add(tmp);
            return tmp;
        }

        public List<TreeNode> Children {
            get {
                return this.children;
            }
        }

        public Control Control {
            get {
                return this.ctrl;
            }
        }
    }
}
