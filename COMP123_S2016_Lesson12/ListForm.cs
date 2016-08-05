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
            //instantiate an object of the next form - in this case the Final form
            FinalForm finalForm = new FinalForm();
            //pass a reference to the current form (this) to the a public property of the next form
            finalForm.listForm = this;
            //pass some data
            finalForm.ProvinceTextBox.Text = this.ProvinceTextBox.Text; // <-- go to "modifiers" in the properties to enable the final form to be public; VS2013 does not have it. 

            //shows the next form
            finalForm.Show();

            // hides the form 
            this.Hide();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            // select the first item in the list
            ProvinceListBox.SetSelected(0, true);
        }
        private void ProvinceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
