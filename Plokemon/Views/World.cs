using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plokemon.Classes;

namespace Plokemon
{
    public partial class World : Form
    {
        public World()
        {
            InitializeComponent();
            WorldSetup();
        }

        #region Class members
        Player player1;
        #endregion

        public void WorldSetup()
        {
            using (var form = new Starter())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<Pokemon> starter = new List<Pokemon>();
                    starter.Add(form.SelectedStarter);
                    player1 = new Player(form.PlayerName, starter);

                    SetStats();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        public void SetStats()
        {
            label1.Text = player1.name;
            label2.Text = player1.hearts.ToString();
        }

        private void basicButton_Click(object sender, EventArgs e)
        {
            Form frm = new Basic();
            frm.Show();
        }

        private void fightButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int poke = rnd.Next(0, 2);

            List<Pokemon> playerParty = new List<Pokemon>();
            if (poke == 0)
            {
                playerParty.Add(new Pikachu("Pikachu"));
            }
            else
            {
                playerParty.Add(new Charmeleon("Charmeleon"));
            }
            Player player2 = new Player("trainer", playerParty);

            using (var form = new Battle(player1, player2))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.victory)
                    {
                        player1.hearts += 2;
                        MessageBox.Show("you've won!  you received a 2 hearts");
                    }
                    else
                    {
                        player1.hearts--;
                        MessageBox.Show("you've lost!  you lost 1 heart");
                    }

                    label2.Text = player1.hearts.ToString();
                }
            }
            SetStats();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            var form = new Shop(player1);
            form.ShowDialog();

            SetStats();
        }

        
    }
}
