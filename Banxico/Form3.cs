using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banxico
{
    public partial class Form3 : Form
    {
        string Token;
        public Form3()
        {
            InitializeComponent();
            Token = "0f93540aea22cc07f4a7980bf5a9621fd367932498b7a62fdd0d021318d644dd";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "yyyy/MM/dd";

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "yyyy/MM/dd";

        }
    }
}
