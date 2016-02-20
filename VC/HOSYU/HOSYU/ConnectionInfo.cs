using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HOSYU
{
    public partial class ConInfoForm : Form
    {
        private MainForm propCaller=null;

        public MainForm Caller
        {
            set { propCaller = value; }
        }

        public ConInfoForm()
        {
            InitializeComponent();
            btnConTest.BackColor = Color.LightBlue;
        }

        public string InfoMessage
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        private void btnConTest_Click(object sender, EventArgs e)
        {
            if( propCaller!=null)
            {
                try {
                    propCaller.AccDBReConnect();
                    btnConTest.BackColor = Color.GreenYellow;
                    lblerr.Text = "[ 接続成功 ]";
                }catch(DBIOException ex)
                {
                    btnConTest.BackColor = Color.LightSalmon;
                    lblerr.Text = "[ "+ex.Message + " ]";
                }
            }
        }

        private void lblerr_DoubleClick(object sender, EventArgs e)
        {
            btnConTest.BackColor = Color.LightBlue;
            lblerr.ResetText();
        }
    }

}
