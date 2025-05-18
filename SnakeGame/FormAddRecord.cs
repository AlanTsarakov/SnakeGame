using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FormAddRecord : Form
    {
        int scores;
        public FormAddRecord(int scores)
        {
            InitializeComponent();
            this.scores = scores;
        }

        private void FormAddRecord_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveRecord_Click(object sender, EventArgs e)
        {
            Player player = new Player(textBoxName.Text, scores);
            FormTop formTop = new FormTop(player);
            formTop.ShowDialog();
            this.Close();
        }
    }
}
