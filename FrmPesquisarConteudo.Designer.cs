﻿namespace AvaliacaoStreaming
{
    partial class FrmPesquisarConteudo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnPesquisar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisarConteudo));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltarPesquisarConteudo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnlContainer.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Controls.Add(this.pnlHeader);
            this.pnlContainer.Controls.Add(this.txtBusca);
            this.pnlContainer.Controls.Add(this.cmbCampo);
            this.pnlContainer.Controls.Add(this.btnLimpar);
            this.pnlContainer.Controls.Add(this.btnPesquisar);
            this.pnlContainer.Controls.Add(this.dgv);
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1152, 583);
            this.pnlContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 516);
            this.panel1.TabIndex = 6;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.btnVoltarPesquisarConteudo);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 11);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1151, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "CineReviews";
            // 
            // btnVoltarPesquisarConteudo
            // 
            this.btnVoltarPesquisarConteudo.FlatAppearance.BorderSize = 0;
            this.btnVoltarPesquisarConteudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarPesquisarConteudo.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarPesquisarConteudo.Image")));
            this.btnVoltarPesquisarConteudo.Location = new System.Drawing.Point(10, 5);
            this.btnVoltarPesquisarConteudo.Name = "btnVoltarPesquisarConteudo";
            this.btnVoltarPesquisarConteudo.Size = new System.Drawing.Size(44, 45);
            this.btnVoltarPesquisarConteudo.TabIndex = 8;
            this.btnVoltarPesquisarConteudo.UseVisualStyleBackColor = true;
            this.btnVoltarPesquisarConteudo.Click += new System.EventHandler(this.BtnVoltarPesquisarConteudo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(412, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Conteúdos";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBusca.Location = new System.Drawing.Point(244, 137);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(497, 24);
            this.txtBusca.TabIndex = 1;
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbCampo.Items.AddRange(new object[] {
            "Título",
            "Categoria",
            "Ano",
            "Nota",
            "ID"});
            this.cmbCampo.Location = new System.Drawing.Point(747, 137);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(100, 26);
            this.cmbCampo.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnLimpar.Location = new System.Drawing.Point(866, 518);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 26);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnPesquisar.Location = new System.Drawing.Point(853, 137);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(99, 26);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(244, 179);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(708, 333);
            this.dgv.TabIndex = 4;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // FrmPesquisarConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 583);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPesquisarConteudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Conteúdos";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltarPesquisarConteudo;
        private System.Windows.Forms.Label label3;
    }
}
