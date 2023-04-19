using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersApp
{
    public partial class SelectingForm : Form
    {
        public SelectingForm()
        {
            InitializeComponent();
            Icon = new Icon(Environment.CurrentDirectory + "\\pictures\\icon.ico");
        }

        private void russianButton_Click(object sender, EventArgs e)
        {
            RussianCheckersForm russianCheckersForm = new RussianCheckersForm();
            russianCheckersForm.ShowDialog();
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            EnglishCheckersForm englishCheckersForm = new EnglishCheckersForm();
            englishCheckersForm.ShowDialog();
        }
    }
}
