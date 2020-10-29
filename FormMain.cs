using CargoRocketFontes.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoRocketFontes
{
    public partial class FormMain : Form
    {
        public static Config config;
        private SourceCompareResult sourceCompareResult;

        public FormMain()
        {
            InitializeComponent();

            sourceCompareResult = new SourceCompareResult();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "CargoRocketFontes " + Classes.Config.Version;

            config = new Config();
            config = Config.Load();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            buttonRun.Enabled = false;
            progressBarExec.Value = 0;
            progressBarExec.Style = ProgressBarStyle.Marquee;

            backgroundWorker.RunWorkerAsync();
        }

        private void checkBoxWithouSeconds_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDiscardHour_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxWithouSeconds.Checked = false;
            checkBoxWithouSeconds.Enabled = !checkBoxDiscardHour.Checked;
        }


        /// <summary>
        /// Evento de inicialização do ProgressBar classe SourceCompare
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        private void SourceCompare_ProgressInitialize(int min, int max)
        {
            base.Invoke((Action)delegate
            {
                progressBarExec.Minimum = min;
                progressBarExec.Maximum = max;
                if (min == 0 && max == 0)
                {
                    progressBarExec.Style = ProgressBarStyle.Marquee;
                }
                else
                {
                    progressBarExec.Style = ProgressBarStyle.Blocks;
                }

                progressBarExec.Refresh();
            });

        }

        /// <summary>
        /// Evento da classe SourceCompare
        /// </summary>
        /// <param name="progress"></param>
        private void SourceCompare_ProgressChanged(int progress)
        {
            base.Invoke((Action)delegate
            {
                progressBarExec.Value = progress;
                progressBarExec.Refresh();
                Application.DoEvents();
            });
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SourceCompareOptions sourceCompareOptions = SourceCompareOptions.DEFAULT;
            if (checkBoxDiscardHour.Checked)
            {
                sourceCompareOptions = SourceCompareOptions.DISCARD_HOUR;
            }
            else if (checkBoxWithouSeconds.Checked)
            {
                sourceCompareOptions = SourceCompareOptions.DISCARD_SECONDS;
            }

            SourceCompare sourceCompare = new SourceCompare();
            sourceCompare.ProgressInitialize += SourceCompare_ProgressInitialize;
            sourceCompare.ProgressChanged += SourceCompare_ProgressChanged;
            sourceCompareResult.Clear();
            sourceCompareResult = sourceCompare.Run(textBoxRepository.Text, textBoxSources.Text, sourceCompareOptions, sender as BackgroundWorker);
            // sourceCompareResult = sourceCompare.Teste(textBoxRepository.Text, textBoxSources.Text, sourceCompareOptions, sender as BackgroundWorker);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
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

            buttonRun.Enabled = true;
        }
    }
}
