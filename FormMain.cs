using CargoRocketFontes.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoRocketFontes
{
    public partial class FormMain : Form
    {
        public static Config config;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "CargoRocketFontes " + Classes.Config.Version;

            config = new Config();
            config = Config.Load();
        }
    }
}
