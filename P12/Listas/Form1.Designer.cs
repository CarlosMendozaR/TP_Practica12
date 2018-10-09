namespace Listas
{
    partial class Form1
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaKilometraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTransmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(27, 77);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(160, 44);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar Autos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catálogo de Autos Súper Lujo";
            // 
            // dgvAutos
            // 
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaNombre,
            this.columnaModelo,
            this.columnaKilometraje,
            this.columnaTransmision,
            this.columnaPrecio});
            this.dgvAutos.Location = new System.Drawing.Point(27, 139);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.RowTemplate.Height = 24;
            this.dgvAutos.Size = new System.Drawing.Size(543, 150);
            this.dgvAutos.TabIndex = 2;
            this.dgvAutos.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecciona el auto que deseas comprar.";
            this.label2.Visible = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(604, 173);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(159, 54);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Visible = false;
            // 
            // columnaNombre
            // 
            this.columnaNombre.Frozen = true;
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.ReadOnly = true;
            // 
            // columnaModelo
            // 
            this.columnaModelo.Frozen = true;
            this.columnaModelo.HeaderText = "Modelo";
            this.columnaModelo.Name = "columnaModelo";
            this.columnaModelo.ReadOnly = true;
            // 
            // columnaKilometraje
            // 
            this.columnaKilometraje.Frozen = true;
            this.columnaKilometraje.HeaderText = "Kilometraje";
            this.columnaKilometraje.Name = "columnaKilometraje";
            this.columnaKilometraje.ReadOnly = true;
            // 
            // columnaTransmision
            // 
            this.columnaTransmision.Frozen = true;
            this.columnaTransmision.HeaderText = "Transmisión";
            this.columnaTransmision.Name = "columnaTransmision";
            this.columnaTransmision.ReadOnly = true;
            // 
            // columnaPrecio
            // 
            this.columnaPrecio.Frozen = true;
            this.columnaPrecio.HeaderText = "Precio";
            this.columnaPrecio.Name = "columnaPrecio";
            this.columnaPrecio.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaKilometraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTransmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecio;
    }
}

