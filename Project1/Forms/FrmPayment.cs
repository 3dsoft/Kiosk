using Project1.Context.Repositories;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1.Forms
{
    public partial class FrmPayment : Form
    {
        Receipt receipt;

        public FrmPayment()
        {
            InitializeComponent();

            receipt = Receipt.GetReceipt();
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Project1.Models.MenuItem item in receipt.GetReceipts())
            {
                ListViewItem lvi = new ListViewItem((i++).ToString());
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add("1");
                lvi.SubItems.Add(item.Price.ToString());

                listView1.Items.Add(lvi);
            }

            lblTotal.Text = receipt.GetTotalPrice().ToString("C");
        }

        private void BtnCash_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment()
            {
                dateTime = DateTime.Now,
                paymentType = "CASH",
                totalPrice = receipt.GetTotalPrice(),
                menuItems =  receipt.GetReceipts()
            };

            ReceiptRepository.SendPayment(pay);

            DialogResult = DialogResult.OK;
        }

        private void BtnCard_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment()
            {
                dateTime = DateTime.Now,
                paymentType = "CASH",
                totalPrice = receipt.GetTotalPrice(),
                menuItems = receipt.GetReceipts()
            };

            ReceiptRepository.SendPayment(pay);

            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
