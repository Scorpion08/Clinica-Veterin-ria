namespace Clinica_Veterinaria
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.lblnomeDono = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblnomeAnimal = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblidadeAnimal = new System.Windows.Forms.Label();
            this.txtnomeDono = new System.Windows.Forms.TextBox();
            this.txtnomeAnimal = new System.Windows.Forms.TextBox();
            this.txtidadeAnimal = new System.Windows.Forms.TextBox();
            this.cbidadeAnimal = new System.Windows.Forms.ComboBox();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.mtbContato = new System.Windows.Forms.MaskedTextBox();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtqualAnimal = new System.Windows.Forms.TextBox();
            this.lblqualAnimal = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblInsiraId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbSexoAnimal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnomeDono
            // 
            this.lblnomeDono.AutoSize = true;
            this.lblnomeDono.BackColor = System.Drawing.Color.Transparent;
            this.lblnomeDono.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeDono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnomeDono.Location = new System.Drawing.Point(4, 112);
            this.lblnomeDono.Name = "lblnomeDono";
            this.lblnomeDono.Size = new System.Drawing.Size(145, 16);
            this.lblnomeDono.TabIndex = 0;
            this.lblnomeDono.Text = "Nome do dono(a) :";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.Color.Transparent;
            this.lblContato.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContato.Location = new System.Drawing.Point(4, 142);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(162, 16);
            this.lblContato.TabIndex = 1;
            this.lblContato.Text = "Telefone de contato :";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCPF.Location = new System.Drawing.Point(4, 214);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(50, 16);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF :";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.BackColor = System.Drawing.Color.Transparent;
            this.lblRG.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRG.Location = new System.Drawing.Point(4, 184);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(43, 16);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "RG :";
            // 
            // lblnomeAnimal
            // 
            this.lblnomeAnimal.AutoSize = true;
            this.lblnomeAnimal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeAnimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnomeAnimal.Location = new System.Drawing.Point(4, 285);
            this.lblnomeAnimal.Name = "lblnomeAnimal";
            this.lblnomeAnimal.Size = new System.Drawing.Size(137, 16);
            this.lblnomeAnimal.TabIndex = 5;
            this.lblnomeAnimal.Text = "Nome do animal :";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblAnimal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnimal.Location = new System.Drawing.Point(4, 255);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(71, 16);
            this.lblAnimal.TabIndex = 4;
            this.lblAnimal.Text = "Animal :";
            // 
            // lblidadeAnimal
            // 
            this.lblidadeAnimal.AutoSize = true;
            this.lblidadeAnimal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidadeAnimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblidadeAnimal.Location = new System.Drawing.Point(4, 318);
            this.lblidadeAnimal.Name = "lblidadeAnimal";
            this.lblidadeAnimal.Size = new System.Drawing.Size(144, 16);
            this.lblidadeAnimal.TabIndex = 7;
            this.lblidadeAnimal.Text = "Idade do animal :  ";
            // 
            // txtnomeDono
            // 
            this.txtnomeDono.Location = new System.Drawing.Point(152, 111);
            this.txtnomeDono.Name = "txtnomeDono";
            this.txtnomeDono.Size = new System.Drawing.Size(267, 20);
            this.txtnomeDono.TabIndex = 8;
            // 
            // txtnomeAnimal
            // 
            this.txtnomeAnimal.Location = new System.Drawing.Point(147, 284);
            this.txtnomeAnimal.Name = "txtnomeAnimal";
            this.txtnomeAnimal.Size = new System.Drawing.Size(100, 20);
            this.txtnomeAnimal.TabIndex = 9;
            // 
            // txtidadeAnimal
            // 
            this.txtidadeAnimal.Location = new System.Drawing.Point(136, 317);
            this.txtidadeAnimal.Name = "txtidadeAnimal";
            this.txtidadeAnimal.Size = new System.Drawing.Size(30, 20);
            this.txtidadeAnimal.TabIndex = 10;
            // 
            // cbidadeAnimal
            // 
            this.cbidadeAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidadeAnimal.FormattingEnabled = true;
            this.cbidadeAnimal.Items.AddRange(new object[] {
            "Mês",
            "Ano",
            "Meses",
            "Anos"});
            this.cbidadeAnimal.Location = new System.Drawing.Point(178, 317);
            this.cbidadeAnimal.Name = "cbidadeAnimal";
            this.cbidadeAnimal.Size = new System.Drawing.Size(69, 21);
            this.cbidadeAnimal.TabIndex = 11;
            // 
            // cbAnimal
            // 
            this.cbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Items.AddRange(new object[] {
            "Cachorro",
            "Gato",
            "Outros"});
            this.cbAnimal.Location = new System.Drawing.Point(81, 254);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(121, 21);
            this.cbAnimal.TabIndex = 12;
            this.cbAnimal.SelectedIndexChanged += new System.EventHandler(this.cbAnimal_SelectedIndexChanged);
            // 
            // mtbContato
            // 
            this.mtbContato.Location = new System.Drawing.Point(172, 141);
            this.mtbContato.Mask = "(##)####-#####";
            this.mtbContato.Name = "mtbContato";
            this.mtbContato.Size = new System.Drawing.Size(80, 20);
            this.mtbContato.TabIndex = 13;
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(53, 183);
            this.mtbRG.Mask = "##.###.###-#";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(74, 20);
            this.mtbRG.TabIndex = 14;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(60, 213);
            this.mtbCPF.Mask = "###.###.###/##";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(100, 20);
            this.mtbCPF.TabIndex = 15;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastro.Location = new System.Drawing.Point(172, 479);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 37);
            this.btnCadastro.TabIndex = 16;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVisualizar.Location = new System.Drawing.Point(292, 479);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 37);
            this.btnVisualizar.TabIndex = 17;
            this.btnVisualizar.Text = "Visualizar Cadastros";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtualizar.Location = new System.Drawing.Point(398, 479);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 37);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar Cadastro";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletar.Location = new System.Drawing.Point(506, 479);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 37);
            this.btnDeletar.TabIndex = 19;
            this.btnDeletar.Text = "Deletar Cadastro";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(12, 361);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.Size = new System.Drawing.Size(740, 94);
            this.dgvRegistro.TabIndex = 20;
            this.dgvRegistro.Visible = false;
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtualiza.Location = new System.Drawing.Point(677, 63);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(101, 34);
            this.btnAtualiza.TabIndex = 21;
            this.btnAtualiza.Text = "Atualizar";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(702, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 68);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Location = new System.Drawing.Point(677, 103);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 34);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtqualAnimal
            // 
            this.txtqualAnimal.Location = new System.Drawing.Point(355, 254);
            this.txtqualAnimal.Multiline = true;
            this.txtqualAnimal.Name = "txtqualAnimal";
            this.txtqualAnimal.Size = new System.Drawing.Size(170, 21);
            this.txtqualAnimal.TabIndex = 24;
            this.txtqualAnimal.Visible = false;
            // 
            // lblqualAnimal
            // 
            this.lblqualAnimal.AutoSize = true;
            this.lblqualAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblqualAnimal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqualAnimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblqualAnimal.Location = new System.Drawing.Point(221, 255);
            this.lblqualAnimal.Name = "lblqualAnimal";
            this.lblqualAnimal.Size = new System.Drawing.Size(128, 16);
            this.lblqualAnimal.TabIndex = 25;
            this.lblqualAnimal.Text = "Qual o animal  ?";
            this.lblqualAnimal.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(677, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 26;
            this.txtId.Visible = false;
            this.txtId.WordWrap = false;
            // 
            // lblInsiraId
            // 
            this.lblInsiraId.AutoSize = true;
            this.lblInsiraId.BackColor = System.Drawing.Color.Transparent;
            this.lblInsiraId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsiraId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInsiraId.Location = new System.Drawing.Point(690, 18);
            this.lblInsiraId.Name = "lblInsiraId";
            this.lblInsiraId.Size = new System.Drawing.Size(87, 16);
            this.lblInsiraId.TabIndex = 27;
            this.lblInsiraId.Text = "Insira a Id:";
            this.lblInsiraId.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(53, 479);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Location = new System.Drawing.Point(677, 246);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 34);
            this.btnOk.TabIndex = 29;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(639, 479);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSexo.Location = new System.Drawing.Point(311, 318);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(140, 16);
            this.lblSexo.TabIndex = 31;
            this.lblSexo.Text = "Sexo do animal :  ";
            // 
            // cbSexoAnimal
            // 
            this.cbSexoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexoAnimal.FormattingEnabled = true;
            this.cbSexoAnimal.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.cbSexoAnimal.Location = new System.Drawing.Point(441, 317);
            this.cbSexoAnimal.Name = "cbSexoAnimal";
            this.cbSexoAnimal.Size = new System.Drawing.Size(84, 21);
            this.cbSexoAnimal.TabIndex = 32;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(790, 528);
            this.Controls.Add(this.cbSexoAnimal);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblInsiraId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblqualAnimal);
            this.Controls.Add(this.txtqualAnimal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.mtbRG);
            this.Controls.Add(this.mtbContato);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.cbidadeAnimal);
            this.Controls.Add(this.txtidadeAnimal);
            this.Controls.Add(this.txtnomeAnimal);
            this.Controls.Add(this.txtnomeDono);
            this.Controls.Add(this.lblidadeAnimal);
            this.Controls.Add(this.lblnomeAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblnomeDono);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.Text = "Cadastro de animais";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnomeDono;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblnomeAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblidadeAnimal;
        private System.Windows.Forms.TextBox txtnomeDono;
        private System.Windows.Forms.TextBox txtnomeAnimal;
        private System.Windows.Forms.TextBox txtidadeAnimal;
        private System.Windows.Forms.ComboBox cbidadeAnimal;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.MaskedTextBox mtbContato;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtqualAnimal;
        private System.Windows.Forms.Label lblqualAnimal;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblInsiraId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbSexoAnimal;
    }
}

