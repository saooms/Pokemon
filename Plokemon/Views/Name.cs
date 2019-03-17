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
    public partial class Name : Form
    {
        public Name(Pokemon _fighter)
        {
            InitializeComponent();

            Fighter = _fighter;
            SetName();
        }

        #region Data passed between forms
        public Pokemon Fighter { get; set; }
        #endregion

        public void SetName()
        {
            textBox1.Text = Fighter.name;
        }

        private void saveClick(object sender, EventArgs e)
        {
            Fighter.name = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
