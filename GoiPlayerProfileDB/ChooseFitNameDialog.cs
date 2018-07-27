using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoiPlayerProfileDB
{
    public partial class ChooseFitNameDialog : Form
    {

        public string SelectedName;
        public IEnumerable<string> Names
        {
            set
            {
                listBox1.Items.AddRange(value.ToArray());
            }
        }

        public ChooseFitNameDialog()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedName = listBox1.SelectedItem as string;
        }
    }
}
