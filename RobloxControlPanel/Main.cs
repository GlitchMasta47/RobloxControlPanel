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
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        private RobloxLib Roblox;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Roblox = new RobloxLib();
        }
    }
}
