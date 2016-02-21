using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Collections;

/********************************************************************************************
        未使用
*********************************************************************************************/

namespace HOSYU
{
    public partial class Hidden : Form
    {
        static ArrayList ProviderList = new ArrayList();

        public Hidden()
        {
            InitializeComponent();
            cmbAccProvider.Items.AddRange(GetProviderFactoryClasses());
        }

        public static object[] GetProviderFactoryClasses()
        {
            DataTable table = DbProviderFactories.GetFactoryClasses();
            ProviderList.Clear();
            foreach (DataRow row in table.Rows)
            {
                ProviderList.Add(row[0]);
            }
            return ProviderList.ToArray();
        }
    }
}
