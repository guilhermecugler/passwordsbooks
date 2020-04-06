namespace PL
{
    partial class FrmClienteCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteCadastrar));
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskClienteCPF = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskAdicional = new System.Windows.Forms.MaskedTextBox();
            this.mskClienteTelCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskClienteTel = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteLogradouro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClienteNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClienteBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClienteComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClienteUF = new System.Windows.Forms.ComboBox();
            this.txtClienteCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClienteTipoCadastro = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtClienteLogin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtClienteEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtClienteSenha = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtClienteObs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClienteAtendente = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtClienteLinkSite = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.mskClienteDN = new System.Windows.Forms.MaskedTextBox();
            this.mskClienteCartao = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNome.Location = new System.Drawing.Point(9, 67);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(359, 22);
            this.txtClienteNome.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // mskClienteCPF
            // 
            this.mskClienteCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskClienteCPF.Location = new System.Drawing.Point(9, 148);
            this.mskClienteCPF.Mask = "000,000,000-00";
            this.mskClienteCPF.Name = "mskClienteCPF";
            this.mskClienteCPF.Size = new System.Drawing.Size(167, 22);
            this.mskClienteCPF.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "CPF";
            // 
            // mskAdicional
            // 
            this.mskAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAdicional.Location = new System.Drawing.Point(268, 235);
            this.mskAdicional.Mask = "(99) 00000-0000";
            this.mskAdicional.Name = "mskAdicional";
            this.mskAdicional.Size = new System.Drawing.Size(100, 22);
            this.mskAdicional.TabIndex = 30;
            // 
            // mskClienteTelCelular
            // 
            this.mskClienteTelCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskClienteTelCelular.Location = new System.Drawing.Point(143, 238);
            this.mskClienteTelCelular.Mask = "(99) 00000-0000";
            this.mskClienteTelCelular.Name = "mskClienteTelCelular";
            this.mskClienteTelCelular.Size = new System.Drawing.Size(101, 22);
            this.mskClienteTelCelular.TabIndex = 29;
            // 
            // mskClienteTel
            // 
            this.mskClienteTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskClienteTel.Location = new System.Drawing.Point(9, 238);
            this.mskClienteTel.Mask = "(99) 0000-0000";
            this.mskClienteTel.Name = "mskClienteTel";
            this.mskClienteTel.Size = new System.Drawing.Size(110, 22);
            this.mskClienteTel.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Adicional";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtClienteLogradouro
            // 
            this.txtClienteLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteLogradouro.Location = new System.Drawing.Point(9, 290);
            this.txtClienteLogradouro.Name = "txtClienteLogradouro";
            this.txtClienteLogradouro.Size = new System.Drawing.Size(359, 22);
            this.txtClienteLogradouro.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Endereço";
            // 
            // txtClienteNumero
            // 
            this.txtClienteNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNumero.Location = new System.Drawing.Point(9, 334);
            this.txtClienteNumero.Name = "txtClienteNumero";
            this.txtClienteNumero.Size = new System.Drawing.Size(64, 22);
            this.txtClienteNumero.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Número";
            // 
            // txtClienteBairro
            // 
            this.txtClienteBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteBairro.Location = new System.Drawing.Point(79, 334);
            this.txtClienteBairro.Name = "txtClienteBairro";
            this.txtClienteBairro.Size = new System.Drawing.Size(131, 22);
            this.txtClienteBairro.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Bairro";
            // 
            // txtClienteComplemento
            // 
            this.txtClienteComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteComplemento.Location = new System.Drawing.Point(216, 334);
            this.txtClienteComplemento.Name = "txtClienteComplemento";
            this.txtClienteComplemento.Size = new System.Drawing.Size(152, 22);
            this.txtClienteComplemento.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(213, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Complemento";
            // 
            // txtClienteUF
            // 
            this.txtClienteUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteUF.FormattingEnabled = true;
            this.txtClienteUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.txtClienteUF.Location = new System.Drawing.Point(216, 375);
            this.txtClienteUF.Name = "txtClienteUF";
            this.txtClienteUF.Size = new System.Drawing.Size(152, 24);
            this.txtClienteUF.TabIndex = 45;
            // 
            // txtClienteCidade
            // 
            this.txtClienteCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteCidade.Location = new System.Drawing.Point(9, 377);
            this.txtClienteCidade.Name = "txtClienteCidade";
            this.txtClienteCidade.Size = new System.Drawing.Size(201, 22);
            this.txtClienteCidade.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(216, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "UF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Cidade";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(293, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(202, 543);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 48;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(9, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(64, 22);
            this.txtCodigo.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "Código";
            // 
            // txtClienteTipoCadastro
            // 
            this.txtClienteTipoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteTipoCadastro.FormattingEnabled = true;
            this.txtClienteTipoCadastro.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.txtClienteTipoCadastro.Location = new System.Drawing.Point(89, 21);
            this.txtClienteTipoCadastro.Name = "txtClienteTipoCadastro";
            this.txtClienteTipoCadastro.Size = new System.Drawing.Size(121, 24);
            this.txtClienteTipoCadastro.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(86, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 16);
            this.label14.TabIndex = 52;
            this.label14.Text = "Tipo";
            // 
            // txtClienteLogin
            // 
            this.txtClienteLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteLogin.Location = new System.Drawing.Point(182, 148);
            this.txtClienteLogin.Name = "txtClienteLogin";
            this.txtClienteLogin.Size = new System.Drawing.Size(186, 22);
            this.txtClienteLogin.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(179, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 16);
            this.label15.TabIndex = 54;
            this.label15.Text = "Login/Usuário";
            // 
            // txtClienteEmail
            // 
            this.txtClienteEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEmail.Location = new System.Drawing.Point(9, 109);
            this.txtClienteEmail.Name = "txtClienteEmail";
            this.txtClienteEmail.Size = new System.Drawing.Size(187, 22);
            this.txtClienteEmail.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 16);
            this.label16.TabIndex = 56;
            this.label16.Text = "E-mail";
            // 
            // txtClienteSenha
            // 
            this.txtClienteSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteSenha.Location = new System.Drawing.Point(9, 195);
            this.txtClienteSenha.Name = "txtClienteSenha";
            this.txtClienteSenha.Size = new System.Drawing.Size(167, 22);
            this.txtClienteSenha.TabIndex = 59;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 16);
            this.label17.TabIndex = 58;
            this.label17.Text = "Senha";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(179, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 16);
            this.label18.TabIndex = 60;
            this.label18.Text = "Cartão";
            // 
            // txtClienteObs
            // 
            this.txtClienteObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteObs.Location = new System.Drawing.Point(9, 461);
            this.txtClienteObs.Name = "txtClienteObs";
            this.txtClienteObs.Size = new System.Drawing.Size(359, 22);
            this.txtClienteObs.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Observação";
            // 
            // txtClienteAtendente
            // 
            this.txtClienteAtendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteAtendente.FormattingEnabled = true;
            this.txtClienteAtendente.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.txtClienteAtendente.Location = new System.Drawing.Point(9, 415);
            this.txtClienteAtendente.Name = "txtClienteAtendente";
            this.txtClienteAtendente.Size = new System.Drawing.Size(152, 24);
            this.txtClienteAtendente.TabIndex = 65;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 396);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 16);
            this.label19.TabIndex = 64;
            this.label19.Text = "Atendente";
            // 
            // txtClienteLinkSite
            // 
            this.txtClienteLinkSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteLinkSite.Location = new System.Drawing.Point(167, 417);
            this.txtClienteLinkSite.Name = "txtClienteLinkSite";
            this.txtClienteLinkSite.Size = new System.Drawing.Size(201, 22);
            this.txtClienteLinkSite.TabIndex = 67;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(164, 398);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 16);
            this.label20.TabIndex = 66;
            this.label20.Text = "Link";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(199, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 16);
            this.label21.TabIndex = 69;
            this.label21.Text = "Data de Nascimento";
            // 
            // mskClienteDN
            // 
            this.mskClienteDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskClienteDN.Location = new System.Drawing.Point(202, 109);
            this.mskClienteDN.Mask = "00/00/0000";
            this.mskClienteDN.Name = "mskClienteDN";
            this.mskClienteDN.Size = new System.Drawing.Size(101, 22);
            this.mskClienteDN.TabIndex = 68;
            this.mskClienteDN.ValidatingType = typeof(System.DateTime);
            // 
            // mskClienteCartao
            // 
            this.mskClienteCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskClienteCartao.Location = new System.Drawing.Point(182, 195);
            this.mskClienteCartao.Mask = "0000.0000.0000.0000";
            this.mskClienteCartao.Name = "mskClienteCartao";
            this.mskClienteCartao.Size = new System.Drawing.Size(181, 22);
            this.mskClienteCartao.TabIndex = 70;
            // 
            // FrmClienteCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(375, 578);
            this.Controls.Add(this.mskClienteCartao);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.mskClienteDN);
            this.Controls.Add(this.txtClienteLinkSite);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtClienteAtendente);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtClienteObs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtClienteSenha);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtClienteEmail);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtClienteLogin);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtClienteTipoCadastro);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtClienteUF);
            this.Controls.Add(this.txtClienteCidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtClienteComplemento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtClienteBairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClienteNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtClienteLogradouro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskAdicional);
            this.Controls.Add(this.mskClienteTelCelular);
            this.Controls.Add(this.mskClienteTel);
            this.Controls.Add(this.mskClienteCPF);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtClienteNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskClienteCPF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskAdicional;
        private System.Windows.Forms.MaskedTextBox mskClienteTelCelular;
        private System.Windows.Forms.MaskedTextBox mskClienteTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClienteLogradouro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClienteNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClienteBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClienteComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtClienteUF;
        private System.Windows.Forms.TextBox txtClienteCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtClienteTipoCadastro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtClienteLogin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtClienteEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtClienteSenha;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtClienteObs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtClienteAtendente;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtClienteLinkSite;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox mskClienteDN;
        private System.Windows.Forms.MaskedTextBox mskClienteCartao;
    }
}