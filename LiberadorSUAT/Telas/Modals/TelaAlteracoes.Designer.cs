﻿
namespace LiberadorSUAT.Screens
{
    partial class TelaAlteracoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbHelpdesk = new System.Windows.Forms.TextBox();
            this.txbResponsavel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txbDescricao = new System.Windows.Forms.RichTextBox();
            this.txbAlteracao = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alteração Realizada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "HelpDesk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Responsável";
            // 
            // txbHelpdesk
            // 
            this.txbHelpdesk.Location = new System.Drawing.Point(15, 83);
            this.txbHelpdesk.Name = "txbHelpdesk";
            this.txbHelpdesk.Size = new System.Drawing.Size(100, 20);
            this.txbHelpdesk.TabIndex = 3;
            this.txbHelpdesk.TextChanged += new System.EventHandler(this.txbHelpdesk_TextChanged);
            // 
            // txbResponsavel
            // 
            this.txbResponsavel.Location = new System.Drawing.Point(170, 83);
            this.txbResponsavel.Name = "txbResponsavel";
            this.txbResponsavel.Size = new System.Drawing.Size(346, 20);
            this.txbResponsavel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição do Chamado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alteração Realizada";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Location = new System.Drawing.Point(339, 453);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(77, 32);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrarClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(437, 453);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 32);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Location = new System.Drawing.Point(239, 453);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(77, 31);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(12, 150);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(504, 106);
            this.txbDescricao.TabIndex = 12;
            this.txbDescricao.Text = "";
            // 
            // txbAlteracao
            // 
            this.txbAlteracao.Location = new System.Drawing.Point(12, 314);
            this.txbAlteracao.Name = "txbAlteracao";
            this.txbAlteracao.Size = new System.Drawing.Size(504, 106);
            this.txbAlteracao.TabIndex = 13;
            this.txbAlteracao.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(167, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "(Obrigatório)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(256, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "(Obrigatório)";
            // 
            // TelaAlteracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 496);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbAlteracao);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbResponsavel);
            this.Controls.Add(this.txbHelpdesk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaAlteracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaAlteracoes";
            this.Load += new System.EventHandler(this.TelaAlteracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbHelpdesk;
        private System.Windows.Forms.TextBox txbResponsavel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.RichTextBox txbDescricao;
        private System.Windows.Forms.RichTextBox txbAlteracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}