﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;

            LayoutMdi(MdiLayout.Cascade);

        }

        private void titleHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;

            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void titleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;

            LayoutMdi(MdiLayout.TileVertical);
        }

        private void calculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild(); 
            Form3 child = new Form3();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;
            LayoutMdi(MdiLayout.ArrangeIcons);

        }

        private void CloseChild()
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }

        }

    }
}
