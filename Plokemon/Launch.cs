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
    public partial class Launch : Form
    {
        public Launch()
        {
            InitializeComponent();
            PokeSetup();
        }

        #region Class members
        Pokemon fighter1;
        Pokemon fighter2;
        #endregion

        public void PokeSetup()
        {
            Pikachu pika = new Pikachu("pika");
            pika.name = "pika";
            fighter1 = pika;

            Charmeleon tim = new Charmeleon("tim");
            tim.name = "tim";
            fighter2 = tim;

            battleLog.Text += "\r\n \r\nI choose you " + fighter1.name + "!\r\nPlayer 2 chose: " + fighter2.name + "\r\n";
            Fight(0, 1);
        }

        // gezien er geen speed value is, gaan we ervan uit dat p1 altijd als eerdte aanvalt
        public void Fight(int p1_index, int p2_index)
        {
            battleLog.Text += fighter1.name + " used " + fighter1.attacks[p1_index].name + "\r\n";
            battleLog.Text += fighter2.Attacked(fighter1.attacks[p1_index]);

            battleLog.Text += fighter2.name + " used " + fighter2.attacks[p2_index].name + "\r\n";
            battleLog.Text += fighter1.Attacked(fighter2.attacks[p2_index]) + "\r\n";
        }

        private void fightButton_Click(object sender, EventArgs e)
        {

        }
    }
}
