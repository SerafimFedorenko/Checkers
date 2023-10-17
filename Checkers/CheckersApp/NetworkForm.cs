using CheckersNetworkLib;
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
    public partial class NetworkForm : Form
    {
        private Player player;
        public NetworkForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                player = new Client();
            }
            catch (Exception ex)
            {
                player = new Server();
            }
            MessageBox.Show("Connected");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Send("Здарова заебал");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = player.Receive();
            MessageBox.Show(message);
        }
    }
}
