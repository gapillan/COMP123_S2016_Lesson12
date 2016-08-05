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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void ProvinceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProvinceTextBox.Text = ProvinceListBox.SelectedItem.ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
