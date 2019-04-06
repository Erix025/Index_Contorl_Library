using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index_Contorl_Library
{
    public partial class IC_NumberChangeBox : UserControl
    {
        public IC_NumberChangeBox()
        {
            InitializeComponent();
            Number = 1;
            txt_Number.Text = Number.ToString();
        }
        public delegate void NumberChangedHandler(object sender, EventArgs e);
        public event NumberChangedHandler NumberChanged;
        public int max;
        public int GetMax()
        {
            return max;
        }

        public void SetMax(int max)
        {
            this.max = max;
            NumberChange();
        }
        public int Number { get; set; }
        protected void But_Reduce_Click(object sender, EventArgs e)
        {
            Number--;
            NumberChange();
        }
        private void NumberChange()
        {
            but_Add.Enabled = true;
            but_Reduce.Enabled = true;
            if (Number >= max)
            {
                but_Add.Enabled = false;
                Number = max;
            }
            if (Number <= 1)
            {
                but_Reduce.Enabled = false;
                Number = 1;
            }
            txt_Number.Text = Number.ToString();
            if (NumberChanged != null)
            {
                NumberChanged(this, new EventArgs());
            }
        }
        protected void But_Add_Click(object sender, EventArgs e)
        {
            Number++;
            NumberChange();
        }
        protected void Txt_Number_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Number = int.Parse(txt_Number.Text);
            }
            catch
            {
                if (txt_Number.Text != "")
                {
                    MessageBox.Show("请输入正确的数字", "错误！");
                }
                else
                {
                    txt_Number.Text = "";
                    Number = 0;
                }
            }
            NumberChange();
        }
    }
}
