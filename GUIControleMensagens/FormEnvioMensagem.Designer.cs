namespace GUIControleMensagens
{
    partial class FormEnvioMensagem
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
            this.textBoxRemetente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDestinatario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxMensagem = new System.Windows.Forms.RichTextBox();
            this.buttonNovaMensagem = new System.Windows.Forms.Button();
            this.buttonEnviarMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remetente:";
            // 
            // textBoxRemetente
            // 
            this.textBoxRemetente.Location = new System.Drawing.Point(110, 25);
            this.textBoxRemetente.Name = "textBoxRemetente";
            this.textBoxRemetente.Size = new System.Drawing.Size(406, 22);
            this.textBoxRemetente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destinatário:";
            // 
            // textBoxDestinatario
            // 
            this.textBoxDestinatario.Location = new System.Drawing.Point(110, 61);
            this.textBoxDestinatario.Name = "textBoxDestinatario";
            this.textBoxDestinatario.Size = new System.Drawing.Size(406, 22);
            this.textBoxDestinatario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assunto:";
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Location = new System.Drawing.Point(110, 93);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(406, 22);
            this.textBoxAssunto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mensagem";
            // 
            // richTextBoxMensagem
            // 
            this.richTextBoxMensagem.Location = new System.Drawing.Point(110, 134);
            this.richTextBoxMensagem.Name = "richTextBoxMensagem";
            this.richTextBoxMensagem.Size = new System.Drawing.Size(406, 146);
            this.richTextBoxMensagem.TabIndex = 7;
            this.richTextBoxMensagem.Text = "";
            // 
            // buttonNovaMensagem
            // 
            this.buttonNovaMensagem.Location = new System.Drawing.Point(22, 286);
            this.buttonNovaMensagem.Name = "buttonNovaMensagem";
            this.buttonNovaMensagem.Size = new System.Drawing.Size(157, 44);
            this.buttonNovaMensagem.TabIndex = 8;
            this.buttonNovaMensagem.Text = "Nova Mensagem";
            this.buttonNovaMensagem.UseVisualStyleBackColor = true;
            // 
            // buttonEnviarMensagem
            // 
            this.buttonEnviarMensagem.Location = new System.Drawing.Point(185, 286);
            this.buttonEnviarMensagem.Name = "buttonEnviarMensagem";
            this.buttonEnviarMensagem.Size = new System.Drawing.Size(157, 44);
            this.buttonEnviarMensagem.TabIndex = 9;
            this.buttonEnviarMensagem.Text = "Enviar Mensagem";
            this.buttonEnviarMensagem.UseVisualStyleBackColor = true;
            // 
            // FormEnvioMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 342);
            this.Controls.Add(this.buttonEnviarMensagem);
            this.Controls.Add(this.buttonNovaMensagem);
            this.Controls.Add(this.richTextBoxMensagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDestinatario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRemetente);
            this.Controls.Add(this.label1);
            this.Name = "FormEnvioMensagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Envio de Mensagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRemetente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDestinatario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxMensagem;
        private System.Windows.Forms.Button buttonNovaMensagem;
        private System.Windows.Forms.Button buttonEnviarMensagem;
    }
}