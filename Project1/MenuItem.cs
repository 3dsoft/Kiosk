using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class MenuItem : UserControl
    {
        public Image image
        {
            set { pictureBox1.Image = value; }
        }

        public string MenuName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string MenuPrice
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public MenuItem()
        {
            InitializeComponent();
        }
    }
}
