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
    public partial class Switch : Form
    {
        public Switch(Player _player)
        {
            InitializeComponent();
            player = _player;
            SetPokemons();
        }

        #region Class members
        Player player;
        #endregion

        #region Data passed between forms
        public Pokemon ChosenFighter { get; set; }
        #endregion

        public void SetPokemons()
        {
            for (int i = 0; i < player.fighters.Count; i++)
            {
                Pokemon fighter = player.fighters[i];
                this.Controls[i].Text = fighter.name + "\r\n(" + fighter.health + "/" + fighter.hitpoints + ")";
                this.Controls[i].Tag = fighter;
                if (fighter.health != 0)
                {
                    this.Controls[i].Click += new System.EventHandler(this.fighterSelect);
                } else
                {
                    this.Controls[i].BackColor = Color.Red;
                }
            }
            
        }

        private void fighterSelect(object sender, EventArgs e)
        {
            ChosenFighter = player.fighters.Where(poke => poke == (sender as Button).Tag).First();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
