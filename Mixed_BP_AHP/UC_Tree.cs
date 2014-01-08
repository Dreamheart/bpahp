using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mixed_BP_AHP
{
    public partial class UC_Tree : UserControl
    {
        private List<List<TreeNode>> nodes = null;
        Graphics g = null;
        public UC_Tree()
        {
            InitializeComponent();
            
        }

        public void Init(int height)
        {
            this.nodes = new List<List<TreeNode>>();
            for (int i = 0; i < height; i++)
            {
                this.nodes.Add(new List<TreeNode>());
            }
            g = this.CreateGraphics(); 
        }

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="_displayText">节点文字</param>
        public void AddNode(string _displayText,int level)
        {
            if (this.nodes[level] == null)
            {
                this.nodes[level] = new List<TreeNode>();
            }

            Button btn = new Button();
            btn.Text = _displayText;
            btn.Width = 10 * _displayText.Length+40;

            TreeNode newnode = new TreeNode(btn);
            this.nodes[level].Add(newnode);

            this.Controls.Add(btn);
            //btn.Top = this.Height / 2 + 60 * level;
            //btn.Location = new Point(this.Width / 2 - btn.Width / 2, this.Height / 2 + 40 * level);

            

        }

        public void ClearLevel(int level)
        {

            for (int i = level-1; i < this.nodes.Count; i++)
            {
                if (this.nodes[i] == null)
                {
                    continue;
                }
                foreach (TreeNode item in this.nodes[i])
                {
                    this.Controls.Remove(item.Control);
                }
                this.nodes[i] = null;
            }
        }

        public void RefreshGraphic()
        {
            if (this.nodes == null)
            {
                return;
            }
            this.AdjustPostion();
            this.DrawConnectLine();
        }

        public void AdjustPostion()
        {
            int curHeight = 0;
            while (this.nodes.Count > curHeight && this.nodes[curHeight] != null) { curHeight++; }

            Button btn = null;
            int centerLine = this.Width / 2;
            int topLine = this.Height / 2 - (curHeight / 2) * 100;
            for (int tmpLevel = 0; tmpLevel < curHeight; tmpLevel++)
            {
                int tmpNodeCount = this.nodes[tmpLevel].Count;
                int tmpStartX = 0;
                //若本层节点为奇数个
                if (tmpNodeCount == 1)
                {
                    tmpStartX = centerLine - 30;
                }
                else if (tmpNodeCount % 2 == 1)
                {
                    tmpStartX = (int)(centerLine - (tmpNodeCount / 2) * 100-30);
                }
                else
                {
                    tmpStartX = (int)(centerLine - (tmpNodeCount / 2) * 60 - (tmpNodeCount / 2 -1) * 40 - 20);
                }
                for (int tmpSeq = 0; tmpSeq < tmpNodeCount; tmpSeq++)
                {
                    btn = this.nodes[tmpLevel][tmpSeq].Control as Button;
                    btn.Left = tmpStartX + tmpSeq * 100;
                    btn.Top = topLine + tmpLevel * 60;
                }
            }
        }

        public void DrawConnectLine()
        {
            int curHeight = 0;
            while (this.nodes.Count > curHeight && this.nodes[curHeight] != null) { curHeight++; }
            Button btnSource = null;
            Button btnTarget = null;
            g.Clear(this.BackColor);
            for (int tmpLevel = 0; tmpLevel < curHeight - 1; tmpLevel++)
            {
                int curX = 0;
                int curY = 0;
                int nextX = 0;
                int nextY = 0;
                for (int curLevelSeq = 0; curLevelSeq < this.nodes[tmpLevel].Count; curLevelSeq++)
                {
                    btnSource = this.nodes[tmpLevel][curLevelSeq].Control as Button;
                    curX = btnSource.Left + btnSource.Width / 2;
                    curY = btnSource.Top + btnSource.Height / 2;
                    for (int nextLevelSeq = 0; nextLevelSeq < this.nodes[tmpLevel+1].Count; nextLevelSeq++)
                    {
                        btnTarget = this.nodes[tmpLevel+1][nextLevelSeq].Control as Button;
                        nextX = btnTarget.Left + btnTarget.Width / 2;
                        nextY = btnTarget.Top + btnTarget.Height / 2;
                        this.MyDrawLine(curX, curY, nextX, nextY);
                    }
                }
            }
          
        }

        private void MyDrawLine(int curX, int curY, int nextX, int nextY)
        {
            
            Color red = Color.Red;
            Pen blackPen = new Pen(red, 3);
            Point point1 = new Point(curX, curY); 
            Point point2 = new Point(nextX, nextY); 
            g.DrawLine(blackPen, point1, point2); 
            
        }

        public void Test()
        {
            int[] structrue = { 1, 3, 2 };
            int height = structrue.Length;

            this.Init(structrue.Length);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < structrue[i]; j++)
                {
                    this.AddNode(string.Format("{0}-{1}", i + 1, j + 1),i);
                }
            }
            //this.AdjustPostion();
            //this.DrawConnectLine();
        }

        
    }
}
