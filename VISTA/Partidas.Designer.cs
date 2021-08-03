
namespace VISTA
{
    partial class Partidas
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
            this.txtMiNumero = new System.Windows.Forms.TextBox();
            this.btnAdivinar = new System.Windows.Forms.Button();
            this.NumeroRandom = new System.Windows.Forms.Label();
            this.numerosIntentos = new System.Windows.Forms.Label();
            this.numeroCreditos = new System.Windows.Forms.Label();
            this.btnAbandonar = new System.Windows.Forms.Button();
            this.gpMiNumero = new System.Windows.Forms.GroupBox();
            this.gpCaracteristicas = new System.Windows.Forms.GroupBox();
            this.lbNumeroRandom = new System.Windows.Forms.Label();
            this.btnVolverAIntentar = new System.Windows.Forms.Button();
            this.gpMiNumero.SuspendLayout();
            this.gpCaracteristicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMiNumero
            // 
            this.txtMiNumero.Location = new System.Drawing.Point(155, 35);
            this.txtMiNumero.Name = "txtMiNumero";
            this.txtMiNumero.Size = new System.Drawing.Size(92, 20);
            this.txtMiNumero.TabIndex = 3;
            this.txtMiNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdivinar
            // 
            this.btnAdivinar.Location = new System.Drawing.Point(155, 61);
            this.btnAdivinar.Name = "btnAdivinar";
            this.btnAdivinar.Size = new System.Drawing.Size(92, 23);
            this.btnAdivinar.TabIndex = 4;
            this.btnAdivinar.Text = "Adivinar";
            this.btnAdivinar.UseVisualStyleBackColor = true;
            this.btnAdivinar.Click += new System.EventHandler(this.btnAdivinar_Click);
            // 
            // NumeroRandom
            // 
            this.NumeroRandom.AutoSize = true;
            this.NumeroRandom.Location = new System.Drawing.Point(152, 16);
            this.NumeroRandom.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NumeroRandom.Name = "NumeroRandom";
            this.NumeroRandom.Size = new System.Drawing.Size(97, 13);
            this.NumeroRandom.TabIndex = 5;
            this.NumeroRandom.Text = "Ingrese Un numero";
            // 
            // numerosIntentos
            // 
            this.numerosIntentos.AutoSize = true;
            this.numerosIntentos.Location = new System.Drawing.Point(10, 19);
            this.numerosIntentos.Name = "numerosIntentos";
            this.numerosIntentos.Size = new System.Drawing.Size(13, 13);
            this.numerosIntentos.TabIndex = 6;
            this.numerosIntentos.Text = "0";
            // 
            // numeroCreditos
            // 
            this.numeroCreditos.AutoSize = true;
            this.numeroCreditos.Location = new System.Drawing.Point(10, 62);
            this.numeroCreditos.Name = "numeroCreditos";
            this.numeroCreditos.Size = new System.Drawing.Size(13, 13);
            this.numeroCreditos.TabIndex = 7;
            this.numeroCreditos.Text = "0";
            // 
            // btnAbandonar
            // 
            this.btnAbandonar.Location = new System.Drawing.Point(286, 59);
            this.btnAbandonar.Name = "btnAbandonar";
            this.btnAbandonar.Size = new System.Drawing.Size(92, 23);
            this.btnAbandonar.TabIndex = 8;
            this.btnAbandonar.Text = "Abandonar";
            this.btnAbandonar.UseVisualStyleBackColor = true;
            this.btnAbandonar.Click += new System.EventHandler(this.btnAbandonar_Click);
            // 
            // gpMiNumero
            // 
            this.gpMiNumero.Controls.Add(this.txtMiNumero);
            this.gpMiNumero.Controls.Add(this.btnAdivinar);
            this.gpMiNumero.Controls.Add(this.NumeroRandom);
            this.gpMiNumero.Location = new System.Drawing.Point(2, 9);
            this.gpMiNumero.Name = "gpMiNumero";
            this.gpMiNumero.Size = new System.Drawing.Size(385, 90);
            this.gpMiNumero.TabIndex = 9;
            this.gpMiNumero.TabStop = false;
            this.gpMiNumero.Text = "Número";
            // 
            // gpCaracteristicas
            // 
            this.gpCaracteristicas.Controls.Add(this.lbNumeroRandom);
            this.gpCaracteristicas.Controls.Add(this.btnVolverAIntentar);
            this.gpCaracteristicas.Controls.Add(this.btnAbandonar);
            this.gpCaracteristicas.Controls.Add(this.numeroCreditos);
            this.gpCaracteristicas.Controls.Add(this.numerosIntentos);
            this.gpCaracteristicas.Location = new System.Drawing.Point(2, 99);
            this.gpCaracteristicas.Name = "gpCaracteristicas";
            this.gpCaracteristicas.Size = new System.Drawing.Size(384, 90);
            this.gpCaracteristicas.TabIndex = 10;
            this.gpCaracteristicas.TabStop = false;
            this.gpCaracteristicas.Text = "Caracteristicas";
            // 
            // lbNumeroRandom
            // 
            this.lbNumeroRandom.AutoSize = true;
            this.lbNumeroRandom.Location = new System.Drawing.Point(173, 43);
            this.lbNumeroRandom.Name = "lbNumeroRandom";
            this.lbNumeroRandom.Size = new System.Drawing.Size(35, 13);
            this.lbNumeroRandom.TabIndex = 10;
            this.lbNumeroRandom.Text = "label1";
            // 
            // btnVolverAIntentar
            // 
            this.btnVolverAIntentar.Location = new System.Drawing.Point(286, 19);
            this.btnVolverAIntentar.Name = "btnVolverAIntentar";
            this.btnVolverAIntentar.Size = new System.Drawing.Size(92, 34);
            this.btnVolverAIntentar.TabIndex = 9;
            this.btnVolverAIntentar.Text = "Volver a intentarlo";
            this.btnVolverAIntentar.UseVisualStyleBackColor = true;
            this.btnVolverAIntentar.Click += new System.EventHandler(this.btnVolverAIntentar_Click);
            // 
            // Partidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 196);
            this.Controls.Add(this.gpCaracteristicas);
            this.Controls.Add(this.gpMiNumero);
            this.Name = "Partidas";
            this.Text = "Partida";
            this.gpMiNumero.ResumeLayout(false);
            this.gpMiNumero.PerformLayout();
            this.gpCaracteristicas.ResumeLayout(false);
            this.gpCaracteristicas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMiNumero;
        private System.Windows.Forms.Button btnAdivinar;
        private System.Windows.Forms.Label NumeroRandom;
        private System.Windows.Forms.Label numerosIntentos;
        private System.Windows.Forms.Label numeroCreditos;
        private System.Windows.Forms.Button btnAbandonar;
        private System.Windows.Forms.GroupBox gpMiNumero;
        private System.Windows.Forms.GroupBox gpCaracteristicas;
        private System.Windows.Forms.Button btnVolverAIntentar;
        private System.Windows.Forms.Label lbNumeroRandom;
    }
}