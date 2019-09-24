using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Project1
{
    public delegate void SelectedMenuEvent(object sender, Project1.Models.MenuItem menuItem);

    public partial class MenuItem : UserControl
    {        
        public event SelectedMenuEvent MenuSelected;
        public event SelectedMenuEvent RemoveFromCart;

        public bool isMenuList;
        public bool IsMenuList
        {
            get { return isMenuList; }
            set { isMenuList = value; }
        }


        public MenuItem()
        {
            InitializeComponent();
        }

        Project1.Models.MenuItem menuItem;

        public MenuItem(Project1.Models.MenuItem menuItem)
        {
            this.menuItem = menuItem;

            InitializeComponent();

            string filename = "http://localhost:11799" + menuItem.ImagePath;
            pictureBox1.Image = GetImageFromPicPath(filename);
            label1.Text = menuItem.Name;
            label2.Text = menuItem.Price.ToString("C");
        }

        public static Image GetImageFromPicPath(string strUrl)
        {
            using (WebResponse wrFileResponse = WebRequest.Create(strUrl).GetResponse())
            using (Stream objWebStream = wrFileResponse.GetResponseStream())
            {
                MemoryStream ms = new MemoryStream();

                objWebStream.CopyTo(ms, 8192);

                return Image.FromStream(ms);
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.LightPink;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isMenuList)
            {
                if (MessageBox.Show("추가하시겠습니까?", "Select", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    this.MenuSelected(sender, this.menuItem);
                }
            }
            else
            {
                if (MessageBox.Show("선택 항목에서 제외하시겠습니까?", "Select", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    this.RemoveFromCart(sender, this.menuItem);
                }
            }
        }
    }
}
