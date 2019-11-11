namespace Shortest_Job_First
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.btnJugar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPortada
            // 
            this.pbPortada.Image = global::Shortest_Job_First.Properties.Resources.Portada;
            this.pbPortada.Location = new System.Drawing.Point(101, 72);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(500, 281);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPortada.TabIndex = 1;
            this.pbPortada.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.Depth = 0;
            this.btnJugar.Location = new System.Drawing.Point(120, 375);
            this.btnJugar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Primary = true;
            this.btnJugar.Size = new System.Drawing.Size(213, 48);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(353, 375);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(213, 48);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pbPortada);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrera de Caballos";
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPortada;
        private MaterialSkin.Controls.MaterialRaisedButton btnJugar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}

