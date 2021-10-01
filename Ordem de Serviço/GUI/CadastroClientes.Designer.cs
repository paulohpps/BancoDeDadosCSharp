
namespace Ordem_de_Serviço
{
    partial class Form2
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
            this.Titulo = new System.Windows.Forms.Label();
            this.NomeLb = new System.Windows.Forms.Label();
            this.TelefoneLb = new System.Windows.Forms.Label();
            this.EnderecoLb = new System.Windows.Forms.Label();
            this.NomeText = new System.Windows.Forms.TextBox();
            this.TelText = new System.Windows.Forms.TextBox();
            this.EndText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(129, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(437, 58);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Cadastro de Cliente";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NomeLb
            // 
            this.NomeLb.AutoSize = true;
            this.NomeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLb.Location = new System.Drawing.Point(22, 93);
            this.NomeLb.Name = "NomeLb";
            this.NomeLb.Size = new System.Drawing.Size(86, 31);
            this.NomeLb.TabIndex = 1;
            this.NomeLb.Text = "Nome";
            // 
            // TelefoneLb
            // 
            this.TelefoneLb.AutoSize = true;
            this.TelefoneLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneLb.Location = new System.Drawing.Point(22, 155);
            this.TelefoneLb.Name = "TelefoneLb";
            this.TelefoneLb.Size = new System.Drawing.Size(120, 31);
            this.TelefoneLb.TabIndex = 2;
            this.TelefoneLb.Text = "Telefone";
            // 
            // EnderecoLb
            // 
            this.EnderecoLb.AutoSize = true;
            this.EnderecoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoLb.Location = new System.Drawing.Point(22, 215);
            this.EnderecoLb.Name = "EnderecoLb";
            this.EnderecoLb.Size = new System.Drawing.Size(130, 31);
            this.EnderecoLb.TabIndex = 3;
            this.EnderecoLb.Text = "Endereço";
            // 
            // NomeText
            // 
            this.NomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeText.Location = new System.Drawing.Point(211, 93);
            this.NomeText.Name = "NomeText";
            this.NomeText.Size = new System.Drawing.Size(427, 31);
            this.NomeText.TabIndex = 6;
            // 
            // TelText
            // 
            this.TelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelText.Location = new System.Drawing.Point(211, 155);
            this.TelText.Name = "TelText";
            this.TelText.Size = new System.Drawing.Size(427, 31);
            this.TelText.TabIndex = 7;
            // 
            // EndText
            // 
            this.EndText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndText.Location = new System.Drawing.Point(211, 215);
            this.EndText.Name = "EndText";
            this.EndText.Size = new System.Drawing.Size(427, 31);
            this.EndText.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(354, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(211, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cadastrar Aparelho";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 407);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EndText);
            this.Controls.Add(this.TelText);
            this.Controls.Add(this.NomeText);
            this.Controls.Add(this.EnderecoLb);
            this.Controls.Add(this.TelefoneLb);
            this.Controls.Add(this.NomeLb);
            this.Controls.Add(this.Titulo);
            this.Name = "Form2";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label NomeLb;
        private System.Windows.Forms.Label TelefoneLb;
        private System.Windows.Forms.Label EnderecoLb;
        private System.Windows.Forms.TextBox NomeText;
        private System.Windows.Forms.TextBox TelText;
        private System.Windows.Forms.TextBox EndText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}