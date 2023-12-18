namespace RacingFront
{
    partial class Entradas
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
            lblSector = new Label();
            cboSector = new ComboBox();
            gbDatos = new GroupBox();
            lblButaca = new Label();
            txtButaca = new TextBox();
            btnAgregar = new Button();
            gbDetalle = new GroupBox();
            dataGridView1 = new DataGridView();
            ColSector = new DataGridViewTextBoxColumn();
            ColButaca = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            gbComprar = new GroupBox();
            btnComprar = new Button();
            lblComprar = new Label();
            gbDatos.SuspendLayout();
            gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbComprar.SuspendLayout();
            SuspendLayout();
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.Font = new Font("Arial Unicode MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSector.Location = new Point(14, 24);
            lblSector.Name = "lblSector";
            lblSector.Size = new Size(49, 16);
            lblSector.TabIndex = 0;
            lblSector.Text = "Sector -";
            // 
            // cboSector
            // 
            cboSector.FormattingEnabled = true;
            cboSector.Location = new Point(68, 21);
            cboSector.Name = "cboSector";
            cboSector.Size = new Size(121, 23);
            cboSector.TabIndex = 1;
            // 
            // gbDatos
            // 
            gbDatos.BackColor = Color.White;
            gbDatos.Controls.Add(btnAgregar);
            gbDatos.Controls.Add(txtButaca);
            gbDatos.Controls.Add(lblSector);
            gbDatos.Controls.Add(lblButaca);
            gbDatos.Controls.Add(cboSector);
            gbDatos.Location = new Point(12, 3);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(339, 98);
            gbDatos.TabIndex = 2;
            gbDatos.TabStop = false;
            // 
            // lblButaca
            // 
            lblButaca.AutoSize = true;
            lblButaca.Font = new Font("Arial Unicode MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblButaca.Location = new Point(227, 24);
            lblButaca.Name = "lblButaca";
            lblButaca.Size = new Size(52, 16);
            lblButaca.TabIndex = 3;
            lblButaca.Text = "Butaca -";
            // 
            // txtButaca
            // 
            txtButaca.Location = new Point(284, 21);
            txtButaca.Name = "txtButaca";
            txtButaca.Size = new Size(43, 23);
            txtButaca.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PowderBlue;
            btnAgregar.Font = new Font("Arial Unicode MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.ImageKey = "(ninguna)";
            btnAgregar.Location = new Point(13, 63);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(313, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // gbDetalle
            // 
            gbDetalle.BackColor = Color.White;
            gbDetalle.Controls.Add(dataGridView1);
            gbDetalle.Location = new Point(12, 107);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Size = new Size(485, 221);
            gbDetalle.TabIndex = 3;
            gbDetalle.TabStop = false;
            gbDetalle.Text = "Detalle";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.PowderBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColSector, ColButaca, ColPrecio, ColAccion });
            dataGridView1.Location = new Point(15, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(456, 184);
            dataGridView1.TabIndex = 0;
            // 
            // ColSector
            // 
            ColSector.HeaderText = "Sector";
            ColSector.Name = "ColSector";
            ColSector.Width = 150;
            // 
            // ColButaca
            // 
            ColButaca.HeaderText = "Butaca";
            ColButaca.Name = "ColButaca";
            ColButaca.Width = 50;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            // 
            // ColAccion
            // 
            ColAccion.HeaderText = "Accion";
            ColAccion.Name = "ColAccion";
            ColAccion.Text = "Quitar";
            ColAccion.Visible = false;
            // 
            // gbComprar
            // 
            gbComprar.BackColor = Color.White;
            gbComprar.Controls.Add(lblComprar);
            gbComprar.Controls.Add(btnComprar);
            gbComprar.Location = new Point(357, 3);
            gbComprar.Name = "gbComprar";
            gbComprar.Size = new Size(140, 98);
            gbComprar.TabIndex = 4;
            gbComprar.TabStop = false;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.PowderBlue;
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(15, 37);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(111, 49);
            btnComprar.TabIndex = 0;
            btnComprar.Text = ">";
            btnComprar.UseVisualStyleBackColor = false;
            // 
            // lblComprar
            // 
            lblComprar.AutoSize = true;
            lblComprar.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblComprar.Location = new Point(36, 14);
            lblComprar.Name = "lblComprar";
            lblComprar.Size = new Size(67, 20);
            lblComprar.TabIndex = 1;
            lblComprar.Text = "Comprar";
            // 
            // Entradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(507, 336);
            Controls.Add(gbComprar);
            Controls.Add(gbDetalle);
            Controls.Add(gbDatos);
            Name = "Entradas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaccion de Entradas";
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbComprar.ResumeLayout(false);
            gbComprar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSector;
        private ComboBox cboSector;
        private GroupBox gbDatos;
        private Label lblButaca;
        private TextBox txtButaca;
        private Button btnAgregar;
        private GroupBox gbDetalle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColSector;
        private DataGridViewTextBoxColumn ColButaca;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewButtonColumn ColAccion;
        private GroupBox gbComprar;
        private Button btnComprar;
        private Label lblComprar;
    }
}