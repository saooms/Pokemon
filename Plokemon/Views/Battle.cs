using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Plokemon.Classes;


namespace Plokemon
{
    public partial class Battle : Form
    {
        public Battle(Player _player1, Player _player2)
        {
            InitializeComponent();
            player1 = _player1;
            fighter1 = player1.fighters[0];
            player2 = _player2;
            fighter2 = player2.fighters[0];
            PokeSetup();
        }

        #region Class members
        Player player1;
        Player player2;
        Pokemon fighter1;
        Pokemon fighter2;
        int index = 0;
        string line = "";
        List<System.Timers.Timer> timerList = new List<System.Timers.Timer>();
        #endregion

        #region Data passed between forms
        public Boolean victory { get; set; }
        #endregion

        public void PokeSetup()
        {
            StatusUpdate(fighter1);
            StatusUpdate(fighter2);
            line += "\r \rI choose you " + fighter1.name + "!\r" + player2.name + " chose: " + fighter2.name + "\r";

            Read(line);
        }

        public void StatusUpdate(Pokemon fighter)
        {
            if (fighter == fighter2)
            {
                nameLabel2.Text = fighter2.name + "  (" + fighter2.health + "/" + fighter2.hitpoints + ")";
                progressBar2.Value = fighter2.health * 100 / fighter2.hitpoints;
            }
            else
            {
                nameLabel1.Text = fighter1.name + "  (" + fighter1.health + "/" + fighter1.hitpoints + ")";
                progressBar1.Value = fighter1.health * 100 / fighter1.hitpoints;
            }

            if (fighter.health == 0)
            {
                line += fighter.name + " got killed!\r";
                if (fighter == fighter1)
                {
                    if (!player1.fighters.Any(poke => poke.health > 0))
                    {
                        line += "all your pokemon died in battle, you lose\r";
                        EndBattle(false);
                    } else { 
                    SwitchFighter();
                    }
                }
                else if (index < (player2.fighters.Count - 1)) // -1 omdat een arrays op 0 beginnen
                {
                    fighter2 = player2.fighters[++index];
                    StatusUpdate(fighter2);
                }
                else
                {
                    line += "all " + player2.name + "'s fighters where killed in battle...\rYou win!";
                    EndBattle(true);
                }
            }


        }

        // gezien er geen speed value is, gaan we ervan uit dat p1 altijd als eerdte aanvalt.
        // de attacked method in pokemon returned een string die wordt dan ook meteen in de battleLog gezet.
        public void Fight(Pokemon fighter, Pokemon target, int move)
        {
            if (fighter.health != 0)
            {
                line += fighter.name + " used " + fighter.attacks[move].name + "\r";
                line += target.Attacked(fighter.attacks[move]);

                StatusUpdate(target);
            }

        }

        public void SwitchFighter()
        {
            using (var form = new Switch(player1))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                    ClearLog();
                    line += "**" + fighter1.name + " has been retrieved**\r\rrest easy " + fighter1.name + "...\r";
                    fighter1 = form.ChosenFighter;
                    StatusUpdate(fighter1);
                }
            }
        }

        // functie zorgt er voor dat text letter voor letter gelezen wordt
        public void Read(string text)
        {
            var index = 0;
            var timer = new System.Timers.Timer(10);
            timerList.Add(timer);
            timer.Elapsed += delegate
            {
                if (index < text.Length)
                {
                    // een try catch, omdat er het soms nog probeert doortegaan als de form gesloten is
                    try
                    {
                        battleLog.Invoke((MethodInvoker)(() => battleLog.Text += text[index++].ToString()));
                    }
                    catch (Exception)
                    {
                        timer.Enabled = false;
                        timer.Dispose();
                    }
                    
                }
                else
                {
                    timer.Enabled = false;
                    timer.Dispose();
                }
            };
            line = "";
            timer.Enabled = true;
        }

        public void ClearLog()
        {
            if (timerList.Count > 0)
            {
                timerList[0].Enabled = false;
                timerList[0].Dispose();
                timerList.Clear();
                battleLog.Text = "";
            }
        }

        public void EndBattle(Boolean result)
        {
            victory = result;
            fightButton.Visible = false;
            plokemonButton.Visible = false;
            returnButton.Visible = true;
        }


        #region Winform actions

        private void fightButton_Click(object sender, EventArgs e)
        {
            using (var form = new Attack(fighter1))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ClearLog();
                    Fight(fighter1, fighter2, form.ChosenAttack);

                    Random rnd = new Random();
                    int attack = rnd.Next(0, fighter2.attacks.Count);
                    Fight(fighter2, fighter1, attack);
                    Read(line);
                }
            }
        }

        private void plokemonButton_Click(object sender, EventArgs e)
        {
            SwitchFighter();
            line += "Come help out, " + fighter1.name + "!\r";
            Random rnd = new Random();
            int attack = rnd.Next(0, fighter2.attacks.Count);
            Fight(fighter2, fighter1, attack);
            StatusUpdate(fighter1);
            Read(line);
        }

        #endregion

        private void returnButton_Click(object sender, EventArgs e)
        {
            ClearLog();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
