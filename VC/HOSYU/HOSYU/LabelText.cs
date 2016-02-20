using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HOSYU
{
    public partial class LabelTextControl : UserControl
    {
        public LabelTextControl()
        {
            InitializeComponent();
        }
        
        public TextBox TextControl
        {
            get { return this.propTextcontrol; }
        }

        public Label LabelControl
        {
            get { return this.propLabelcontrol; }
        }
    }
}
