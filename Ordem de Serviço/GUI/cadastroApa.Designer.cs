
namespace Ordem_de_Serviço
{
    partial class cadastroApa
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
            this.SerieText = new System.Windows.Forms.TextBox();
            this.ModeloText = new System.Windows.Forms.TextBox();
            this.MarcaText = new System.Windows.Forms.TextBox();
            this.SerieLb = new System.Windows.Forms.Label();
            this.ModeloLb = new System.Windows.Forms.Label();
            this.MarcaLb = new System.Windows.Forms.Label();
            this.TVButton = new System.Windows.Forms.RadioButton();
            this.SomButton = new System.Windows.Forms.RadioButton();
            this.DvdButton = new System.Windows.Forms.RadioButton();
            this.OutrosButton = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EstadoText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(100, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(501, 58);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Cadastro de Aparelhos";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SerieText
            // 
            this.SerieText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerieText.Location = new System.Drawing.Point(235, 300);
            this.SerieText.Name = "SerieText";
            this.SerieText.Size = new System.Drawing.Size(427, 31);
            this.SerieText.TabIndex = 14;
            // 
            // ModeloText
            // 
            this.ModeloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloText.Location = new System.Drawing.Point(234, 240);
            this.ModeloText.Name = "ModeloText";
            this.ModeloText.Size = new System.Drawing.Size(427, 31);
            this.ModeloText.TabIndex = 13;
            // 
            // MarcaText
            // 
            this.MarcaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaText.Location = new System.Drawing.Point(234, 181);
            this.MarcaText.Name = "MarcaText";
            this.MarcaText.Size = new System.Drawing.Size(427, 31);
            this.MarcaText.TabIndex = 12;
            // 
            // SerieLb
            // 
            this.SerieLb.AutoSize = true;
            this.SerieLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerieLb.Location = new System.Drawing.Point(12, 300);
            this.SerieLb.Name = "SerieLb";
            this.SerieLb.Size = new System.Drawing.Size(217, 31);
            this.SerieLb.TabIndex = 11;
            this.SerieLb.Text = "Numero de Serié";
            // 
            // ModeloLb
            // 
            this.ModeloLb.AutoSize = true;
            this.ModeloLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloLb.Location = new System.Drawing.Point(12, 240);
            this.ModeloLb.Name = "ModeloLb";
            this.ModeloLb.Size = new System.Drawing.Size(102, 31);
            this.ModeloLb.TabIndex = 10;
            this.ModeloLb.Text = "Modelo";
            // 
            // MarcaLb
            // 
            this.MarcaLb.AutoSize = true;
            this.MarcaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaLb.Location = new System.Drawing.Point(12, 178);
            this.MarcaLb.Name = "MarcaLb";
            this.MarcaLb.Size = new System.Drawing.Size(89, 31);
            this.MarcaLb.TabIndex = 9;
            this.MarcaLb.Text = "Marca";
            // 
            // TVButton
            // 
            this.TVButton.AutoSize = true;
            this.TVButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVButton.Location = new System.Drawing.Point(110, 106);
            this.TVButton.Name = "TVButton";
            this.TVButton.Size = new System.Drawing.Size(57, 29);
            this.TVButton.TabIndex = 16;
            this.TVButton.TabStop = true;
            this.TVButton.Text = "TV";
            this.TVButton.UseVisualStyleBackColor = true;
            this.TVButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SomButton
            // 
            this.SomButton.AutoSize = true;
            this.SomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SomButton.Location = new System.Drawing.Point(235, 106);
            this.SomButton.Name = "SomButton";
            this.SomButton.Size = new System.Drawing.Size(73, 29);
            this.SomButton.TabIndex = 17;
            this.SomButton.TabStop = true;
            this.SomButton.Text = "Som";
            this.SomButton.UseVisualStyleBackColor = true;
            // 
            // DvdButton
            // 
            this.DvdButton.AutoSize = true;
            this.DvdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DvdButton.Location = new System.Drawing.Point(377, 106);
            this.DvdButton.Name = "DvdButton";
            this.DvdButton.Size = new System.Drawing.Size(74, 29);
            this.DvdButton.TabIndex = 18;
            this.DvdButton.TabStop = true;
            this.DvdButton.Text = "DVD";
            this.DvdButton.UseVisualStyleBackColor = true;
            // 
            // OutrosButton
            // 
            this.OutrosButton.AutoSize = true;
            this.OutrosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutrosButton.Location = new System.Drawing.Point(507, 106);
            this.OutrosButton.Name = "OutrosButton";
            this.OutrosButton.Size = new System.Drawing.Size(94, 29);
            this.OutrosButton.TabIndex = 19;
            this.OutrosButton.TabStop = true;
            this.OutrosButton.Text = "Outros";
            this.OutrosButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(377, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Estado";
            // 
            // EstadoText
            // 
            this.EstadoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoText.Location = new System.Drawing.Point(235, 360);
            this.EstadoText.Multiline = true;
            this.EstadoText.Name = "EstadoText";
            this.EstadoText.Size = new System.Drawing.Size(427, 85);
            this.EstadoText.TabIndex = 23;
            // 
            // cadastroApa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 524);
            this.Controls.Add(this.EstadoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OutrosButton);
            this.Controls.Add(this.DvdButton);
            this.Controls.Add(this.SomButton);
            this.Controls.Add(this.TVButton);
            this.Controls.Add(this.SerieText);
            this.Controls.Add(this.ModeloText);
            this.Controls.Add(this.MarcaText);
            this.Controls.Add(this.SerieLb);
            this.Controls.Add(this.ModeloLb);
            this.Controls.Add(this.MarcaLb);
            this.Controls.Add(this.Titulo);
            this.Name = "cadastroApa";
            this.Text = "cadastroApa";
            this.Load += new System.EventHandler(this.cadastroApa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox SerieText;
        private System.Windows.Forms.TextBox ModeloText;
        private System.Windows.Forms.TextBox MarcaText;
        private System.Windows.Forms.Label SerieLb;
        private System.Windows.Forms.Label ModeloLb;
        private System.Windows.Forms.Label MarcaLb;
        private System.Windows.Forms.RadioButton TVButton;
        private System.Windows.Forms.RadioButton SomButton;
        private System.Windows.Forms.RadioButton DvdButton;
        private System.Windows.Forms.RadioButton OutrosButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EstadoText;
    }
}