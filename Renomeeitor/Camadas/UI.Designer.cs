namespace Renomeeitor
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.lblExtensao = new System.Windows.Forms.Label();
            this.txtExtensao = new System.Windows.Forms.TextBox();
            this.btnSelecionaPasta = new System.Windows.Forms.Button();
            this.lblPastaSelecionada = new System.Windows.Forms.Label();
            this.txtPastaSelecionada = new System.Windows.Forms.TextBox();
            this.txtDe1 = new System.Windows.Forms.TextBox();
            this.txtDe2 = new System.Windows.Forms.TextBox();
            this.txtDe3 = new System.Windows.Forms.TextBox();
            this.txtPara1 = new System.Windows.Forms.TextBox();
            this.txtPara2 = new System.Windows.Forms.TextBox();
            this.txtPara3 = new System.Windows.Forms.TextBox();
            this.lblDe1 = new System.Windows.Forms.Label();
            this.lblDe2 = new System.Windows.Forms.Label();
            this.lblDe3 = new System.Windows.Forms.Label();
            this.lblPara1 = new System.Windows.Forms.Label();
            this.lblPara2 = new System.Windows.Forms.Label();
            this.lblPara3 = new System.Windows.Forms.Label();
            this.lblTrechos = new System.Windows.Forms.Label();
            this.rbtFalse = new System.Windows.Forms.RadioButton();
            this.rbtToUpper = new System.Windows.Forms.RadioButton();
            this.rbtToLower = new System.Windows.Forms.RadioButton();
            this.rbtUcWords = new System.Windows.Forms.RadioButton();
            this.rbtUcFirst = new System.Windows.Forms.RadioButton();
            this.grpEstilo = new System.Windows.Forms.GroupBox();
            this.btnRenomear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBasico = new System.Windows.Forms.TabPage();
            this.btnLimparBasico = new System.Windows.Forms.Button();
            this.chkSubPastas = new System.Windows.Forms.CheckBox();
            this.btnPreVisualizarBasico = new System.Windows.Forms.Button();
            this.tabPageAvancado = new System.Windows.Forms.TabPage();
            this.grpBlocoDeNotas = new System.Windows.Forms.GroupBox();
            this.btnPreVisualizarTxt = new System.Windows.Forms.Button();
            this.btnSelecionaTxt = new System.Windows.Forms.Button();
            this.btnExecutaTxt = new System.Windows.Forms.Button();
            this.txtEnderecoBlocDeNot = new System.Windows.Forms.TextBox();
            this.lblEnderecoBlocDeNot = new System.Windows.Forms.Label();
            this.grpOpcoesAvancadas = new System.Windows.Forms.GroupBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimparAvancado = new System.Windows.Forms.Button();
            this.btnPreVisualizarAvancado = new System.Windows.Forms.Button();
            this.mskApos = new System.Windows.Forms.MaskedTextBox();
            this.mskAo = new System.Windows.Forms.MaskedTextBox();
            this.mskDo = new System.Windows.Forms.MaskedTextBox();
            this.btnRenomearAvancado = new System.Windows.Forms.Button();
            this.lblApaga = new System.Windows.Forms.Label();
            this.txtAcrescentarFim = new System.Windows.Forms.TextBox();
            this.lblAcrescentarFim = new System.Windows.Forms.Label();
            this.lblAo = new System.Windows.Forms.Label();
            this.txtAcrescentarInicio = new System.Windows.Forms.TextBox();
            this.lblAcrescentarInicio = new System.Windows.Forms.Label();
            this.lblCaracter1 = new System.Windows.Forms.Label();
            this.lblAcrescentar = new System.Windows.Forms.Label();
            this.lblCaracter2 = new System.Windows.Forms.Label();
            this.txtAcrescentarTrecho = new System.Windows.Forms.TextBox();
            this.lblApos = new System.Windows.Forms.Label();
            this.lblManipulacao = new System.Windows.Forms.Label();
            this.tabPagePreVisualizacao = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDepois = new System.Windows.Forms.Label();
            this.lblAntes = new System.Windows.Forms.Label();
            this.lstDepois = new System.Windows.Forms.ListBox();
            this.lstAntes = new System.Windows.Forms.ListBox();
            this.tabPageSobre = new System.Windows.Forms.TabPage();
            this.lnlCopyRight = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.grpEstilo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBasico.SuspendLayout();
            this.tabPageAvancado.SuspendLayout();
            this.grpBlocoDeNotas.SuspendLayout();
            this.grpOpcoesAvancadas.SuspendLayout();
            this.tabPagePreVisualizacao.SuspendLayout();
            this.tabPageSobre.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExtensao
            // 
            this.lblExtensao.AutoSize = true;
            this.lblExtensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtensao.Location = new System.Drawing.Point(22, 68);
            this.lblExtensao.Name = "lblExtensao";
            this.lblExtensao.Size = new System.Drawing.Size(376, 18);
            this.lblExtensao.TabIndex = 0;
            this.lblExtensao.Text = "Tipo de arquivo permitido: (Exemplos: rar, mp3, jpg, etc)";
            // 
            // txtExtensao
            // 
            this.txtExtensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtensao.Location = new System.Drawing.Point(402, 66);
            this.txtExtensao.MaxLength = 4;
            this.txtExtensao.Name = "txtExtensao";
            this.txtExtensao.Size = new System.Drawing.Size(79, 24);
            this.txtExtensao.TabIndex = 2;
            this.txtExtensao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSelecionaPasta
            // 
            this.btnSelecionaPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionaPasta.Location = new System.Drawing.Point(416, 19);
            this.btnSelecionaPasta.Name = "btnSelecionaPasta";
            this.btnSelecionaPasta.Size = new System.Drawing.Size(131, 32);
            this.btnSelecionaPasta.TabIndex = 1;
            this.btnSelecionaPasta.Text = "Selecionar Pasta";
            this.btnSelecionaPasta.UseVisualStyleBackColor = true;
            this.btnSelecionaPasta.Click += new System.EventHandler(this.btnSelecionaPasta_Click);
            // 
            // lblPastaSelecionada
            // 
            this.lblPastaSelecionada.AutoSize = true;
            this.lblPastaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastaSelecionada.Location = new System.Drawing.Point(22, 26);
            this.lblPastaSelecionada.Name = "lblPastaSelecionada";
            this.lblPastaSelecionada.Size = new System.Drawing.Size(135, 18);
            this.lblPastaSelecionada.TabIndex = 3;
            this.lblPastaSelecionada.Text = "Pasta Selecionada:";
            // 
            // txtPastaSelecionada
            // 
            this.txtPastaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPastaSelecionada.Location = new System.Drawing.Point(157, 23);
            this.txtPastaSelecionada.Name = "txtPastaSelecionada";
            this.txtPastaSelecionada.ReadOnly = true;
            this.txtPastaSelecionada.Size = new System.Drawing.Size(251, 24);
            this.txtPastaSelecionada.TabIndex = 88;
            // 
            // txtDe1
            // 
            this.txtDe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDe1.Location = new System.Drawing.Point(69, 145);
            this.txtDe1.Name = "txtDe1";
            this.txtDe1.Size = new System.Drawing.Size(220, 24);
            this.txtDe1.TabIndex = 5;
            // 
            // txtDe2
            // 
            this.txtDe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDe2.Location = new System.Drawing.Point(69, 178);
            this.txtDe2.Name = "txtDe2";
            this.txtDe2.Size = new System.Drawing.Size(220, 24);
            this.txtDe2.TabIndex = 7;
            // 
            // txtDe3
            // 
            this.txtDe3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDe3.Location = new System.Drawing.Point(69, 209);
            this.txtDe3.Name = "txtDe3";
            this.txtDe3.Size = new System.Drawing.Size(220, 24);
            this.txtDe3.TabIndex = 9;
            // 
            // txtPara1
            // 
            this.txtPara1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara1.Location = new System.Drawing.Point(346, 145);
            this.txtPara1.Name = "txtPara1";
            this.txtPara1.Size = new System.Drawing.Size(220, 24);
            this.txtPara1.TabIndex = 6;
            // 
            // txtPara2
            // 
            this.txtPara2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara2.Location = new System.Drawing.Point(346, 178);
            this.txtPara2.Name = "txtPara2";
            this.txtPara2.Size = new System.Drawing.Size(220, 24);
            this.txtPara2.TabIndex = 8;
            // 
            // txtPara3
            // 
            this.txtPara3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara3.Location = new System.Drawing.Point(346, 209);
            this.txtPara3.Name = "txtPara3";
            this.txtPara3.Size = new System.Drawing.Size(220, 24);
            this.txtPara3.TabIndex = 10;
            // 
            // lblDe1
            // 
            this.lblDe1.AutoSize = true;
            this.lblDe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe1.Location = new System.Drawing.Point(21, 149);
            this.lblDe1.Name = "lblDe1";
            this.lblDe1.Size = new System.Drawing.Size(39, 18);
            this.lblDe1.TabIndex = 11;
            this.lblDe1.Text = "  De:";
            // 
            // lblDe2
            // 
            this.lblDe2.AutoSize = true;
            this.lblDe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe2.Location = new System.Drawing.Point(21, 181);
            this.lblDe2.Name = "lblDe2";
            this.lblDe2.Size = new System.Drawing.Size(39, 18);
            this.lblDe2.TabIndex = 12;
            this.lblDe2.Text = "  De:";
            // 
            // lblDe3
            // 
            this.lblDe3.AutoSize = true;
            this.lblDe3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe3.Location = new System.Drawing.Point(21, 212);
            this.lblDe3.Name = "lblDe3";
            this.lblDe3.Size = new System.Drawing.Size(39, 18);
            this.lblDe3.TabIndex = 14;
            this.lblDe3.Text = "  De:";
            // 
            // lblPara1
            // 
            this.lblPara1.AutoSize = true;
            this.lblPara1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara1.Location = new System.Drawing.Point(299, 148);
            this.lblPara1.Name = "lblPara1";
            this.lblPara1.Size = new System.Drawing.Size(43, 18);
            this.lblPara1.TabIndex = 15;
            this.lblPara1.Text = "Para:";
            // 
            // lblPara2
            // 
            this.lblPara2.AutoSize = true;
            this.lblPara2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara2.Location = new System.Drawing.Point(299, 181);
            this.lblPara2.Name = "lblPara2";
            this.lblPara2.Size = new System.Drawing.Size(43, 18);
            this.lblPara2.TabIndex = 16;
            this.lblPara2.Text = "Para:";
            // 
            // lblPara3
            // 
            this.lblPara3.AutoSize = true;
            this.lblPara3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara3.Location = new System.Drawing.Point(299, 212);
            this.lblPara3.Name = "lblPara3";
            this.lblPara3.Size = new System.Drawing.Size(43, 18);
            this.lblPara3.TabIndex = 17;
            this.lblPara3.Text = "Para:";
            // 
            // lblTrechos
            // 
            this.lblTrechos.AutoSize = true;
            this.lblTrechos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrechos.Location = new System.Drawing.Point(22, 108);
            this.lblTrechos.Name = "lblTrechos";
            this.lblTrechos.Size = new System.Drawing.Size(279, 18);
            this.lblTrechos.TabIndex = 18;
            this.lblTrechos.Text = "Substituir trechos no nome dos arquivos:";
            // 
            // rbtFalse
            // 
            this.rbtFalse.AutoSize = true;
            this.rbtFalse.Checked = true;
            this.rbtFalse.Location = new System.Drawing.Point(15, 19);
            this.rbtFalse.Name = "rbtFalse";
            this.rbtFalse.Size = new System.Drawing.Size(143, 22);
            this.rbtFalse.TabIndex = 20;
            this.rbtFalse.TabStop = true;
            this.rbtFalse.Text = "Deixar como está";
            this.rbtFalse.UseVisualStyleBackColor = true;
            // 
            // rbtToUpper
            // 
            this.rbtToUpper.AutoSize = true;
            this.rbtToUpper.Location = new System.Drawing.Point(15, 42);
            this.rbtToUpper.Name = "rbtToUpper";
            this.rbtToUpper.Size = new System.Drawing.Size(133, 22);
            this.rbtToUpper.TabIndex = 21;
            this.rbtToUpper.TabStop = true;
            this.rbtToUpper.Text = "Todo maiusculo";
            this.rbtToUpper.UseVisualStyleBackColor = true;
            // 
            // rbtToLower
            // 
            this.rbtToLower.AutoSize = true;
            this.rbtToLower.Location = new System.Drawing.Point(15, 65);
            this.rbtToLower.Name = "rbtToLower";
            this.rbtToLower.Size = new System.Drawing.Size(133, 22);
            this.rbtToLower.TabIndex = 22;
            this.rbtToLower.TabStop = true;
            this.rbtToLower.Text = "Todo minusculo";
            this.rbtToLower.UseVisualStyleBackColor = true;
            // 
            // rbtUcWords
            // 
            this.rbtUcWords.AutoSize = true;
            this.rbtUcWords.Location = new System.Drawing.Point(15, 91);
            this.rbtUcWords.Name = "rbtUcWords";
            this.rbtUcWords.Size = new System.Drawing.Size(317, 22);
            this.rbtUcWords.TabIndex = 23;
            this.rbtUcWords.TabStop = true;
            this.rbtUcWords.Text = "Primeira letra de cada palavra em maiusculo";
            this.rbtUcWords.UseVisualStyleBackColor = true;
            // 
            // rbtUcFirst
            // 
            this.rbtUcFirst.AutoSize = true;
            this.rbtUcFirst.Location = new System.Drawing.Point(15, 114);
            this.rbtUcFirst.Name = "rbtUcFirst";
            this.rbtUcFirst.Size = new System.Drawing.Size(346, 22);
            this.rbtUcFirst.TabIndex = 24;
            this.rbtUcFirst.TabStop = true;
            this.rbtUcFirst.Text = "Primeira letra do nome do arquivo em maiusculo";
            this.rbtUcFirst.UseVisualStyleBackColor = true;
            // 
            // grpEstilo
            // 
            this.grpEstilo.Controls.Add(this.rbtFalse);
            this.grpEstilo.Controls.Add(this.rbtUcFirst);
            this.grpEstilo.Controls.Add(this.rbtToUpper);
            this.grpEstilo.Controls.Add(this.rbtUcWords);
            this.grpEstilo.Controls.Add(this.rbtToLower);
            this.grpEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEstilo.Location = new System.Drawing.Point(25, 258);
            this.grpEstilo.Name = "grpEstilo";
            this.grpEstilo.Size = new System.Drawing.Size(399, 146);
            this.grpEstilo.TabIndex = 25;
            this.grpEstilo.TabStop = false;
            this.grpEstilo.Text = "Deixar nomes dos arquivos:";
            // 
            // btnRenomear
            // 
            this.btnRenomear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenomear.Location = new System.Drawing.Point(489, 250);
            this.btnRenomear.Name = "btnRenomear";
            this.btnRenomear.Size = new System.Drawing.Size(108, 49);
            this.btnRenomear.TabIndex = 26;
            this.btnRenomear.Text = "Renomear Arquivos";
            this.btnRenomear.UseVisualStyleBackColor = true;
            this.btnRenomear.Click += new System.EventHandler(this.btnRenomear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBasico);
            this.tabControl1.Controls.Add(this.tabPageAvancado);
            this.tabControl1.Controls.Add(this.tabPagePreVisualizacao);
            this.tabControl1.Controls.Add(this.tabPageSobre);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 459);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPageBasico
            // 
            this.tabPageBasico.Controls.Add(this.btnLimparBasico);
            this.tabPageBasico.Controls.Add(this.chkSubPastas);
            this.tabPageBasico.Controls.Add(this.btnPreVisualizarBasico);
            this.tabPageBasico.Controls.Add(this.lblPastaSelecionada);
            this.tabPageBasico.Controls.Add(this.btnRenomear);
            this.tabPageBasico.Controls.Add(this.lblExtensao);
            this.tabPageBasico.Controls.Add(this.grpEstilo);
            this.tabPageBasico.Controls.Add(this.txtExtensao);
            this.tabPageBasico.Controls.Add(this.lblTrechos);
            this.tabPageBasico.Controls.Add(this.btnSelecionaPasta);
            this.tabPageBasico.Controls.Add(this.lblPara3);
            this.tabPageBasico.Controls.Add(this.txtPastaSelecionada);
            this.tabPageBasico.Controls.Add(this.lblPara2);
            this.tabPageBasico.Controls.Add(this.txtDe1);
            this.tabPageBasico.Controls.Add(this.lblPara1);
            this.tabPageBasico.Controls.Add(this.txtDe2);
            this.tabPageBasico.Controls.Add(this.lblDe3);
            this.tabPageBasico.Controls.Add(this.txtDe3);
            this.tabPageBasico.Controls.Add(this.lblDe2);
            this.tabPageBasico.Controls.Add(this.txtPara1);
            this.tabPageBasico.Controls.Add(this.lblDe1);
            this.tabPageBasico.Controls.Add(this.txtPara2);
            this.tabPageBasico.Controls.Add(this.txtPara3);
            this.tabPageBasico.Location = new System.Drawing.Point(4, 27);
            this.tabPageBasico.Name = "tabPageBasico";
            this.tabPageBasico.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasico.Size = new System.Drawing.Size(649, 428);
            this.tabPageBasico.TabIndex = 0;
            this.tabPageBasico.Text = "  Básico  ";
            this.tabPageBasico.UseVisualStyleBackColor = true;
            // 
            // btnLimparBasico
            // 
            this.btnLimparBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnLimparBasico.Location = new System.Drawing.Point(489, 360);
            this.btnLimparBasico.Name = "btnLimparBasico";
            this.btnLimparBasico.Size = new System.Drawing.Size(108, 49);
            this.btnLimparBasico.TabIndex = 30;
            this.btnLimparBasico.Text = "Limpar";
            this.btnLimparBasico.UseVisualStyleBackColor = true;
            this.btnLimparBasico.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chkSubPastas
            // 
            this.chkSubPastas.AutoSize = true;
            this.chkSubPastas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.chkSubPastas.Location = new System.Drawing.Point(495, 68);
            this.chkSubPastas.Name = "chkSubPastas";
            this.chkSubPastas.Size = new System.Drawing.Size(141, 22);
            this.chkSubPastas.TabIndex = 3;
            this.chkSubPastas.Text = "Incluir SubPastas";
            this.chkSubPastas.UseVisualStyleBackColor = true;
            // 
            // btnPreVisualizarBasico
            // 
            this.btnPreVisualizarBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnPreVisualizarBasico.Location = new System.Drawing.Point(489, 305);
            this.btnPreVisualizarBasico.Name = "btnPreVisualizarBasico";
            this.btnPreVisualizarBasico.Size = new System.Drawing.Size(108, 49);
            this.btnPreVisualizarBasico.TabIndex = 27;
            this.btnPreVisualizarBasico.Text = "Pré-Visualizar";
            this.btnPreVisualizarBasico.UseVisualStyleBackColor = true;
            this.btnPreVisualizarBasico.Click += new System.EventHandler(this.btnPreVisualizarBasico_Click);
            // 
            // tabPageAvancado
            // 
            this.tabPageAvancado.Controls.Add(this.grpBlocoDeNotas);
            this.tabPageAvancado.Controls.Add(this.grpOpcoesAvancadas);
            this.tabPageAvancado.Controls.Add(this.lblManipulacao);
            this.tabPageAvancado.Location = new System.Drawing.Point(4, 27);
            this.tabPageAvancado.Name = "tabPageAvancado";
            this.tabPageAvancado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAvancado.Size = new System.Drawing.Size(649, 428);
            this.tabPageAvancado.TabIndex = 1;
            this.tabPageAvancado.Text = "  Avançado  ";
            this.tabPageAvancado.UseVisualStyleBackColor = true;
            // 
            // grpBlocoDeNotas
            // 
            this.grpBlocoDeNotas.Controls.Add(this.btnPreVisualizarTxt);
            this.grpBlocoDeNotas.Controls.Add(this.btnSelecionaTxt);
            this.grpBlocoDeNotas.Controls.Add(this.btnExecutaTxt);
            this.grpBlocoDeNotas.Controls.Add(this.txtEnderecoBlocDeNot);
            this.grpBlocoDeNotas.Controls.Add(this.lblEnderecoBlocDeNot);
            this.grpBlocoDeNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.grpBlocoDeNotas.Location = new System.Drawing.Point(25, 290);
            this.grpBlocoDeNotas.Name = "grpBlocoDeNotas";
            this.grpBlocoDeNotas.Size = new System.Drawing.Size(603, 130);
            this.grpBlocoDeNotas.TabIndex = 16;
            this.grpBlocoDeNotas.TabStop = false;
            this.grpBlocoDeNotas.Text = "Extrair Nomes A Partir De Um Bloco de Notas";
            // 
            // btnPreVisualizarTxt
            // 
            this.btnPreVisualizarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnPreVisualizarTxt.Location = new System.Drawing.Point(365, 78);
            this.btnPreVisualizarTxt.Name = "btnPreVisualizarTxt";
            this.btnPreVisualizarTxt.Size = new System.Drawing.Size(112, 37);
            this.btnPreVisualizarTxt.TabIndex = 20;
            this.btnPreVisualizarTxt.Text = "Pré-Visualizar";
            this.btnPreVisualizarTxt.UseVisualStyleBackColor = true;
            this.btnPreVisualizarTxt.Click += new System.EventHandler(this.btnPreVisualizarTxt_Click);
            // 
            // btnSelecionaTxt
            // 
            this.btnSelecionaTxt.Location = new System.Drawing.Point(485, 30);
            this.btnSelecionaTxt.Name = "btnSelecionaTxt";
            this.btnSelecionaTxt.Size = new System.Drawing.Size(112, 37);
            this.btnSelecionaTxt.TabIndex = 23;
            this.btnSelecionaTxt.Text = "Selecionar .txt";
            this.btnSelecionaTxt.UseVisualStyleBackColor = true;
            this.btnSelecionaTxt.Click += new System.EventHandler(this.btnSelecionaTxt_Click);
            // 
            // btnExecutaTxt
            // 
            this.btnExecutaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnExecutaTxt.Location = new System.Drawing.Point(485, 78);
            this.btnExecutaTxt.Name = "btnExecutaTxt";
            this.btnExecutaTxt.Size = new System.Drawing.Size(112, 37);
            this.btnExecutaTxt.TabIndex = 2;
            this.btnExecutaTxt.Text = "Aplicar";
            this.btnExecutaTxt.UseVisualStyleBackColor = true;
            this.btnExecutaTxt.Click += new System.EventHandler(this.btnExecutaTxt_Click);
            // 
            // txtEnderecoBlocDeNot
            // 
            this.txtEnderecoBlocDeNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEnderecoBlocDeNot.Location = new System.Drawing.Point(204, 36);
            this.txtEnderecoBlocDeNot.Name = "txtEnderecoBlocDeNot";
            this.txtEnderecoBlocDeNot.ReadOnly = true;
            this.txtEnderecoBlocDeNot.Size = new System.Drawing.Size(273, 24);
            this.txtEnderecoBlocDeNot.TabIndex = 1;
            // 
            // lblEnderecoBlocDeNot
            // 
            this.lblEnderecoBlocDeNot.AutoSize = true;
            this.lblEnderecoBlocDeNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblEnderecoBlocDeNot.Location = new System.Drawing.Point(15, 39);
            this.lblEnderecoBlocDeNot.Name = "lblEnderecoBlocDeNot";
            this.lblEnderecoBlocDeNot.Size = new System.Drawing.Size(183, 18);
            this.lblEnderecoBlocDeNot.TabIndex = 0;
            this.lblEnderecoBlocDeNot.Text = "Endereço Bloco de Notas:";
            // 
            // grpOpcoesAvancadas
            // 
            this.grpOpcoesAvancadas.Controls.Add(this.txtRemove);
            this.grpOpcoesAvancadas.Controls.Add(this.label5);
            this.grpOpcoesAvancadas.Controls.Add(this.btnLimparAvancado);
            this.grpOpcoesAvancadas.Controls.Add(this.btnPreVisualizarAvancado);
            this.grpOpcoesAvancadas.Controls.Add(this.mskApos);
            this.grpOpcoesAvancadas.Controls.Add(this.mskAo);
            this.grpOpcoesAvancadas.Controls.Add(this.mskDo);
            this.grpOpcoesAvancadas.Controls.Add(this.btnRenomearAvancado);
            this.grpOpcoesAvancadas.Controls.Add(this.lblApaga);
            this.grpOpcoesAvancadas.Controls.Add(this.txtAcrescentarFim);
            this.grpOpcoesAvancadas.Controls.Add(this.lblAcrescentarFim);
            this.grpOpcoesAvancadas.Controls.Add(this.lblAo);
            this.grpOpcoesAvancadas.Controls.Add(this.txtAcrescentarInicio);
            this.grpOpcoesAvancadas.Controls.Add(this.lblAcrescentarInicio);
            this.grpOpcoesAvancadas.Controls.Add(this.lblCaracter1);
            this.grpOpcoesAvancadas.Controls.Add(this.lblAcrescentar);
            this.grpOpcoesAvancadas.Controls.Add(this.lblCaracter2);
            this.grpOpcoesAvancadas.Controls.Add(this.txtAcrescentarTrecho);
            this.grpOpcoesAvancadas.Controls.Add(this.lblApos);
            this.grpOpcoesAvancadas.Location = new System.Drawing.Point(24, 35);
            this.grpOpcoesAvancadas.Name = "grpOpcoesAvancadas";
            this.grpOpcoesAvancadas.Size = new System.Drawing.Size(604, 249);
            this.grpOpcoesAvancadas.TabIndex = 15;
            this.grpOpcoesAvancadas.TabStop = false;
            // 
            // txtRemove
            // 
            this.txtRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtRemove.Location = new System.Drawing.Point(309, 165);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(267, 24);
            this.txtRemove.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(16, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Remover  ocorrências  do trecho:";
            // 
            // btnLimparAvancado
            // 
            this.btnLimparAvancado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnLimparAvancado.Location = new System.Drawing.Point(250, 206);
            this.btnLimparAvancado.Name = "btnLimparAvancado";
            this.btnLimparAvancado.Size = new System.Drawing.Size(112, 37);
            this.btnLimparAvancado.TabIndex = 20;
            this.btnLimparAvancado.Text = "Limpar";
            this.btnLimparAvancado.UseVisualStyleBackColor = true;
            this.btnLimparAvancado.Click += new System.EventHandler(this.btnLimparAvancado_Click);
            // 
            // btnPreVisualizarAvancado
            // 
            this.btnPreVisualizarAvancado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnPreVisualizarAvancado.Location = new System.Drawing.Point(368, 206);
            this.btnPreVisualizarAvancado.Name = "btnPreVisualizarAvancado";
            this.btnPreVisualizarAvancado.Size = new System.Drawing.Size(112, 37);
            this.btnPreVisualizarAvancado.TabIndex = 19;
            this.btnPreVisualizarAvancado.Text = "Pré-Visualizar";
            this.btnPreVisualizarAvancado.UseVisualStyleBackColor = true;
            this.btnPreVisualizarAvancado.Click += new System.EventHandler(this.btnPreVisualizarAvancado_Click);
            // 
            // mskApos
            // 
            this.mskApos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mskApos.Location = new System.Drawing.Point(428, 52);
            this.mskApos.Mask = "00000";
            this.mskApos.Name = "mskApos";
            this.mskApos.Size = new System.Drawing.Size(48, 24);
            this.mskApos.TabIndex = 19;
            this.mskApos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskApos.ValidatingType = typeof(int);
            // 
            // mskAo
            // 
            this.mskAo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mskAo.Location = new System.Drawing.Point(187, 15);
            this.mskAo.Mask = "00000";
            this.mskAo.Name = "mskAo";
            this.mskAo.Size = new System.Drawing.Size(48, 24);
            this.mskAo.TabIndex = 17;
            this.mskAo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskAo.ValidatingType = typeof(int);
            // 
            // mskDo
            // 
            this.mskDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mskDo.Location = new System.Drawing.Point(98, 15);
            this.mskDo.Mask = "00000";
            this.mskDo.Name = "mskDo";
            this.mskDo.Size = new System.Drawing.Size(48, 24);
            this.mskDo.TabIndex = 16;
            this.mskDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDo.ValidatingType = typeof(int);
            // 
            // btnRenomearAvancado
            // 
            this.btnRenomearAvancado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnRenomearAvancado.Location = new System.Drawing.Point(486, 206);
            this.btnRenomearAvancado.Name = "btnRenomearAvancado";
            this.btnRenomearAvancado.Size = new System.Drawing.Size(112, 37);
            this.btnRenomearAvancado.TabIndex = 15;
            this.btnRenomearAvancado.Text = "Aplicar";
            this.btnRenomearAvancado.UseVisualStyleBackColor = true;
            this.btnRenomearAvancado.Click += new System.EventHandler(this.btnRenomearAvancado_Click);
            // 
            // lblApaga
            // 
            this.lblApaga.AutoSize = true;
            this.lblApaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblApaga.Location = new System.Drawing.Point(16, 18);
            this.lblApaga.Name = "lblApaga";
            this.lblApaga.Size = new System.Drawing.Size(79, 18);
            this.lblApaga.TabIndex = 1;
            this.lblApaga.Text = "Apagar  do";
            // 
            // txtAcrescentarFim
            // 
            this.txtAcrescentarFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtAcrescentarFim.Location = new System.Drawing.Point(308, 129);
            this.txtAcrescentarFim.Name = "txtAcrescentarFim";
            this.txtAcrescentarFim.Size = new System.Drawing.Size(267, 24);
            this.txtAcrescentarFim.TabIndex = 21;
            // 
            // lblAcrescentarFim
            // 
            this.lblAcrescentarFim.AutoSize = true;
            this.lblAcrescentarFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAcrescentarFim.Location = new System.Drawing.Point(15, 132);
            this.lblAcrescentarFim.Name = "lblAcrescentarFim";
            this.lblAcrescentarFim.Size = new System.Drawing.Size(273, 18);
            this.lblAcrescentarFim.TabIndex = 13;
            this.lblAcrescentarFim.Text = "Trecho a acrescentar  no  fim do  nome:";
            // 
            // lblAo
            // 
            this.lblAo.AutoSize = true;
            this.lblAo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAo.Location = new System.Drawing.Point(144, 18);
            this.lblAo.Name = "lblAo";
            this.lblAo.Size = new System.Drawing.Size(42, 18);
            this.lblAo.TabIndex = 3;
            this.lblAo.Text = " º  ao";
            // 
            // txtAcrescentarInicio
            // 
            this.txtAcrescentarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtAcrescentarInicio.Location = new System.Drawing.Point(308, 92);
            this.txtAcrescentarInicio.Name = "txtAcrescentarInicio";
            this.txtAcrescentarInicio.Size = new System.Drawing.Size(267, 24);
            this.txtAcrescentarInicio.TabIndex = 20;
            // 
            // lblAcrescentarInicio
            // 
            this.lblAcrescentarInicio.AutoSize = true;
            this.lblAcrescentarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAcrescentarInicio.Location = new System.Drawing.Point(15, 95);
            this.lblAcrescentarInicio.Name = "lblAcrescentarInicio";
            this.lblAcrescentarInicio.Size = new System.Drawing.Size(291, 18);
            this.lblAcrescentarInicio.TabIndex = 11;
            this.lblAcrescentarInicio.Text = "Trecho a acrescentar  no  inicio  do nome: ";
            // 
            // lblCaracter1
            // 
            this.lblCaracter1.AutoSize = true;
            this.lblCaracter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCaracter1.Location = new System.Drawing.Point(239, 18);
            this.lblCaracter1.Name = "lblCaracter1";
            this.lblCaracter1.Size = new System.Drawing.Size(75, 18);
            this.lblCaracter1.TabIndex = 5;
            this.lblCaracter1.Text = "º  caracter";
            // 
            // lblAcrescentar
            // 
            this.lblAcrescentar.AutoSize = true;
            this.lblAcrescentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAcrescentar.Location = new System.Drawing.Point(15, 56);
            this.lblAcrescentar.Name = "lblAcrescentar";
            this.lblAcrescentar.Size = new System.Drawing.Size(150, 18);
            this.lblAcrescentar.TabIndex = 6;
            this.lblAcrescentar.Text = "Acrescentar o trecho:";
            // 
            // lblCaracter2
            // 
            this.lblCaracter2.AutoSize = true;
            this.lblCaracter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCaracter2.Location = new System.Drawing.Point(482, 55);
            this.lblCaracter2.Name = "lblCaracter2";
            this.lblCaracter2.Size = new System.Drawing.Size(75, 18);
            this.lblCaracter2.TabIndex = 9;
            this.lblCaracter2.Text = "º  caracter";
            // 
            // txtAcrescentarTrecho
            // 
            this.txtAcrescentarTrecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtAcrescentarTrecho.Location = new System.Drawing.Point(165, 52);
            this.txtAcrescentarTrecho.Name = "txtAcrescentarTrecho";
            this.txtAcrescentarTrecho.Size = new System.Drawing.Size(202, 24);
            this.txtAcrescentarTrecho.TabIndex = 18;
            // 
            // lblApos
            // 
            this.lblApos.AutoSize = true;
            this.lblApos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblApos.Location = new System.Drawing.Point(370, 55);
            this.lblApos.Name = "lblApos";
            this.lblApos.Size = new System.Drawing.Size(54, 18);
            this.lblApos.TabIndex = 8;
            this.lblApos.Text = "após o";
            // 
            // lblManipulacao
            // 
            this.lblManipulacao.AutoSize = true;
            this.lblManipulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManipulacao.Location = new System.Drawing.Point(21, 15);
            this.lblManipulacao.Name = "lblManipulacao";
            this.lblManipulacao.Size = new System.Drawing.Size(419, 18);
            this.lblManipulacao.TabIndex = 0;
            this.lblManipulacao.Text = "Manipulação avançada de trechos do nome do arquivo";
            // 
            // tabPagePreVisualizacao
            // 
            this.tabPagePreVisualizacao.Controls.Add(this.btnSalvar);
            this.tabPagePreVisualizacao.Controls.Add(this.lblDepois);
            this.tabPagePreVisualizacao.Controls.Add(this.lblAntes);
            this.tabPagePreVisualizacao.Controls.Add(this.lstDepois);
            this.tabPagePreVisualizacao.Controls.Add(this.lstAntes);
            this.tabPagePreVisualizacao.Location = new System.Drawing.Point(4, 27);
            this.tabPagePreVisualizacao.Name = "tabPagePreVisualizacao";
            this.tabPagePreVisualizacao.Size = new System.Drawing.Size(649, 428);
            this.tabPagePreVisualizacao.TabIndex = 2;
            this.tabPagePreVisualizacao.Text = "  Pré-Visualização  ";
            this.tabPagePreVisualizacao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSalvar.Location = new System.Drawing.Point(266, 14);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 29);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar Lista";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDepois
            // 
            this.lblDepois.AutoSize = true;
            this.lblDepois.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDepois.Location = new System.Drawing.Point(451, 25);
            this.lblDepois.Name = "lblDepois";
            this.lblDepois.Size = new System.Drawing.Size(55, 18);
            this.lblDepois.TabIndex = 3;
            this.lblDepois.Text = "Depois";
            // 
            // lblAntes
            // 
            this.lblAntes.AutoSize = true;
            this.lblAntes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntes.Location = new System.Drawing.Point(142, 25);
            this.lblAntes.Name = "lblAntes";
            this.lblAntes.Size = new System.Drawing.Size(45, 18);
            this.lblAntes.TabIndex = 2;
            this.lblAntes.Text = "Antes";
            // 
            // lstDepois
            // 
            this.lstDepois.FormattingEnabled = true;
            this.lstDepois.HorizontalScrollbar = true;
            this.lstDepois.ItemHeight = 18;
            this.lstDepois.Location = new System.Drawing.Point(331, 53);
            this.lstDepois.Name = "lstDepois";
            this.lstDepois.Size = new System.Drawing.Size(305, 364);
            this.lstDepois.TabIndex = 1;
            this.lstDepois.SelectedIndexChanged += new System.EventHandler(this.lstDepois_SelectedIndexChanged);
            // 
            // lstAntes
            // 
            this.lstAntes.FormattingEnabled = true;
            this.lstAntes.HorizontalScrollbar = true;
            this.lstAntes.ItemHeight = 18;
            this.lstAntes.Location = new System.Drawing.Point(14, 53);
            this.lstAntes.Name = "lstAntes";
            this.lstAntes.Size = new System.Drawing.Size(305, 364);
            this.lstAntes.TabIndex = 0;
            this.lstAntes.SelectedIndexChanged += new System.EventHandler(this.lstAntes_SelectedIndexChanged);
            // 
            // tabPageSobre
            // 
            this.tabPageSobre.Controls.Add(this.lnlCopyRight);
            this.tabPageSobre.Controls.Add(this.groupBox1);
            this.tabPageSobre.Location = new System.Drawing.Point(4, 27);
            this.tabPageSobre.Name = "tabPageSobre";
            this.tabPageSobre.Size = new System.Drawing.Size(649, 428);
            this.tabPageSobre.TabIndex = 3;
            this.tabPageSobre.Text = "  Sobre  ";
            this.tabPageSobre.UseVisualStyleBackColor = true;
            // 
            // lnlCopyRight
            // 
            this.lnlCopyRight.AutoSize = true;
            this.lnlCopyRight.Location = new System.Drawing.Point(216, 400);
            this.lnlCopyRight.Name = "lnlCopyRight";
            this.lnlCopyRight.Size = new System.Drawing.Size(425, 18);
            this.lnlCopyRight.TabIndex = 1;
            this.lnlCopyRight.Text = "Todos os direitos reservados © 2014 Leandro Fernandes Vieira";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(68, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Renomeeitor.Properties.Resources.C_;
            this.pictureBox1.Location = new System.Drawing.Point(417, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 93);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(89, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "  leandromoh@hotmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(128, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail para Contato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leandro Fernandes Vieira";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desenvolvido Por:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblIdioma.Location = new System.Drawing.Point(415, 5);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(84, 18);
            this.lblIdioma.TabIndex = 28;
            this.lblIdioma.Text = "Linguagem:";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Português (Brasil)",
            "English"});
            this.cmbIdioma.Location = new System.Drawing.Point(498, 4);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cmbIdioma.TabIndex = 29;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 466);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renomeeitor 3.7.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEstilo.ResumeLayout(false);
            this.grpEstilo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageBasico.ResumeLayout(false);
            this.tabPageBasico.PerformLayout();
            this.tabPageAvancado.ResumeLayout(false);
            this.tabPageAvancado.PerformLayout();
            this.grpBlocoDeNotas.ResumeLayout(false);
            this.grpBlocoDeNotas.PerformLayout();
            this.grpOpcoesAvancadas.ResumeLayout(false);
            this.grpOpcoesAvancadas.PerformLayout();
            this.tabPagePreVisualizacao.ResumeLayout(false);
            this.tabPagePreVisualizacao.PerformLayout();
            this.tabPageSobre.ResumeLayout(false);
            this.tabPageSobre.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExtensao;
        private System.Windows.Forms.TextBox txtExtensao;
        private System.Windows.Forms.Button btnSelecionaPasta;
        private System.Windows.Forms.Label lblPastaSelecionada;
        private System.Windows.Forms.TextBox txtPastaSelecionada;
        private System.Windows.Forms.TextBox txtDe1;
        private System.Windows.Forms.TextBox txtDe2;
        private System.Windows.Forms.TextBox txtDe3;
        private System.Windows.Forms.TextBox txtPara1;
        private System.Windows.Forms.TextBox txtPara2;
        private System.Windows.Forms.TextBox txtPara3;
        private System.Windows.Forms.Label lblDe1;
        private System.Windows.Forms.Label lblDe2;
        private System.Windows.Forms.Label lblDe3;
        private System.Windows.Forms.Label lblPara1;
        private System.Windows.Forms.Label lblPara2;
        private System.Windows.Forms.Label lblPara3;
        private System.Windows.Forms.Label lblTrechos;
        private System.Windows.Forms.RadioButton rbtFalse;
        private System.Windows.Forms.RadioButton rbtToUpper;
        private System.Windows.Forms.RadioButton rbtToLower;
        private System.Windows.Forms.RadioButton rbtUcWords;
        private System.Windows.Forms.RadioButton rbtUcFirst;
        private System.Windows.Forms.GroupBox grpEstilo;
        private System.Windows.Forms.Button btnRenomear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBasico;
        private System.Windows.Forms.TabPage tabPageAvancado;
        private System.Windows.Forms.TextBox txtAcrescentarFim;
        private System.Windows.Forms.Label lblAcrescentarFim;
        private System.Windows.Forms.TextBox txtAcrescentarInicio;
        private System.Windows.Forms.Label lblAcrescentarInicio;
        private System.Windows.Forms.Label lblCaracter2;
        private System.Windows.Forms.Label lblApos;
        private System.Windows.Forms.TextBox txtAcrescentarTrecho;
        private System.Windows.Forms.Label lblAcrescentar;
        private System.Windows.Forms.Label lblCaracter1;
        private System.Windows.Forms.Label lblAo;
        private System.Windows.Forms.Label lblApaga;
        private System.Windows.Forms.Label lblManipulacao;
        private System.Windows.Forms.GroupBox grpOpcoesAvancadas;
        private System.Windows.Forms.GroupBox grpBlocoDeNotas;
        private System.Windows.Forms.Button btnSelecionaTxt;
        private System.Windows.Forms.Button btnExecutaTxt;
        private System.Windows.Forms.TextBox txtEnderecoBlocDeNot;
        private System.Windows.Forms.Label lblEnderecoBlocDeNot;
        private System.Windows.Forms.Button btnRenomearAvancado;
        private System.Windows.Forms.MaskedTextBox mskDo;
        private System.Windows.Forms.MaskedTextBox mskApos;
        private System.Windows.Forms.MaskedTextBox mskAo;
        private System.Windows.Forms.TabPage tabPagePreVisualizacao;
        private System.Windows.Forms.TabPage tabPageSobre;
        private System.Windows.Forms.Label lblDepois;
        private System.Windows.Forms.Label lblAntes;
        private System.Windows.Forms.ListBox lstDepois;
        private System.Windows.Forms.ListBox lstAntes;
        private System.Windows.Forms.Button btnPreVisualizarBasico;
        private System.Windows.Forms.Button btnPreVisualizarAvancado;
        private System.Windows.Forms.Button btnPreVisualizarTxt;
        private System.Windows.Forms.CheckBox chkSubPastas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimparBasico;
        private System.Windows.Forms.Button btnLimparAvancado;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lnlCopyRight;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
    }
}

