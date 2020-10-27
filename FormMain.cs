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

        private void buttonRun_Click(object sender, EventArgs e)
        {
            SourceCompareOptions sourceCompareOptions = SourceCompareOptions.DEFAULT;
            if (checkBoxDiscardHour.Checked)
            {
                sourceCompareOptions = SourceCompareOptions.DISCARD_HOUR;
            }
            else if (checkBoxWithouSeconds.Checked)
            {
                sourceCompareOptions = SourceCompareOptions.WITHOUT_SECONDS;
            }
            SourceCompareResult sourceCompareResult = new SourceCompareResult();
            SourceCompare sourceCompare = new SourceCompare();
            sourceCompareResult = sourceCompare.Run(textBoxRepository.Text, textBoxSources.Text, sourceCompareOptions);

            textBoxResult.Clear();

            if (sourceCompareResult.sourceDiff.Count > 0)
            {
                textBoxResult.AppendText("Fontes com diferença: RPO x Repositório" + Environment.NewLine);
                textBoxResult.AppendText("---------------------------------------" + Environment.NewLine);
                for (int i = 0; i < sourceCompareResult.sourceDiff.Count; i++)
                {
                    textBoxResult.AppendText(sourceCompareResult.sourceDiff[i].filename + "=> " + sourceCompareResult.sourceDiff[i].DateRPO + ":" + sourceCompareResult.sourceDiff[i].HourRPO + " X " + sourceCompareResult.sourceDiff[i].DateRepository + ":" + sourceCompareResult.sourceDiff[i].HourRepository + Environment.NewLine);
                }
            }


            if (sourceCompareResult.sourceNonExistent.Count > 0)
            {
                if (sourceCompareResult.sourceDiff.Count > 0)
                {
                    textBoxResult.AppendText(Environment.NewLine);
                    textBoxResult.AppendText(Environment.NewLine);
                }
                textBoxResult.AppendText("Fontes não existentes no RPO" + Environment.NewLine);
                textBoxResult.AppendText("----------------------------" + Environment.NewLine);
                for (int i = 0; i < sourceCompareResult.sourceNonExistent.Count; i++)
                {
                    textBoxResult.AppendText(sourceCompareResult.sourceNonExistent[i].filename + Environment.NewLine);
                }
            }

        }

        private void checkBoxWithouSeconds_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDiscardHour_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxWithouSeconds.Checked = false;
            checkBoxWithouSeconds.Enabled = !checkBoxDiscardHour.Checked;
        }
    }
}
