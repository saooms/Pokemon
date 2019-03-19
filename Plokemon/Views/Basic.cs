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
    public partial class Basic : Form
    {
        public Basic()
        {
            InitializeComponent();
            StartBattle();
        }

        public void StartBattle()
        {
            Pikachu pika = new Pikachu("Pika");
            Charmeleon charm = new Charmeleon("Charm");
            //eerst valt pika charm aan
            label1.Text += "\r" + pika.name + " used " + pika.attacks[0].name + "\r" + charm.name + " health: " + charm.health;
            charm.Attacked(pika.attacks[0]);
            label1.Text += "\r" + charm.name + " health: " + charm.health;
            label1.Text += "\r" + charm.name + " used " + charm.attacks[1].name + "\r" + pika.name + " health: " + pika.health;
            pika.Attacked(charm.attacks[1]);
            label1.Text += "\r" + pika.name + " health: " + pika.health;
        }
    }
}
