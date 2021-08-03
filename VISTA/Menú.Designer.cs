
namespace VISTA
{
    partial class Menú
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnConAyuda = new System.Windows.Forms.Button();
            this.btnSinAyuda = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACIERTA EL NÚMERO";
            // 
            // btnConAyuda
            // 
            this.btnConAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConAyuda.Location = new System.Drawing.Point(6, 89);
            this.btnConAyuda.Name = "btnConAyuda";
            this.btnConAyuda.Size = new System.Drawing.Size(123, 53);
            this.btnConAyuda.TabIndex = 1;
            this.btnConAyuda.Text = "PARTIDA CON AYUDA";
            this.btnConAyuda.UseVisualStyleBackColor = true;
            this.btnConAyuda.Click += new System.EventHandler(this.btnConAyuda_Click);
            // 
            // btnSinAyuda
            // 
            this.btnSinAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinAyuda.Location = new System.Drawing.Point(135, 89);
            this.btnSinAyuda.Name = "btnSinAyuda";
            this.btnSinAyuda.Size = new System.Drawing.Size(123, 53);
            this.btnSinAyuda.TabIndex = 2;
            this.btnSinAyuda.Text = "PARTIDA SIN AYUDA";
            this.btnSinAyuda.UseVisualStyleBackColor = true;
            this.btnSinAyuda.Click += new System.EventHandler(this.btnSinAyuda_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(264, 89);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(123, 53);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "HISTORIAL";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 166);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnSinAyuda);
            this.Controls.Add(this.btnConAyuda);
            this.Controls.Add(this.label1);
            this.Name = "Menú";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConAyuda;
        private System.Windows.Forms.Button btnSinAyuda;
        private System.Windows.Forms.Button btnHistorial;
    }
}

