namespace Shortest_Job_First
{
    partial class Carrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrera));
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.lvLugares = new System.Windows.Forms.ListView();
            this.chPosiciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensaje = new MaterialSkin.Controls.MaterialLabel();
            this.pbDinero = new System.Windows.Forms.PictureBox();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnReiniciar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnIniciar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pbApuestas = new System.Windows.Forms.PictureBox();
            this.pbMeta = new System.Windows.Forms.PictureBox();
            this.pbCaballo5 = new System.Windows.Forms.PictureBox();
            this.pbCaballo4 = new System.Windows.Forms.PictureBox();
            this.pbCaballo3 = new System.Windows.Forms.PictureBox();
            this.pbCaballo2 = new System.Windows.Forms.PictureBox();
            this.pbCaballo1 = new System.Windows.Forms.PictureBox();
            this.pbPista = new System.Windows.Forms.PictureBox();
            this.lblCaballo1 = new System.Windows.Forms.Label();
            this.lblCaballo2 = new System.Windows.Forms.Label();
            this.lblCaballo3 = new System.Windows.Forms.Label();
            this.lblCaballo4 = new System.Windows.Forms.Label();
            this.lblCaballo5 = new System.Windows.Forms.Label();
            this.wmpMusica = new AxWMPLib.AxWindowsMediaPlayer();
            this.gbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDinero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApuestas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusica)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControles
            // 
            this.gbControles.BackColor = System.Drawing.SystemColors.Window;
            this.gbControles.Controls.Add(this.wmpMusica);
            this.gbControles.Controls.Add(this.lvLugares);
            this.gbControles.Controls.Add(this.label1);
            this.gbControles.Controls.Add(this.lblMensaje);
            this.gbControles.Controls.Add(this.pbDinero);
            this.gbControles.Controls.Add(this.btnSalir);
            this.gbControles.Controls.Add(this.btnReiniciar);
            this.gbControles.Controls.Add(this.btnIniciar);
            this.gbControles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControles.Location = new System.Drawing.Point(12, 516);
            this.gbControles.Name = "gbControles";
            this.gbControles.Size = new System.Drawing.Size(1263, 138);
            this.gbControles.TabIndex = 2;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Controles";
            // 
            // lvLugares
            // 
            this.lvLugares.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPosiciones});
            this.lvLugares.GridLines = true;
            this.lvLugares.Location = new System.Drawing.Point(1070, 17);
            this.lvLugares.Name = "lvLugares";
            this.lvLugares.Size = new System.Drawing.Size(187, 115);
            this.lvLugares.TabIndex = 7;
            this.lvLugares.UseCompatibleStateImageBehavior = false;
            this.lvLugares.View = System.Windows.Forms.View.Details;
            // 
            // chPosiciones
            // 
            this.chPosiciones.Text = "Posiciones";
            this.chPosiciones.Width = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(726, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "¡Haz tus apuestas!";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Depth = 0;
            this.lblMensaje.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensaje.Location = new System.Drawing.Point(798, 47);
            this.lblMensaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 19);
            this.lblMensaje.TabIndex = 5;
            // 
            // pbDinero
            // 
            this.pbDinero.Image = global::Shortest_Job_First.Properties.Resources.Dinero;
            this.pbDinero.Location = new System.Drawing.Point(950, 36);
            this.pbDinero.Name = "pbDinero";
            this.pbDinero.Size = new System.Drawing.Size(101, 79);
            this.pbDinero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDinero.TabIndex = 4;
            this.pbDinero.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(468, 25);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(225, 107);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Depth = 0;
            this.btnReiniciar.Location = new System.Drawing.Point(237, 25);
            this.btnReiniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Primary = true;
            this.btnReiniciar.Size = new System.Drawing.Size(225, 107);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Depth = 0;
            this.btnIniciar.Location = new System.Drawing.Point(6, 25);
            this.btnIniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Primary = true;
            this.btnIniciar.Size = new System.Drawing.Size(225, 107);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pbApuestas
            // 
            this.pbApuestas.BackColor = System.Drawing.Color.Transparent;
            this.pbApuestas.Image = global::Shortest_Job_First.Properties.Resources.Estrategia;
            this.pbApuestas.Location = new System.Drawing.Point(169, 31);
            this.pbApuestas.Name = "pbApuestas";
            this.pbApuestas.Size = new System.Drawing.Size(24, 24);
            this.pbApuestas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbApuestas.TabIndex = 3;
            this.pbApuestas.TabStop = false;
            // 
            // pbMeta
            // 
            this.pbMeta.BackColor = System.Drawing.Color.Transparent;
            this.pbMeta.Image = global::Shortest_Job_First.Properties.Resources.Meta;
            this.pbMeta.Location = new System.Drawing.Point(1258, 22);
            this.pbMeta.Name = "pbMeta";
            this.pbMeta.Size = new System.Drawing.Size(29, 46);
            this.pbMeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMeta.TabIndex = 10;
            this.pbMeta.TabStop = false;
            // 
            // pbCaballo5
            // 
            this.pbCaballo5.BackColor = System.Drawing.Color.White;
            this.pbCaballo5.BackgroundImage = global::Shortest_Job_First.Properties.Resources.Ca5;
            this.pbCaballo5.Image = global::Shortest_Job_First.Properties.Resources.Caballo;
            this.pbCaballo5.Location = new System.Drawing.Point(0, 421);
            this.pbCaballo5.Name = "pbCaballo5";
            this.pbCaballo5.Size = new System.Drawing.Size(121, 78);
            this.pbCaballo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaballo5.TabIndex = 9;
            this.pbCaballo5.TabStop = false;
            // 
            // pbCaballo4
            // 
            this.pbCaballo4.BackColor = System.Drawing.Color.White;
            this.pbCaballo4.BackgroundImage = global::Shortest_Job_First.Properties.Resources.Ca4;
            this.pbCaballo4.Image = global::Shortest_Job_First.Properties.Resources.Caballo;
            this.pbCaballo4.Location = new System.Drawing.Point(0, 337);
            this.pbCaballo4.Name = "pbCaballo4";
            this.pbCaballo4.Size = new System.Drawing.Size(121, 78);
            this.pbCaballo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaballo4.TabIndex = 8;
            this.pbCaballo4.TabStop = false;
            // 
            // pbCaballo3
            // 
            this.pbCaballo3.BackColor = System.Drawing.Color.White;
            this.pbCaballo3.BackgroundImage = global::Shortest_Job_First.Properties.Resources.Ca3;
            this.pbCaballo3.Image = global::Shortest_Job_First.Properties.Resources.Caballo;
            this.pbCaballo3.Location = new System.Drawing.Point(0, 253);
            this.pbCaballo3.Name = "pbCaballo3";
            this.pbCaballo3.Size = new System.Drawing.Size(121, 78);
            this.pbCaballo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaballo3.TabIndex = 7;
            this.pbCaballo3.TabStop = false;
            // 
            // pbCaballo2
            // 
            this.pbCaballo2.BackColor = System.Drawing.Color.White;
            this.pbCaballo2.BackgroundImage = global::Shortest_Job_First.Properties.Resources.Ca2;
            this.pbCaballo2.Image = global::Shortest_Job_First.Properties.Resources.Caballo;
            this.pbCaballo2.Location = new System.Drawing.Point(0, 169);
            this.pbCaballo2.Name = "pbCaballo2";
            this.pbCaballo2.Size = new System.Drawing.Size(121, 78);
            this.pbCaballo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaballo2.TabIndex = 6;
            this.pbCaballo2.TabStop = false;
            // 
            // pbCaballo1
            // 
            this.pbCaballo1.BackColor = System.Drawing.Color.White;
            this.pbCaballo1.BackgroundImage = global::Shortest_Job_First.Properties.Resources.Ca1;
            this.pbCaballo1.Image = global::Shortest_Job_First.Properties.Resources.Caballo;
            this.pbCaballo1.Location = new System.Drawing.Point(0, 85);
            this.pbCaballo1.Name = "pbCaballo1";
            this.pbCaballo1.Size = new System.Drawing.Size(121, 78);
            this.pbCaballo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaballo1.TabIndex = 5;
            this.pbCaballo1.TabStop = false;
            // 
            // pbPista
            // 
            this.pbPista.BackColor = System.Drawing.Color.Transparent;
            this.pbPista.Image = global::Shortest_Job_First.Properties.Resources.Pasto;
            this.pbPista.Location = new System.Drawing.Point(0, 74);
            this.pbPista.Name = "pbPista";
            this.pbPista.Size = new System.Drawing.Size(1287, 436);
            this.pbPista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPista.TabIndex = 4;
            this.pbPista.TabStop = false;
            // 
            // lblCaballo1
            // 
            this.lblCaballo1.AutoSize = true;
            this.lblCaballo1.BackColor = System.Drawing.Color.Transparent;
            this.lblCaballo1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaballo1.ForeColor = System.Drawing.Color.Red;
            this.lblCaballo1.Image = global::Shortest_Job_First.Properties.Resources.Pasto;
            this.lblCaballo1.Location = new System.Drawing.Point(-6, 85);
            this.lblCaballo1.Name = "lblCaballo1";
            this.lblCaballo1.Size = new System.Drawing.Size(30, 32);
            this.lblCaballo1.TabIndex = 11;
            this.lblCaballo1.Text = "1";
            // 
            // lblCaballo2
            // 
            this.lblCaballo2.AutoSize = true;
            this.lblCaballo2.BackColor = System.Drawing.Color.Transparent;
            this.lblCaballo2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaballo2.ForeColor = System.Drawing.Color.Red;
            this.lblCaballo2.Image = global::Shortest_Job_First.Properties.Resources.Pasto;
            this.lblCaballo2.Location = new System.Drawing.Point(-6, 169);
            this.lblCaballo2.Name = "lblCaballo2";
            this.lblCaballo2.Size = new System.Drawing.Size(30, 32);
            this.lblCaballo2.TabIndex = 12;
            this.lblCaballo2.Text = "2";
            // 
            // lblCaballo3
            // 
            this.lblCaballo3.AutoSize = true;
            this.lblCaballo3.BackColor = System.Drawing.Color.Transparent;
            this.lblCaballo3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaballo3.ForeColor = System.Drawing.Color.Red;
            this.lblCaballo3.Image = global::Shortest_Job_First.Properties.Resources.Pasto;
            this.lblCaballo3.Location = new System.Drawing.Point(-6, 253);
            this.lblCaballo3.Name = "lblCaballo3";
            this.lblCaballo3.Size = new System.Drawing.Size(30, 32);
            this.lblCaballo3.TabIndex = 13;
            this.lblCaballo3.Text = "3";
            // 
            // lblCaballo4
            // 
            this.lblCaballo4.AutoSize = true;
            this.lblCaballo4.BackColor = System.Drawing.Color.Transparent;
            this.lblCaballo4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaballo4.ForeColor = System.Drawing.Color.Red;
            this.lblCaballo4.Image = global::Shortest_Job_First.Properties.Resources.Pasto;
            this.lblCaballo4.Location = new System.Drawing.Point(-6, 337);
            this.lblCaballo4.Name = "lblCaballo4";
            this.lblCaballo4.Size = new System.Drawing.Size(30, 32);
            this.lblCaballo4.TabIndex = 14;
            this.lblCaballo4.Text = "4";
            // 
            // lblCaballo5
            // 
            this.lblCaballo5.AutoSize = true;
            this.lblCaballo5.BackColor = System.Drawing.Color.Transparent;
            this.lblCaballo5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaballo5.ForeColor = System.Drawing.Color.Red;
            this.lblCaballo5.Image = global::Shortest_Job_First.Properties.Resources.Pasto;
            this.lblCaballo5.Location = new System.Drawing.Point(-6, 421);
            this.lblCaballo5.Name = "lblCaballo5";
            this.lblCaballo5.Size = new System.Drawing.Size(30, 32);
            this.lblCaballo5.TabIndex = 15;
            this.lblCaballo5.Text = "5";
            // 
            // wmpMusica
            // 
            this.wmpMusica.Enabled = true;
            this.wmpMusica.Location = new System.Drawing.Point(818, 92);
            this.wmpMusica.Name = "wmpMusica";
            this.wmpMusica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusica.OcxState")));
            this.wmpMusica.Size = new System.Drawing.Size(8, 8);
            this.wmpMusica.TabIndex = 8;
            this.wmpMusica.Visible = false;
            // 
            // Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 666);
            this.Controls.Add(this.lblCaballo5);
            this.Controls.Add(this.lblCaballo4);
            this.Controls.Add(this.lblCaballo3);
            this.Controls.Add(this.pbApuestas);
            this.Controls.Add(this.lblCaballo2);
            this.Controls.Add(this.lblCaballo1);
            this.Controls.Add(this.pbMeta);
            this.Controls.Add(this.pbCaballo5);
            this.Controls.Add(this.pbCaballo4);
            this.Controls.Add(this.pbCaballo3);
            this.Controls.Add(this.pbCaballo2);
            this.Controls.Add(this.pbCaballo1);
            this.Controls.Add(this.pbPista);
            this.Controls.Add(this.gbControles);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Carrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrera de Caballos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Carrera_FormClosed);
            this.Load += new System.EventHandler(this.Carrera_Load);
            this.gbControles.ResumeLayout(false);
            this.gbControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDinero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApuestas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbControles;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnReiniciar;
        private MaterialSkin.Controls.MaterialRaisedButton btnIniciar;
        private System.Windows.Forms.PictureBox pbCaballo1;
        private System.Windows.Forms.PictureBox pbCaballo2;
        private System.Windows.Forms.PictureBox pbCaballo3;
        private System.Windows.Forms.PictureBox pbCaballo4;
        private System.Windows.Forms.PictureBox pbCaballo5;
        private System.Windows.Forms.PictureBox pbMeta;
        private System.Windows.Forms.PictureBox pbDinero;
        private System.Windows.Forms.PictureBox pbApuestas;
        private MaterialSkin.Controls.MaterialLabel lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPista;
        private System.Windows.Forms.Label lblCaballo1;
        private System.Windows.Forms.Label lblCaballo2;
        private System.Windows.Forms.Label lblCaballo3;
        private System.Windows.Forms.Label lblCaballo4;
        private System.Windows.Forms.Label lblCaballo5;
        private System.Windows.Forms.ListView lvLugares;
        private System.Windows.Forms.ColumnHeader chPosiciones;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusica;
    }
}