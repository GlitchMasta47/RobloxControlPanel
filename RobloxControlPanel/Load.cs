using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RobloxAPI;

namespace RobloxControlPanel
{
    public partial class Load : MaterialSkin.Controls.MaterialForm
    {
        public RobloxLib Roblox;

        public Load()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Roblox = new RobloxLib();
            var mainForm = new Main();
            mainForm.Show();
            this.Close();
        }
    }
}
