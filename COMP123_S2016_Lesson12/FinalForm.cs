using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Lesson12
{
    public partial class FinalForm : Form
    {
        public ListForm listForm { get; set; }
        public FinalForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.listForm.Show();
                this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate an object of the AboutBox type
            AboutBox aboutBox = new AboutBox();

            // show dialog 
            aboutBox.ShowDialog();



        }
    }
}
