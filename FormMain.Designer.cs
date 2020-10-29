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
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelSourcesNotFound = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalDiffSources = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalSourceRepository = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxDiscardHour = new System.Windows.Forms.CheckBox();
            this.checkBoxWithouSeconds = new System.Windows.Forms.CheckBox();
            this.textBoxSources = new System.Windows.Forms.TextBox();
            this.textBoxRepository = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.tabPageDiffSources = new System.Windows.Forms.TabPage();
            this.listViewDiffSource = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageSourceNotFound = new System.Windows.Forms.TabPage();
            this.listViewSourcesNotFound = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRun = new System.Windows.Forms.Button();
            this.progressBarExec = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.textBoxExtensions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.tabPageDiffSources.SuspendLayout();
            this.tabPageSourceNotFound.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageResult);
            this.tabControl1.Controls.Add(this.tabPageDiffSources);
            this.tabControl1.Controls.Add(this.tabPageSourceNotFound);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxExtensions);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBoxResult);
            this.tabPage1.Controls.Add(this.checkBoxDiscardHour);
            this.tabPage1.Controls.Add(this.checkBoxWithouSeconds);
            this.tabPage1.Controls.Add(this.textBoxSources);
            this.tabPage1.Controls.Add(this.textBoxRepository);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuração";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResult.Controls.Add(this.labelSourcesNotFound);
            this.groupBoxResult.Controls.Add(this.label7);
            this.groupBoxResult.Controls.Add(this.labelTotalDiffSources);
            this.groupBoxResult.Controls.Add(this.label5);
            this.groupBoxResult.Controls.Add(this.labelTotalSourceRepository);
            this.groupBoxResult.Controls.Add(this.label3);
            this.groupBoxResult.Location = new System.Drawing.Point(9, 233);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(752, 124);
            this.groupBoxResult.TabIndex = 6;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Resultado";
            this.groupBoxResult.Visible = false;
            // 
            // labelSourcesNotFound
            // 
            this.labelSourcesNotFound.AutoSize = true;
            this.labelSourcesNotFound.Location = new System.Drawing.Point(175, 70);
            this.labelSourcesNotFound.Name = "labelSourcesNotFound";
            this.labelSourcesNotFound.Size = new System.Drawing.Size(13, 13);
            this.labelSourcesNotFound.TabIndex = 5;
            this.labelSourcesNotFound.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total de fontes não compilados:";
            // 
            // labelTotalDiffSources
            // 
            this.labelTotalDiffSources.AutoSize = true;
            this.labelTotalDiffSources.Location = new System.Drawing.Point(175, 48);
            this.labelTotalDiffSources.Name = "labelTotalDiffSources";
            this.labelTotalDiffSources.Size = new System.Drawing.Size(13, 13);
            this.labelTotalDiffSources.TabIndex = 3;
            this.labelTotalDiffSources.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total de fontes com diferenças:";
            // 
            // labelTotalSourceRepository
            // 
            this.labelTotalSourceRepository.AutoSize = true;
            this.labelTotalSourceRepository.Location = new System.Drawing.Point(175, 25);
            this.labelTotalSourceRepository.Name = "labelTotalSourceRepository";
            this.labelTotalSourceRepository.Size = new System.Drawing.Size(13, 13);
            this.labelTotalSourceRepository.TabIndex = 1;
            this.labelTotalSourceRepository.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de fontes no repositório:";
            // 
            // checkBoxDiscardHour
            // 
            this.checkBoxDiscardHour.AutoSize = true;
            this.checkBoxDiscardHour.Location = new System.Drawing.Point(11, 175);
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
            this.checkBoxWithouSeconds.Location = new System.Drawing.Point(11, 198);
            this.checkBoxWithouSeconds.Name = "checkBoxWithouSeconds";
            this.checkBoxWithouSeconds.Size = new System.Drawing.Size(140, 17);
            this.checkBoxWithouSeconds.TabIndex = 4;
            this.checkBoxWithouSeconds.Text = "Desconsidera segundos";
            this.checkBoxWithouSeconds.UseVisualStyleBackColor = true;
            this.checkBoxWithouSeconds.CheckedChanged += new System.EventHandler(this.checkBoxWithouSeconds_CheckedChanged);
            // 
            // textBoxSources
            // 
            this.textBoxSources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSources.Location = new System.Drawing.Point(9, 75);
            this.textBoxSources.Name = "textBoxSources";
            this.textBoxSources.Size = new System.Drawing.Size(753, 20);
            this.textBoxSources.TabIndex = 3;
            this.textBoxSources.Text = "C:\\Cargolift\\Temp\\SourceCompare\\exporta_dados.csv";
            // 
            // textBoxRepository
            // 
            this.textBoxRepository.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepository.Location = new System.Drawing.Point(9, 19);
            this.textBoxRepository.Name = "textBoxRepository";
            this.textBoxRepository.Size = new System.Drawing.Size(753, 20);
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
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.textBoxResult);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(899, 372);
            this.tabPageResult.TabIndex = 1;
            this.tabPageResult.Text = "Resultado";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(6, 6);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(966, 360);
            this.textBoxResult.TabIndex = 0;
            // 
            // tabPageDiffSources
            // 
            this.tabPageDiffSources.Controls.Add(this.listViewDiffSource);
            this.tabPageDiffSources.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiffSources.Name = "tabPageDiffSources";
            this.tabPageDiffSources.Size = new System.Drawing.Size(899, 372);
            this.tabPageDiffSources.TabIndex = 2;
            this.tabPageDiffSources.Text = "Fontes divergente";
            this.tabPageDiffSources.UseVisualStyleBackColor = true;
            // 
            // listViewDiffSource
            // 
            this.listViewDiffSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDiffSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDiffSource.FullRowSelect = true;
            this.listViewDiffSource.GridLines = true;
            this.listViewDiffSource.Location = new System.Drawing.Point(3, 3);
            this.listViewDiffSource.MultiSelect = false;
            this.listViewDiffSource.Name = "listViewDiffSource";
            this.listViewDiffSource.Size = new System.Drawing.Size(893, 366);
            this.listViewDiffSource.TabIndex = 0;
            this.listViewDiffSource.UseCompatibleStateImageBehavior = false;
            this.listViewDiffSource.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fonte";
            this.columnHeader1.Width = 520;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data RPO";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora RPO";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data Rep.";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hora Rep.";
            this.columnHeader5.Width = 90;
            // 
            // tabPageSourceNotFound
            // 
            this.tabPageSourceNotFound.Controls.Add(this.listViewSourcesNotFound);
            this.tabPageSourceNotFound.Location = new System.Drawing.Point(4, 22);
            this.tabPageSourceNotFound.Name = "tabPageSourceNotFound";
            this.tabPageSourceNotFound.Size = new System.Drawing.Size(899, 372);
            this.tabPageSourceNotFound.TabIndex = 3;
            this.tabPageSourceNotFound.Text = "Fontes não encontrados";
            this.tabPageSourceNotFound.UseVisualStyleBackColor = true;
            // 
            // listViewSourcesNotFound
            // 
            this.listViewSourcesNotFound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSourcesNotFound.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewSourcesNotFound.FullRowSelect = true;
            this.listViewSourcesNotFound.GridLines = true;
            this.listViewSourcesNotFound.Location = new System.Drawing.Point(3, 3);
            this.listViewSourcesNotFound.MultiSelect = false;
            this.listViewSourcesNotFound.Name = "listViewSourcesNotFound";
            this.listViewSourcesNotFound.Size = new System.Drawing.Size(893, 366);
            this.listViewSourcesNotFound.TabIndex = 1;
            this.listViewSourcesNotFound.UseCompatibleStateImageBehavior = false;
            this.listViewSourcesNotFound.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fonte";
            this.columnHeader6.Width = 700;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Data Rep.";
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Hora Rep.";
            this.columnHeader10.Width = 90;
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRun.Location = new System.Drawing.Point(12, 416);
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
            this.progressBarExec.Location = new System.Drawing.Point(93, 416);
            this.progressBarExec.Name = "progressBarExec";
            this.progressBarExec.Size = new System.Drawing.Size(822, 23);
            this.progressBarExec.TabIndex = 2;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // textBoxExtensions
            // 
            this.textBoxExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtensions.Location = new System.Drawing.Point(11, 133);
            this.textBoxExtensions.Name = "textBoxExtensions";
            this.textBoxExtensions.Size = new System.Drawing.Size(753, 20);
            this.textBoxExtensions.TabIndex = 8;
            this.textBoxExtensions.Text = "*.prw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Extensões:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 451);
            this.Controls.Add(this.progressBarExec);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.tabPageResult.ResumeLayout(false);
            this.tabPageResult.PerformLayout();
            this.tabPageDiffSources.ResumeLayout(false);
            this.tabPageSourceNotFound.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxSources;
        private System.Windows.Forms.TextBox textBoxRepository;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.CheckBox checkBoxDiscardHour;
        private System.Windows.Forms.CheckBox checkBoxWithouSeconds;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ProgressBar progressBarExec;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TabPage tabPageDiffSources;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TabPage tabPageSourceNotFound;
        private System.Windows.Forms.ListView listViewDiffSource;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelTotalSourceRepository;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSourcesNotFound;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalDiffSources;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewSourcesNotFound;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox textBoxExtensions;
        private System.Windows.Forms.Label label4;
    }
}

