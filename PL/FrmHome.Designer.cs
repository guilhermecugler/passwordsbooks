namespace PL
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnMenuSair = new System.Windows.Forms.Button();
            this.panelSubMenuCadastros = new System.Windows.Forms.Panel();
            this.btnSites = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuCadastros.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnMenuSair);
            this.panelSideMenu.Controls.Add(this.panelSubMenuCadastros);
            this.panelSideMenu.Controls.Add(this.btnCadastros);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 562);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnMenuSair
            // 
            this.btnMenuSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSair.FlatAppearance.BorderSize = 0;
            this.btnMenuSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSair.ForeColor = System.Drawing.Color.Silver;
            this.btnMenuSair.Image = global::PL.Properties.Resources.logout;
            this.btnMenuSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSair.Location = new System.Drawing.Point(0, 231);
            this.btnMenuSair.Name = "btnMenuSair";
            this.btnMenuSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenuSair.Size = new System.Drawing.Size(250, 45);
            this.btnMenuSair.TabIndex = 3;
            this.btnMenuSair.Text = "     Sair";
            this.btnMenuSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuSair.UseVisualStyleBackColor = true;
            this.btnMenuSair.Click += new System.EventHandler(this.btnMenuSair_Click);
            // 
            // panelSubMenuCadastros
            // 
            this.panelSubMenuCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuCadastros.Controls.Add(this.btnSites);
            this.panelSubMenuCadastros.Controls.Add(this.btnClientes);
            this.panelSubMenuCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCadastros.Location = new System.Drawing.Point(0, 140);
            this.panelSubMenuCadastros.Name = "panelSubMenuCadastros";
            this.panelSubMenuCadastros.Size = new System.Drawing.Size(250, 91);
            this.panelSubMenuCadastros.TabIndex = 2;
            // 
            // btnSites
            // 
            this.btnSites.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSites.FlatAppearance.BorderSize = 0;
            this.btnSites.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSites.ForeColor = System.Drawing.Color.Silver;
            this.btnSites.Image = global::PL.Properties.Resources.sites;
            this.btnSites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSites.Location = new System.Drawing.Point(0, 40);
            this.btnSites.Name = "btnSites";
            this.btnSites.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSites.Size = new System.Drawing.Size(250, 40);
            this.btnSites.TabIndex = 1;
            this.btnSites.Text = "     Sites/Tipos";
            this.btnSites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSites.UseVisualStyleBackColor = true;
            this.btnSites.Click += new System.EventHandler(this.btnSites_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.Silver;
            this.btnClientes.Image = global::PL.Properties.Resources.clientes;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(250, 40);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "     Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.ForeColor = System.Drawing.Color.Silver;
            this.btnCadastros.Image = global::PL.Properties.Resources.cadastros;
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.Location = new System.Drawing.Point(0, 95);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastros.Size = new System.Drawing.Size(250, 45);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "      Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 95);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 562);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PL.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(146, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::PL.Properties.Resources.logo_loverbeck_white;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordsBook";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenuCadastros.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMenuCadastros;
        private System.Windows.Forms.Button btnSites;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnMenuSair;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}