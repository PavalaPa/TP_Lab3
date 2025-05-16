using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Lab3 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Consumer_spending_button_Click(object sender, EventArgs e)
        {
            Consumer_spending_Form consumer_Spending_Form = new Consumer_spending_Form();
            consumer_Spending_Form.Show();
        }
    }
}
