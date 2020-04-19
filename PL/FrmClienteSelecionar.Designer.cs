namespace PL
{
    partial class FrmClienteSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteSelecionar));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSiteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCelular = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSite = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.Silver;
            this.btnFechar.Location = new System.Drawing.Point(571, 521);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 28);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Silver;
            this.btnExcluir.Location = new System.Drawing.Point(449, 521);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.Silver;
            this.btnAlterar.Location = new System.Drawing.Point(328, 521);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 28);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ForeColor = System.Drawing.Color.Silver;
            this.btnIncluir.Location = new System.Drawing.Point(207, 521);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 28);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnSiteNome,
            this.ColumnNome,
            this.ColumnCPF,
            this.ColumnLogin,
            this.ColumnEmail,
            this.ColumnSenha,
            this.ColumnCartao,
            this.ColumnCelular,
            this.ColumnTelefone,
            this.ColumnObs,
            this.ColumnDN,
            this.ColumnEndereco,
            this.ColumnEnderecoNumero,
            this.ColumnEnderecoComplemento,
            this.ColumnEnderecoBairro,
            this.ColumnEnderecoCidade,
            this.ColumnUF,
            this.ColumnAtendente,
            this.ColumnSite});
            this.Grid.Location = new System.Drawing.Point(16, 58);
            this.Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid.Size = new System.Drawing.Size(655, 455);
            this.Grid.TabIndex = 4;
            this.Grid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentDoubleClick);
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.ColumnID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 46;
            // 
            // ColumnSiteNome
            // 
            this.ColumnSiteNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSiteNome.HeaderText = "Site";
            this.ColumnSiteNome.Name = "ColumnSiteNome";
            this.ColumnSiteNome.ReadOnly = true;
            this.ColumnSiteNome.Width = 57;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 70;
            // 
            // ColumnCPF
            // 
            dataGridViewCellStyle3.Format = "000.000.000-00";
            dataGridViewCellStyle3.NullValue = null;
            this.ColumnCPF.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnCPF.HeaderText = "CPF";
            this.ColumnCPF.Name = "ColumnCPF";
            this.ColumnCPF.ReadOnly = true;
            this.ColumnCPF.Width = 59;
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.HeaderText = "Login/Usuário";
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.ReadOnly = true;
            this.ColumnLogin.Width = 121;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "E-mail";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEmail.Width = 72;
            // 
            // ColumnSenha
            // 
            this.ColumnSenha.HeaderText = "Senha";
            this.ColumnSenha.Name = "ColumnSenha";
            this.ColumnSenha.ReadOnly = true;
            this.ColumnSenha.Width = 74;
            // 
            // ColumnCartao
            // 
            this.ColumnCartao.HeaderText = "Cartão";
            this.ColumnCartao.Name = "ColumnCartao";
            this.ColumnCartao.ReadOnly = true;
            this.ColumnCartao.Width = 75;
            // 
            // ColumnCelular
            // 
            this.ColumnCelular.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnCelular.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnCelular.HeaderText = "Celular";
            this.ColumnCelular.LinkColor = System.Drawing.Color.Green;
            this.ColumnCelular.Name = "ColumnCelular";
            this.ColumnCelular.ReadOnly = true;
            this.ColumnCelular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCelular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCelular.ToolTipText = "Clique para enviar mensagem via WhatsApp";
            this.ColumnCelular.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ColumnCelular.Width = 77;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            this.ColumnTelefone.Width = 89;
            // 
            // ColumnObs
            // 
            this.ColumnObs.HeaderText = "Observação";
            this.ColumnObs.Name = "ColumnObs";
            this.ColumnObs.ReadOnly = true;
            this.ColumnObs.Width = 110;
            // 
            // ColumnDN
            // 
            this.ColumnDN.HeaderText = "Data de Nascimento";
            this.ColumnDN.Name = "ColumnDN";
            this.ColumnDN.ReadOnly = true;
            this.ColumnDN.Width = 147;
            // 
            // ColumnEndereco
            // 
            this.ColumnEndereco.HeaderText = "Endereço";
            this.ColumnEndereco.Name = "ColumnEndereco";
            this.ColumnEndereco.ReadOnly = true;
            this.ColumnEndereco.Width = 94;
            // 
            // ColumnEnderecoNumero
            // 
            this.ColumnEnderecoNumero.HeaderText = "Número";
            this.ColumnEnderecoNumero.Name = "ColumnEnderecoNumero";
            this.ColumnEnderecoNumero.ReadOnly = true;
            this.ColumnEnderecoNumero.Width = 83;
            // 
            // ColumnEnderecoComplemento
            // 
            this.ColumnEnderecoComplemento.HeaderText = "Complemento";
            this.ColumnEnderecoComplemento.Name = "ColumnEnderecoComplemento";
            this.ColumnEnderecoComplemento.ReadOnly = true;
            this.ColumnEnderecoComplemento.Width = 119;
            // 
            // ColumnEnderecoBairro
            // 
            this.ColumnEnderecoBairro.HeaderText = "Bairro";
            this.ColumnEnderecoBairro.Name = "ColumnEnderecoBairro";
            this.ColumnEnderecoBairro.ReadOnly = true;
            this.ColumnEnderecoBairro.Width = 71;
            // 
            // ColumnEnderecoCidade
            // 
            this.ColumnEnderecoCidade.HeaderText = "Cidade";
            this.ColumnEnderecoCidade.Name = "ColumnEnderecoCidade";
            this.ColumnEnderecoCidade.ReadOnly = true;
            this.ColumnEnderecoCidade.Width = 77;
            // 
            // ColumnUF
            // 
            this.ColumnUF.HeaderText = "UF";
            this.ColumnUF.Name = "ColumnUF";
            this.ColumnUF.ReadOnly = true;
            this.ColumnUF.Width = 51;
            // 
            // ColumnAtendente
            // 
            this.ColumnAtendente.HeaderText = "Atendente";
            this.ColumnAtendente.Name = "ColumnAtendente";
            this.ColumnAtendente.ReadOnly = true;
            this.ColumnAtendente.Width = 98;
            // 
            // ColumnSite
            // 
            this.ColumnSite.HeaderText = "Link/Site";
            this.ColumnSite.Name = "ColumnSite";
            this.ColumnSite.ReadOnly = true;
            this.ColumnSite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnSite.Width = 87;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(16, 27);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(325, 23);
            this.txtPesquisar.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.Silver;
            this.btnPesquisar.Location = new System.Drawing.Point(571, 24);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cliente/Telefone/CPF/Cartão:";
            // 
            // cbTipo
            // 
            this.cbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(349, 27);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(214, 24);
            this.cbTipo.TabIndex = 2;
            this.cbTipo.MouseEnter += new System.EventHandler(this.cbTipo_MouseEnter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(346, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tipo/Site:";
            // 
            // FrmClienteSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSiteNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCartao;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnderecoNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnderecoComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnderecoBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnderecoCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtendente;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnSite;
    }
}