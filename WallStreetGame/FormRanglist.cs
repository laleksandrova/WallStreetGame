using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallStreetGame
{
    public partial class FormRanglist : Form
    {
        PlayerManager pm = new PlayerManager();

        public FormRanglist()
        {
            InitializeComponent();
        }

        private void FormRanglist_Load(object sender, EventArgs e)
        {
            using (var db = new PlayerEntities())
            {
                var players = db.Players.OrderByDescending(p => p.Money).Take(10);

                foreach (var player in players)
                {
                    lbHighScoreRanglist.Items.Add($"{player.Username} ---> {player.Money:C2}");
                }
            }
        }
    }
}
