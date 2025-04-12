namespace ManejoFicherosWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeerLinea;
        private System.Windows.Forms.Button btnLeerTodo;
        private System.Windows.Forms.Button btnLeerCaracter;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRuta;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtContenido = new TextBox();
            btnGuardar = new Button();
            btnLeerLinea = new Button();
            btnLeerTodo = new Button();
            btnLeerCaracter = new Button();
            btnSeleccionarArchivo = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblRuta = new Label();
            btnFile = new Button();
            SuspendLayout();
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(12, 60);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ScrollBars = ScrollBars.Vertical;
            txtContenido.Size = new Size(560, 220);
            txtContenido.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 290);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 30);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "StreamWriter";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLeerLinea
            // 
            btnLeerLinea.Location = new Point(138, 290);
            btnLeerLinea.Name = "btnLeerLinea";
            btnLeerLinea.Size = new Size(101, 30);
            btnLeerLinea.TabIndex = 2;
            btnLeerLinea.Text = "ReadLine";
            btnLeerLinea.UseVisualStyleBackColor = true;
            btnLeerLinea.Click += btnLeerLinea_Click;
            // 
            // btnLeerTodo
            // 
            btnLeerTodo.Location = new Point(245, 290);
            btnLeerTodo.Name = "btnLeerTodo";
            btnLeerTodo.Size = new Size(101, 30);
            btnLeerTodo.TabIndex = 3;
            btnLeerTodo.Text = "ReadToEnd";
            btnLeerTodo.UseVisualStyleBackColor = true;
            btnLeerTodo.Click += btnLeerTodo_Click;
            // 
            // btnLeerCaracter
            // 
            btnLeerCaracter.Location = new Point(352, 290);
            btnLeerCaracter.Name = "btnLeerCaracter";
            btnLeerCaracter.Size = new Size(101, 30);
            btnLeerCaracter.TabIndex = 4;
            btnLeerCaracter.Text = "Read";
            btnLeerCaracter.UseVisualStyleBackColor = true;
            btnLeerCaracter.Click += btnLeerCaracter_Click;
            // 
            // btnSeleccionarArchivo
            // 
            btnSeleccionarArchivo.Location = new Point(12, 12);
            btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            btnSeleccionarArchivo.Size = new Size(140, 30);
            btnSeleccionarArchivo.TabIndex = 5;
            btnSeleccionarArchivo.Text = "Seleccionar archivo";
            btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            btnSeleccionarArchivo.Click += btnSeleccionarArchivo_Click;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(158, 20);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(131, 20);
            lblRuta.TabIndex = 6;
            lblRuta.Text = "(ruta del archivo...)";
            // 
            // btnFile
            // 
            btnFile.Location = new Point(12, 326);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(120, 30);
            btnFile.TabIndex = 7;
            btnFile.Text = "File";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.MouseClick += btnFile_MouseClick;
            // 
            // Form1
            // 
            ClientSize = new Size(584, 435);
            Controls.Add(btnFile);
            Controls.Add(lblRuta);
            Controls.Add(btnSeleccionarArchivo);
            Controls.Add(btnLeerCaracter);
            Controls.Add(btnLeerTodo);
            Controls.Add(btnLeerLinea);
            Controls.Add(btnGuardar);
            Controls.Add(txtContenido);
            Name = "Form1";
            Text = "Manejo de Ficheros con StreamReader";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnFile;
    }
}
