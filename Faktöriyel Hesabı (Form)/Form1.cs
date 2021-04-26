using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextBox txt1 = new TextBox();
        Label lbl1 = new Label();

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Height = 25;
            btn.Width = 80;
            btn.Top = 60;
            btn.Left = 80;
            btn.Text = ("Yazdir");
            this.Controls.Add(btn);

            btn.Click += new EventHandler(btn_click);
            
            Button btn_2 = new Button();
            btn_2.Height = 25;
            btn_2.Width = 80;
            btn_2.Top = 85;
            btn_2.Left = 80;
            btn_2.Text = ("Faktoriyeli");
            this.Controls.Add(btn_2);
            
            btn_2.Click += new EventHandler(btn_2_click);
            
            txt1.Height = 30;
            txt1.Width = 80;
            txt1.Top = 110;
            txt1.Left = 80;
            this.Controls.Add(txt1);
            
            txt1.KeyPress += txt1_KeyPress;
            lbl1.Height = 20;
            lbl1.Width = 80;
            lbl1.Top = 135;
            lbl1.Left = 80;
            lbl1.Text = "Sonuc : ";
            lbl1.ForeColor = Color.Black;
            this.Controls.Add(lbl1);
        }
        private void btn_click(object sender, EventArgs e)
        {
            MessageBox.Show(txt1.Text);
        }
        private void btn_2_click(object sender, EventArgs e)
        {
            int fakt = 1;
            for (int i = 1; i <= Convert.ToInt32(txt1.Text); i++)
            {
                fakt *= i;
            }
            lbl1.Text = fakt.ToString();
        }
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
