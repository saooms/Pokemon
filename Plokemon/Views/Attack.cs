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
    public partial class Attack : Form
    {
        public Attack(Pokemon _fighter)
        {
            InitializeComponent();
            fighter = _fighter;
            SetAttacks();
        }

        #region Class members
        Pokemon fighter;
        #endregion

        #region Data passed between forms
        public int ChosenAttack { get; set; }
        #endregion

        public void SetAttacks()
        {
            for (int i = 0; i < fighter.attacks.Count; i++)
            {
                this.Controls[i].Text = fighter.attacks[i].name + "\r\n(" + fighter.attacks[i].damage + ")";
                this.Controls[i].Tag = i;
                this.Controls[i].Click += new System.EventHandler(this.attackSelected);
            }
        }

        private void attackSelected(object sender, EventArgs e)
        {
            ChosenAttack = Convert.ToInt32((sender as Button).Tag);           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
