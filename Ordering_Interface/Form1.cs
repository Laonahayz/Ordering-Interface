using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txbName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbName.Text.Trim()) == false) //若名字去掉空白後仍非空字串
                btnOK.Enabled = true; //使產生簡歷按鈕有效化
            else btnOK.Enabled = false;　//使產生簡歷按鈕無效化
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = txbName.Text+"您好，你買了";
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count - 1; i++)
                    richTextBox1.Text += checkedListBox1.CheckedItems[i] +"、";
                richTextBox1.Text += checkedListBox1.CheckedItems[checkedListBox1.CheckedItems.Count - 1] + "，付款為";
            }
            if (rbnCashondelivery.Checked)
                richTextBox1.Text += "貨到付款，產品將於" + dateTimePicker1.Text + "送達，謝謝。";
            else
                richTextBox1.Text += "ATM，產品將於" + dateTimePicker1.Text + "送達，謝謝。";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
        }
    }
}
