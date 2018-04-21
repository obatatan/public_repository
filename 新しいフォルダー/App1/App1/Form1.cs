using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            btnCalc.Click += ((s, e) => {
                var calc = new WindowsFormsApplication1.Form1();
                calc.TopLevel = false;
                //this.Controls.Add(calc);
                this.pnlMain.Controls.Add(calc);
                calc.Show();
                calc.BringToFront();
            });
        }

        //private void btnCalc_Click (object sender, EventArgs e) {
        //    var calc = new WindowsFormsApplication1.Form1();
        //    calc.TopLevel = false;
        //    //this.Controls.Add(calc);
        //    this.pnlMain.Controls.Add(calc);
        //    calc.Show();
        //    calc.BringToFront();
        //}
    }
}
