using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FormTop : Form
    {
        List<string> players = new List<string>();

        public FormTop()
        {
            InitializeComponent();
        }

        public FormTop(Player player)
        {
            InitializeComponent();
            SaveRecordToTxt(player);
            LoadRecord();
            dataGridViewTop.ColumnCount = 2;
            dataGridViewTop.RowCount = players.Count;
            for (int i = 0; i < players.Count; i++)
            {
                string[] str = players[i].Split('/');
                string name = str[0];
                string scores = str[1];
                dataGridViewTop[0, i].Value = name;
                dataGridViewTop[1, i].Value = scores;
            }
        }

        public void SaveRecordToTxt(Player player)
        {
            StreamWriter streamWriter = new StreamWriter("top.data", true);
            streamWriter.WriteLine(player.Name + "/" + player.Scores);
            streamWriter.Close();
           
        }

        public void LoadRecord()
        {
            StreamReader streamReader = new StreamReader("top.data");
            while (!streamReader.EndOfStream)
            {
                players.Add(streamReader.ReadLine());
            }
            streamReader.Close();
        }

        private void FormTop_Load(object sender, EventArgs e)
        {

        }
    }
}
