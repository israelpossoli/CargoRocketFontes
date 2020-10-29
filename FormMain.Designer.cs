namespace CargoRocketFontes
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxDiscardHour = new System.Windows.Forms.CheckBox();
            this.checkBoxWithouSeconds = new System.Windows.Forms.CheckBox();
            this.textBoxSources = new System.Windows.Forms.TextBox();
            this.textBoxRepository = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.progressBarExec = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxDiscardHour);
            this.tabPage1.Controls.Add(this.checkBoxWithouSeconds);
            this.tabPage1.Controls.Add(this.textBoxSources);
            this.tabPage1.Controls.Add(this.textBoxRepository);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuração";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiscardHour
            // 
            this.checkBoxDiscardHour.AutoSize = true;
            this.checkBoxDiscardHour.Location = new System.Drawing.Point(9, 113);
            this.checkBoxDiscardHour.Name = "checkBoxDiscardHour";
            this.checkBoxDiscardHour.Size = new System.Drawing.Size(115, 17);
            this.checkBoxDiscardHour.TabIndex = 5;
            this.checkBoxDiscardHour.Text = "Desconsidera hora";
            this.checkBoxDiscardHour.UseVisualStyleBackColor = true;
            this.checkBoxDiscardHour.CheckedChanged += new System.EventHandler(this.checkBoxDiscardHour_CheckedChanged);
            // 
            // checkBoxWithouSeconds
            // 
            this.checkBoxWithouSeconds.AutoSize = true;
            this.checkBoxWithouSeconds.Location = new System.Drawing.Point(9, 136);
            this.checkBoxWithouSeconds.Name = "checkBoxWithouSeconds";
            this.checkBoxWithouSeconds.Size = new System.Drawing.Size(140, 17);
            this.checkBoxWithouSeconds.TabIndex = 4;
            this.checkBoxWithouSeconds.Text = "Desconsidera segundos";
            this.checkBoxWithouSeconds.UseVisualStyleBackColor = true;
            this.checkBoxWithouSeconds.CheckedChanged += new System.EventHandler(this.checkBoxWithouSeconds_CheckedChanged);
            // 
            // textBoxSources
            // 
            this.textBoxSources.Location = new System.Drawing.Point(9, 75);
            this.textBoxSources.Name = "textBoxSources";
            this.textBoxSources.Size = new System.Drawing.Size(560, 20);
            this.textBoxSources.TabIndex = 3;
            this.textBoxSources.Text = "C:\\Cargolift\\Temp\\SourceCompare\\exporta_dados.csv";
            // 
            // textBoxRepository
            // 
            this.textBoxRepository.Location = new System.Drawing.Point(9, 19);
            this.textBoxRepository.Name = "textBoxRepository";
            this.textBoxRepository.Size = new System.Drawing.Size(560, 20);
            this.textBoxRepository.TabIndex = 2;
            this.textBoxRepository.Text = "C:\\Cargolift\\SVN\\Protheus\\trunk\\V12\\PROTHEUS12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arquivo com os fontes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repositório:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(6, 6);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(756, 359);
            this.textBoxResult.TabIndex = 0;
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRun.Location = new System.Drawing.Point(12, 415);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Executar";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // progressBarExec
            // 
            this.progressBarExec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarExec.Location = new System.Drawing.Point(93, 415);
            this.progressBarExec.Name = "progressBarExec";
            this.progressBarExec.Size = new System.Drawing.Size(691, 23);
            this.progressBarExec.TabIndex = 2;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarExec);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxSources;
        private System.Windows.Forms.TextBox textBoxRepository;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.CheckBox checkBoxDiscardHour;
        private System.Windows.Forms.CheckBox checkBoxWithouSeconds;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ProgressBar progressBarExec;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

