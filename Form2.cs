using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorting1
{
    public partial class Form2 : Form
    {
        public string spreadsheetId;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            spreadsheetId = textBoxId.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
