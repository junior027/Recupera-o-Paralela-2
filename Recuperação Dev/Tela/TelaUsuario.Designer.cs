namespace Tela
{
    partial class TelaUsuario
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
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.gbNovoUsuario = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.gvUsuario = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNovoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(88, 23);
            this.btnNovoUsuario.TabIndex = 0;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // gbNovoUsuario
            // 
            this.gbNovoUsuario.Controls.Add(this.btnCadastrar);
            this.gbNovoUsuario.Controls.Add(this.label6);
            this.gbNovoUsuario.Controls.Add(this.txtEmpresa);
            this.gbNovoUsuario.Controls.Add(this.label3);
            this.gbNovoUsuario.Controls.Add(this.txtCargo);
            this.gbNovoUsuario.Controls.Add(this.txtTelefone);
            this.gbNovoUsuario.Controls.Add(this.txtCep);
            this.gbNovoUsuario.Controls.Add(this.txtEmail);
            this.gbNovoUsuario.Controls.Add(this.txtNome);
            this.gbNovoUsuario.Controls.Add(this.label5);
            this.gbNovoUsuario.Controls.Add(this.label4);
            this.gbNovoUsuario.Controls.Add(this.label2);
            this.gbNovoUsuario.Controls.Add(this.label1);
            this.gbNovoUsuario.Location = new System.Drawing.Point(23, 77);
            this.gbNovoUsuario.Name = "gbNovoUsuario";
            this.gbNovoUsuario.Size = new System.Drawing.Size(646, 205);
            this.gbNovoUsuario.TabIndex = 1;
            this.gbNovoUsuario.TabStop = false;
            this.gbNovoUsuario.Text = "Novo Usuário";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(552, 176);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Empresa";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(298, 95);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtEmpresa.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(298, 44);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(162, 95);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 8;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(22, 95);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Location = new System.Drawing.Point(700, 271);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(88, 23);
            this.btnRecarregar.TabIndex = 13;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            // 
            // gvUsuario
            // 
            this.gvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.gvUsuario.Location = new System.Drawing.Point(4, 300);
            this.gvUsuario.Name = "gvUsuario";
            this.gvUsuario.Size = new System.Drawing.Size(784, 150);
            this.gvUsuario.TabIndex = 14;
            this.gvUsuario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvUsuario_CellMouseClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Excluir";
            this.Deletar.Name = "Deletar";
            // 
            // TelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvUsuario);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.gbNovoUsuario);
            this.Controls.Add(this.btnNovoUsuario);
            this.Name = "TelaUsuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaUsuario_Load);
            this.gbNovoUsuario.ResumeLayout(false);
            this.gbNovoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.GroupBox gbNovoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.DataGridView gvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deletar;
    }
}

