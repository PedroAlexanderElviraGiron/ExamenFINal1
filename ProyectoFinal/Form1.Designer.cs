namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumero_Serie = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelPlataformas = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.buttonagregar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.buttoneexportar = new System.Windows.Forms.Button();
            this.buttonimportat = new System.Windows.Forms.Button();
            this.textBoxNumeroSerie = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxPlataformas = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttoncnsulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonObtenerDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumero_Serie
            // 
            this.labelNumero_Serie.AutoSize = true;
            this.labelNumero_Serie.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumero_Serie.Location = new System.Drawing.Point(12, 97);
            this.labelNumero_Serie.Name = "labelNumero_Serie";
            this.labelNumero_Serie.Size = new System.Drawing.Size(194, 27);
            this.labelNumero_Serie.TabIndex = 0;
            this.labelNumero_Serie.Text = "Numero Serie ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(7, 156);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(110, 27);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFecha.Location = new System.Drawing.Point(7, 201);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(244, 27);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha de Estreno ";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrecio.Location = new System.Drawing.Point(7, 248);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(99, 27);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "Precio";
            // 
            // labelPlataformas
            // 
            this.labelPlataformas.AutoSize = true;
            this.labelPlataformas.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlataformas.Location = new System.Drawing.Point(12, 306);
            this.labelPlataformas.Name = "labelPlataformas";
            this.labelPlataformas.Size = new System.Drawing.Size(181, 27);
            this.labelPlataformas.TabIndex = 4;
            this.labelPlataformas.Text = "Plataformas";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEdad.Location = new System.Drawing.Point(12, 353);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(383, 27);
            this.labelEdad.TabIndex = 5;
            this.labelEdad.Text = "Edad Minima de poder Jugar ";
            // 
            // buttonagregar
            // 
            this.buttonagregar.BackColor = System.Drawing.Color.Aqua;
            this.buttonagregar.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonagregar.ForeColor = System.Drawing.Color.Black;
            this.buttonagregar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonagregar.Location = new System.Drawing.Point(669, 164);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(235, 64);
            this.buttonagregar.TabIndex = 6;
            this.buttonagregar.Text = "Agregar Juego";
            this.buttonagregar.UseVisualStyleBackColor = false;
            this.buttonagregar.Click += new System.EventHandler(this.buttonagregar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.Aqua;
            this.buttoneliminar.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttoneliminar.ForeColor = System.Drawing.Color.Black;
            this.buttoneliminar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttoneliminar.Location = new System.Drawing.Point(300, 474);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(283, 68);
            this.buttoneliminar.TabIndex = 7;
            this.buttoneliminar.Text = "Eliminar Juego";
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.BackColor = System.Drawing.Color.Aqua;
            this.buttonactualizar.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonactualizar.Location = new System.Drawing.Point(35, 413);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(216, 61);
            this.buttonactualizar.TabIndex = 8;
            this.buttonactualizar.Text = "Actualizar";
            this.buttonactualizar.UseVisualStyleBackColor = false;
            this.buttonactualizar.Click += new System.EventHandler(this.buttonactualizar_Click);
            // 
            // buttoneexportar
            // 
            this.buttoneexportar.BackColor = System.Drawing.Color.Aqua;
            this.buttoneexportar.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttoneexportar.Location = new System.Drawing.Point(300, 413);
            this.buttoneexportar.Name = "buttoneexportar";
            this.buttoneexportar.Size = new System.Drawing.Size(169, 53);
            this.buttoneexportar.TabIndex = 9;
            this.buttoneexportar.Text = "Exportar";
            this.buttoneexportar.UseVisualStyleBackColor = false;
            this.buttoneexportar.Click += new System.EventHandler(this.buttoneexportar_Click);
            // 
            // buttonimportat
            // 
            this.buttonimportat.BackColor = System.Drawing.Color.Aqua;
            this.buttonimportat.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonimportat.Location = new System.Drawing.Point(35, 482);
            this.buttonimportat.Name = "buttonimportat";
            this.buttonimportat.Size = new System.Drawing.Size(169, 53);
            this.buttonimportat.TabIndex = 10;
            this.buttonimportat.Text = "Importar";
            this.buttonimportat.UseVisualStyleBackColor = false;
            this.buttonimportat.Click += new System.EventHandler(this.buttonimportat_Click);
            // 
            // textBoxNumeroSerie
            // 
            this.textBoxNumeroSerie.Location = new System.Drawing.Point(212, 99);
            this.textBoxNumeroSerie.Name = "textBoxNumeroSerie";
            this.textBoxNumeroSerie.Size = new System.Drawing.Size(429, 27);
            this.textBoxNumeroSerie.TabIndex = 11;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(212, 156);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(429, 27);
            this.textBoxNombre.TabIndex = 12;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(257, 201);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(384, 27);
            this.textBoxFecha.TabIndex = 13;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(212, 248);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(429, 27);
            this.textBoxPrecio.TabIndex = 14;
            // 
            // textBoxPlataformas
            // 
            this.textBoxPlataformas.Location = new System.Drawing.Point(212, 296);
            this.textBoxPlataformas.Name = "textBoxPlataformas";
            this.textBoxPlataformas.Size = new System.Drawing.Size(429, 27);
            this.textBoxPlataformas.TabIndex = 15;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(388, 353);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(253, 27);
            this.textBoxEdad.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 74);
            this.label1.TabIndex = 17;
            this.label1.Text = "VIDEOJUEGOS P&E";
            // 
            // buttoncnsulta
            // 
            this.buttoncnsulta.BackColor = System.Drawing.Color.Aqua;
            this.buttoncnsulta.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttoncnsulta.ForeColor = System.Drawing.Color.Black;
            this.buttoncnsulta.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttoncnsulta.Location = new System.Drawing.Point(669, 86);
            this.buttoncnsulta.Name = "buttoncnsulta";
            this.buttoncnsulta.Size = new System.Drawing.Size(297, 57);
            this.buttoncnsulta.TabIndex = 18;
            this.buttoncnsulta.Text = "Consultar Juego";
            this.buttoncnsulta.UseVisualStyleBackColor = false;
            this.buttoncnsulta.Click += new System.EventHandler(this.buttoncnsulta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(972, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(773, 549);
            this.dataGridView1.TabIndex = 19;
            // 
            // buttonObtenerDatos
            // 
            this.buttonObtenerDatos.BackColor = System.Drawing.Color.Aqua;
            this.buttonObtenerDatos.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonObtenerDatos.ForeColor = System.Drawing.Color.Black;
            this.buttonObtenerDatos.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonObtenerDatos.Location = new System.Drawing.Point(731, 476);
            this.buttonObtenerDatos.Name = "buttonObtenerDatos";
            this.buttonObtenerDatos.Size = new System.Drawing.Size(235, 64);
            this.buttonObtenerDatos.TabIndex = 20;
            this.buttonObtenerDatos.Text = "Obtener Datos ";
            this.buttonObtenerDatos.UseVisualStyleBackColor = false;
            this.buttonObtenerDatos.Click += new System.EventHandler(this.buttonObtenerDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1745, 547);
            this.Controls.Add(this.buttonObtenerDatos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttoncnsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textBoxPlataformas);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxNumeroSerie);
            this.Controls.Add(this.buttonimportat);
            this.Controls.Add(this.buttoneexportar);
            this.Controls.Add(this.buttonactualizar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonagregar);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelPlataformas);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNumero_Serie);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNumero_Serie;
        private Label labelNombre;
        private Label labelFecha;
        private Label labelPrecio;
        private Label labelPlataformas;
        private Label labelEdad;
        private Button buttonagregar;
        private Button buttoneliminar;
        private Button buttonactualizar;
        private Button buttoneexportar;
        private Button buttonimportat;
        private TextBox textBoxNumeroSerie;
        private TextBox textBoxNombre;
        private TextBox textBoxFecha;
        private TextBox textBoxPrecio;
        private TextBox textBoxPlataformas;
        private TextBox textBoxEdad;
        private Label label1;
        private Button buttoncnsulta;
        private DataGridView dataGridView1;
        private Button buttonObtenerDatos;
    }
}