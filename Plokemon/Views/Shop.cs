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
    public partial class Shop : Form
    {
        public Shop(Player _Player)
        {
            InitializeComponent();
            Player = _Player;

            Setstats();

            Product product = new Product(("teamheal"), "Team heal", 1);
            SetProduct(product, button1);
            product = new Product(new Pikachu("pikachu"), "Pikachu", 3);
            SetProduct(product, button2);
            product = new Product(new Charmeleon("Charmeleon"), "Charmeleon", 3);
            SetProduct(product, button3);
        }

        #region Class members
        public Player Player;
        #endregion

        public void SetPokemons()
        {
            for (int i = 0; i < Player.fighters.Count; i++)
            {
                Pokemon fighter = Player.fighters[i];
                this.Controls[i].Text = fighter.name + "\r\n(" + fighter.health + "/" + fighter.hitpoints + ")";
                this.Controls[i].Tag = fighter;
                this.Controls[i].Click += new System.EventHandler(this.fighterDelete_Click);
                if (fighter.health == 0)
                {
                    this.Controls[i].BackColor = Color.Red;
                }
            }

        }

        public void Setstats()
        {
            label1.Text = "Hearts: " + Player.hearts;
            SetPokemons();
        }

        public void SetProduct(Product product, Button button)
        {
            button.Text = product.name + "\r\rCost: " + product.price + " hearts";
            button.Tag = product;
            button.Click += new System.EventHandler(this.product_Click);
        }

        private void product_Click(object sender, EventArgs e)
        {
            Product Selectedproduct = ((sender as Button).Tag as Product);

            if (Selectedproduct.price <= Player.hearts)
            {
                Player.hearts -= Selectedproduct.price;
                if (Selectedproduct.item == ("teamheal"))
                {
                    foreach (Pokemon fighter in Player.fighters)
                    {
                        fighter.health = fighter.hitpoints;
                    }
                }
                else
                {
                    if (Player.fighters.Count <= 10)
                    {
                        using (var form = new Name(Selectedproduct.item as Pokemon))
                        {

                            var result = form.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                Player.fighters.Add(form.Fighter);
                            }
                            else
                            {
                                Player.hearts += Selectedproduct.price;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("you've reached the maximum plokemon cap");
                        Player.hearts += Selectedproduct.price;
                    }
                    
                }
                Setstats();
            }
            else
            {
                MessageBox.Show("no hearts?");
            }
           
        }

        private void fighterDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to remove this pokemon from your party?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Player.fighters.RemoveAll(fighter => fighter == ((sender as Button).Tag as Pokemon));
                Player.hearts += 1;
                Setstats();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
