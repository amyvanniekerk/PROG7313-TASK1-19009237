using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTask1
{
    public partial class ReplaceBook : Form
    {
        List<CallNumbers> numList = new List<CallNumbers>();
        public ReplaceBook()
        {
            InitializeComponent();
        }

        private void ReplaceBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progBar.PerformStep();

            var generator = new CallNumClass();
            var randomNumber = generator.RanCallNum();
            var deciNumber = generator.RandomNumbersCalled(0, 999);

            for ( int i = 0; i<10; i++)
            {
                var vargenerator = generator.RanCallNum();
               // MessageBox.Show($"The random string of chars is : { vargenerator}");
                numList.Add(vargenerator);
                lvBooks.Items.Add(vargenerator.ToString());
                
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home();
            form.Show();
        }

        private void lvAscBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < lvBooks.SelectedItems.Count; i++)
            {
                lvAscBooks.Items.Add((ListViewItem)lvBooks.SelectedItems[i].Clone());
                    lvBooks.Items.RemoveAt(i);
            }
        }
    }
}
