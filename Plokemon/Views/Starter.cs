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
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();

            Pokemon Starter1 = new Pikachu("Pikachu");
            SetStarters(Starter1, button1);
            Pokemon Starter2 = new Charmeleon("Charmeleon");
            SetStarters(Starter2, button2);

            textBox1.Text = "player";
        }

        #region Data passed between forms
        public Pokemon SelectedStarter { get; set; }
        public string PlayerName { get; set; }
        #endregion

        public void SetStarters(Pokemon starter, Button button)
        {
            button.Text = starter.name + "\r\n" + starter.type.name;
            button.Tag = starter;
            button.Click += new System.EventHandler(this.starterClick);
        }

        private void starterClick(object sender, EventArgs e)
        {
            SelectedStarter = ((sender as Button).Tag as Pokemon);

            using (var form = new Name(SelectedStarter))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SelectedStarter = form.Fighter;
                    PlayerName = textBox1.Text;
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
