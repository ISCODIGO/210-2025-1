namespace Tareas
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnFiltrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            dtpFechaLimite = new DateTimePicker();
            btnAgregar = new Button();
            btnEliminar = new Button();
            lstTareas = new ListBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            cmbEstado = new ComboBox();
            btnFiltrar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 0;
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.Location = new Point(220, 12);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(200, 27);
            dtpFechaLimite.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(430, 10);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(510, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstTareas
            // 
            lstTareas.Location = new Point(12, 50);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(573, 184);
            lstTareas.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(220, 268);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 270);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 27);
            txtBuscar.TabIndex = 5;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(12, 310);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(200, 28);
            cmbEstado.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(220, 308);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 30);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(600, 350);
            Controls.Add(txtNombre);
            Controls.Add(dtpFechaLimite);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(lstTareas);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(cmbEstado);
            Controls.Add(btnFiltrar);
            Name = "MainForm";
            Text = "Gestor de Tareas";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
