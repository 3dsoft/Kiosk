﻿using Project1.Context.Repositories;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeedItem(30);
        }


        #region Left Menu
        private void LblMenu1_MouseHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            lbl.BackColor = Color.DarkRed;
        }

        private void LblMenu1_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.Firebrick;
        }

        /*
         문제점 : 메뉴가 4개가 있는데, 모든 정보를 받아오는건 부담되기 때문에, 메뉴(menuId)로 구분해서 가져와야함.
                  모든 아이템을 받아오는 Get은 사용하지 말것.(테스트용)
                  http://localhost:11799/api/kiosk/menu/1
             */

        private void LblMenu1_Click(object sender, EventArgs e)
        {
            List<Project1.Models.MenuItem> list = new List<Project1.Models.MenuItem>();

            Label label = sender as Label;

            switch(label.Text.ToUpper())
            {
                case "BURGER":
                    list = MenuItemRepository.GetAllMenuItem(0);
                    break;
                case "MCMORNING":
                    list = MenuItemRepository.GetAllMenuItem(1);
                    break;
                case "DRINK":
                    list = MenuItemRepository.GetAllMenuItem(2);
                    break;
                case "SIDE":
                    list = MenuItemRepository.GetAllMenuItem(3);
                    break;
            }

            if(list.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();

                AddItems(list);

                scrollOffset = 0;
            }
        }

        private void AddItems(List<Project1.Models.MenuItem> list)
        {
            Random r = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                Panel pn = new Panel();
                pn.Size = new Size(220, 230);
                MenuItem mi = new MenuItem(list[i]);
                mi.Name = "ml" + list[i].Id.ToString();
                mi.isMenuList = true;
                mi.MenuSelected += Mi_MenuSelected;
                pn.Controls.Add(mi);

                flowLayoutPanel1.Controls.Add(pn);

                flowLayoutPanel1.PerformLayout();

                if (flowLayoutPanel1.Controls.Count / 3 > 1)
                {
                    flowLayoutPanel1.VerticalScroll.Maximum = ((flowLayoutPanel1.Controls.Count / 3) - 1) * 230;
                }
            }
            
            Debug.Print($"### Menu Click : {flowLayoutPanel1.VerticalScroll.Value} / Max ({flowLayoutPanel1.VerticalScroll.Maximum}) / Min ({flowLayoutPanel1.VerticalScroll.Minimum})");
        }

        private void Mi_MenuSelected(object sender, Models.MenuItem mm)
        {
            Panel pn = new Panel();
            pn.Size = new Size(220, 230);
            MenuItem mi = new MenuItem(mm);
            mi.isMenuList = false;
            mi.RemoveFromCart += Mi_RemoveFromCart;
            pn.Name = "cart" + mm.Id.ToString();
            pn.Controls.Add(mi);
            flowLayoutPanel2.Controls.Add(pn);

            flowLayoutPanel2.HorizontalScroll.Value = flowLayoutPanel2.HorizontalScroll.Maximum;

            flowLayoutPanel1.PerformLayout();
        }

        private void Mi_RemoveFromCart(object sender, Models.MenuItem menuItem)
        {
            //flowLayoutPanel2.Controls.Remove(((MenuItem)flowLayoutPanel2.Controls["cart" + menuItem.Id.ToString()]));

            Control selectedControl = new Control();
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if(control.Name == "cart" + menuItem.Id.ToString())
                {
                    selectedControl = control;
                    break;
                }
            }

            if(selectedControl != null && selectedControl.Name == "cart" + menuItem.Id.ToString())
            {
                flowLayoutPanel2.Controls.Remove(selectedControl);
            }
        }




        #endregion



        int scrollOffset = 0;

        private void BtnMenuUp_Click(object sender, EventArgs e)
        {
            int scrollDistance = 236;

            Button btn = sender as Button;

            if (btn.Name.IndexOf("Down") > -1)
            {
                scrollOffset += scrollDistance;

                if (scrollOffset > flowLayoutPanel1.VerticalScroll.Maximum) scrollOffset = flowLayoutPanel1.VerticalScroll.Maximum;

                flowLayoutPanel1.VerticalScroll.Value = scrollOffset;

                flowLayoutPanel1.PerformLayout();

                Debug.Print($"### Scroll Down : {flowLayoutPanel1.VerticalScroll.Value}, scrollOffset : {scrollOffset}");
            }
            else
            {
                scrollOffset -= scrollDistance;

                if (scrollOffset - scrollDistance < 0) scrollOffset = 1;

                flowLayoutPanel1.VerticalScroll.Value = scrollOffset;

                flowLayoutPanel1.PerformLayout();

                Debug.Print($"### Scroll Up : {flowLayoutPanel1.VerticalScroll.Value}, scrollOffset : {scrollOffset}");
            }
        }

      


        #region TEST Function
        private void SeedItem(int count)
        {
            //Random r = new Random();

            //for (int i = 0; i < count; i++)
            //{
            //    Panel pn = new Panel();
            //    pn.Size = new Size(220, 230);
            //    MenuItem mi = new MenuItem();
            //    mi.Location = new Point(0, 0);
            //    mi.image = Image.FromFile($"./Images/burger{r.Next(1, 13)}.png");
            //    mi.MenuName = "Name " + i.ToString("000");
            //    mi.MenuPrice = r.Next(1000, 10000).ToString("C");
            //    pn.Controls.Add(mi);

            //    flowLayoutPanel1.Controls.Add(pn);

            //    flowLayoutPanel1.PerformLayout();

            //    if (flowLayoutPanel1.Controls.Count / 3 > 1)
            //    {
            //        flowLayoutPanel1.VerticalScroll.Maximum = ((flowLayoutPanel1.Controls.Count / 3) - 1) * 230;
            //    }
            //}

            Debug.Print($"### Menu Click : {flowLayoutPanel1.VerticalScroll.Value} / Max ({flowLayoutPanel1.VerticalScroll.Maximum}) / Min ({flowLayoutPanel1.VerticalScroll.Minimum})");
        }
        #endregion

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel1.Focus();
        }
    }
}
