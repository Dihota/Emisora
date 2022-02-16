
namespace CapaPresentacionn
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip menuStrip1;
            this.aRTISTAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cANCIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.artistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnArtista = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBucarArtista = new System.Windows.Forms.Button();
            this.txtFiltroArtista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnAgregarArtista = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCasa = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvArtista = new System.Windows.Forms.DataGridView();
            this.pnCancion = new System.Windows.Forms.Panel();
            this.btnEliminarCancion = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnagregarCancion = new System.Windows.Forms.Button();
            this.pnAgregarCancion = new System.Windows.Forms.Panel();
            this.btnAddCancion = new System.Windows.Forms.Button();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtcancion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFiltrarCancion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCancion = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.pnArtista.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnAgregarArtista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtista)).BeginInit();
            this.pnCancion.SuspendLayout();
            this.pnAgregarCancion.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancion)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = System.Drawing.Color.Navy;
            menuStrip1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRTISTAToolStripMenuItem1,
            this.cANCIONToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 43);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aRTISTAToolStripMenuItem1
            // 
            this.aRTISTAToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.aRTISTAToolStripMenuItem1.Name = "aRTISTAToolStripMenuItem1";
            this.aRTISTAToolStripMenuItem1.Size = new System.Drawing.Size(88, 39);
            this.aRTISTAToolStripMenuItem1.Text = "ARTISTA";
            this.aRTISTAToolStripMenuItem1.Click += new System.EventHandler(this.aRTISTAToolStripMenuItem1_Click);
            // 
            // cANCIONToolStripMenuItem
            // 
            this.cANCIONToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cANCIONToolStripMenuItem.Name = "cANCIONToolStripMenuItem";
            this.cANCIONToolStripMenuItem.Size = new System.Drawing.Size(98, 39);
            this.cANCIONToolStripMenuItem.Text = "CANCION";
            this.cANCIONToolStripMenuItem.Click += new System.EventHandler(this.cANCIONToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sALIRToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(67, 39);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistaToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(109, 26);
            // 
            // artistaToolStripMenuItem
            // 
            this.artistaToolStripMenuItem.Name = "artistaToolStripMenuItem";
            this.artistaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.artistaToolStripMenuItem.Text = "Artista";
            // 
            // pnArtista
            // 
            this.pnArtista.BackColor = System.Drawing.Color.Transparent;
            this.pnArtista.Controls.Add(this.btnEliminar);
            this.pnArtista.Controls.Add(this.btnActualizar);
            this.pnArtista.Controls.Add(this.btnAgregar);
            this.pnArtista.Controls.Add(this.label1);
            this.pnArtista.Controls.Add(this.panel1);
            this.pnArtista.Controls.Add(this.pnAgregarArtista);
            this.pnArtista.Controls.Add(this.dgvArtista);
            this.pnArtista.Location = new System.Drawing.Point(1, 44);
            this.pnArtista.Name = "pnArtista";
            this.pnArtista.Size = new System.Drawing.Size(798, 407);
            this.pnArtista.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(225, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 31);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(117, 364);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 31);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(11, 364);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 31);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(353, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Artistas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBucarArtista);
            this.panel1.Controls.Add(this.txtFiltroArtista);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnBucarArtista
            // 
            this.btnBucarArtista.BackColor = System.Drawing.Color.DarkRed;
            this.btnBucarArtista.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBucarArtista.ForeColor = System.Drawing.Color.White;
            this.btnBucarArtista.Location = new System.Drawing.Point(323, 15);
            this.btnBucarArtista.Name = "btnBucarArtista";
            this.btnBucarArtista.Size = new System.Drawing.Size(91, 31);
            this.btnBucarArtista.TabIndex = 12;
            this.btnBucarArtista.Text = "Buscar";
            this.btnBucarArtista.UseVisualStyleBackColor = false;
            this.btnBucarArtista.Click += new System.EventHandler(this.btnBucarArtista_Click);
            // 
            // txtFiltroArtista
            // 
            this.txtFiltroArtista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltroArtista.Location = new System.Drawing.Point(94, 20);
            this.txtFiltroArtista.Name = "txtFiltroArtista";
            this.txtFiltroArtista.Size = new System.Drawing.Size(211, 20);
            this.txtFiltroArtista.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar :";
            // 
            // pnAgregarArtista
            // 
            this.pnAgregarArtista.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnAgregarArtista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnAgregarArtista.Controls.Add(this.btnGuardar);
            this.pnAgregarArtista.Controls.Add(this.txtCasa);
            this.pnAgregarArtista.Controls.Add(this.txtPais);
            this.pnAgregarArtista.Controls.Add(this.txtNombre);
            this.pnAgregarArtista.Controls.Add(this.label6);
            this.pnAgregarArtista.Controls.Add(this.label5);
            this.pnAgregarArtista.Controls.Add(this.label4);
            this.pnAgregarArtista.Controls.Add(this.label2);
            this.pnAgregarArtista.Location = new System.Drawing.Point(475, 41);
            this.pnAgregarArtista.Name = "pnAgregarArtista";
            this.pnAgregarArtista.Size = new System.Drawing.Size(304, 315);
            this.pnAgregarArtista.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(103, 219);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 31);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCasa
            // 
            this.txtCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCasa.Location = new System.Drawing.Point(7, 181);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(279, 20);
            this.txtCasa.TabIndex = 15;
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(7, 131);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(279, 20);
            this.txtPais.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(7, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(279, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(3, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Casa disquera :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(3, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pais :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Artistas";
            // 
            // dgvArtista
            // 
            this.dgvArtista.AllowUserToAddRows = false;
            this.dgvArtista.AllowUserToDeleteRows = false;
            this.dgvArtista.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvArtista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArtista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtista.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvArtista.Location = new System.Drawing.Point(11, 102);
            this.dgvArtista.Name = "dgvArtista";
            this.dgvArtista.Size = new System.Drawing.Size(458, 254);
            this.dgvArtista.TabIndex = 5;
            // 
            // pnCancion
            // 
            this.pnCancion.BackColor = System.Drawing.Color.Transparent;
            this.pnCancion.Controls.Add(this.btnEliminarCancion);
            this.pnCancion.Controls.Add(this.button4);
            this.pnCancion.Controls.Add(this.btnagregarCancion);
            this.pnCancion.Controls.Add(this.pnAgregarCancion);
            this.pnCancion.Controls.Add(this.panel2);
            this.pnCancion.Controls.Add(this.label7);
            this.pnCancion.Controls.Add(this.dgvCancion);
            this.pnCancion.Location = new System.Drawing.Point(4, 44);
            this.pnCancion.Name = "pnCancion";
            this.pnCancion.Size = new System.Drawing.Size(798, 407);
            this.pnCancion.TabIndex = 4;
            // 
            // btnEliminarCancion
            // 
            this.btnEliminarCancion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarCancion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCancion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCancion.Location = new System.Drawing.Point(233, 362);
            this.btnEliminarCancion.Name = "btnEliminarCancion";
            this.btnEliminarCancion.Size = new System.Drawing.Size(91, 31);
            this.btnEliminarCancion.TabIndex = 14;
            this.btnEliminarCancion.Text = "Eliminar";
            this.btnEliminarCancion.UseVisualStyleBackColor = false;
            this.btnEliminarCancion.Click += new System.EventHandler(this.btnEliminarCancion_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(125, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 31);
            this.button4.TabIndex = 13;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnagregarCancion
            // 
            this.btnagregarCancion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnagregarCancion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarCancion.ForeColor = System.Drawing.Color.White;
            this.btnagregarCancion.Location = new System.Drawing.Point(19, 362);
            this.btnagregarCancion.Name = "btnagregarCancion";
            this.btnagregarCancion.Size = new System.Drawing.Size(91, 31);
            this.btnagregarCancion.TabIndex = 12;
            this.btnagregarCancion.Text = "Agregar";
            this.btnagregarCancion.UseVisualStyleBackColor = false;
            this.btnagregarCancion.Click += new System.EventHandler(this.btnagregarCancion_Click);
            // 
            // pnAgregarCancion
            // 
            this.pnAgregarCancion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnAgregarCancion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnAgregarCancion.Controls.Add(this.comboBox1);
            this.pnAgregarCancion.Controls.Add(this.btnAddCancion);
            this.pnAgregarCancion.Controls.Add(this.txtDuracion);
            this.pnAgregarCancion.Controls.Add(this.txtcancion);
            this.pnAgregarCancion.Controls.Add(this.label9);
            this.pnAgregarCancion.Controls.Add(this.label10);
            this.pnAgregarCancion.Controls.Add(this.label11);
            this.pnAgregarCancion.Controls.Add(this.label12);
            this.pnAgregarCancion.Location = new System.Drawing.Point(488, 33);
            this.pnAgregarCancion.Name = "pnAgregarCancion";
            this.pnAgregarCancion.Size = new System.Drawing.Size(304, 319);
            this.pnAgregarCancion.TabIndex = 11;
            // 
            // btnAddCancion
            // 
            this.btnAddCancion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddCancion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancion.ForeColor = System.Drawing.Color.White;
            this.btnAddCancion.Location = new System.Drawing.Point(103, 219);
            this.btnAddCancion.Name = "btnAddCancion";
            this.btnAddCancion.Size = new System.Drawing.Size(91, 31);
            this.btnAddCancion.TabIndex = 16;
            this.btnAddCancion.Text = "Guardar";
            this.btnAddCancion.UseVisualStyleBackColor = false;
            this.btnAddCancion.Click += new System.EventHandler(this.btnAddCancion_Click);
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(7, 181);
            this.txtDuracion.MaxLength = 5;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(279, 20);
            this.txtDuracion.TabIndex = 15;
            this.txtDuracion.Text = "00:00";
            // 
            // txtcancion
            // 
            this.txtcancion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcancion.Location = new System.Drawing.Point(8, 131);
            this.txtcancion.Name = "txtcancion";
            this.txtcancion.Size = new System.Drawing.Size(279, 20);
            this.txtcancion.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(3, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Duracion :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumBlue;
            this.label10.Location = new System.Drawing.Point(3, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nombre cancion :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumBlue;
            this.label11.Location = new System.Drawing.Point(3, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Artista :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumBlue;
            this.label12.Location = new System.Drawing.Point(112, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "Artistas";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.btnFiltrarCancion);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(16, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 55);
            this.panel2.TabIndex = 10;
            // 
            // btnFiltrarCancion
            // 
            this.btnFiltrarCancion.BackColor = System.Drawing.Color.DarkRed;
            this.btnFiltrarCancion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCancion.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarCancion.Location = new System.Drawing.Point(323, 15);
            this.btnFiltrarCancion.Name = "btnFiltrarCancion";
            this.btnFiltrarCancion.Size = new System.Drawing.Size(91, 31);
            this.btnFiltrarCancion.TabIndex = 12;
            this.btnFiltrarCancion.Text = "Buscar";
            this.btnFiltrarCancion.UseVisualStyleBackColor = false;
            this.btnFiltrarCancion.Click += new System.EventHandler(this.btnFiltrarCancion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(15, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Buscar :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(351, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Canción";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgvCancion
            // 
            this.dgvCancion.AllowUserToAddRows = false;
            this.dgvCancion.AllowUserToDeleteRows = false;
            this.dgvCancion.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvCancion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCancion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancion.Location = new System.Drawing.Point(16, 96);
            this.dgvCancion.Name = "dgvCancion";
            this.dgvCancion.Size = new System.Drawing.Size(458, 256);
            this.dgvCancion.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(85, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(menuStrip1);
            this.Controls.Add(this.pnArtista);
            this.Controls.Add(this.pnCancion);
            this.MainMenuStrip = menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emisora";
            this.Load += new System.EventHandler(this.Form1_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.pnArtista.ResumeLayout(false);
            this.pnArtista.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnAgregarArtista.ResumeLayout(false);
            this.pnAgregarArtista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtista)).EndInit();
            this.pnCancion.ResumeLayout(false);
            this.pnCancion.PerformLayout();
            this.pnAgregarCancion.ResumeLayout(false);
            this.pnAgregarCancion.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem artistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRTISTAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cANCIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.Panel pnArtista;
        private System.Windows.Forms.DataGridView dgvArtista;
        private System.Windows.Forms.Panel pnCancion;
        private System.Windows.Forms.DataGridView dgvCancion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnAgregarArtista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBucarArtista;
        private System.Windows.Forms.TextBox txtFiltroArtista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCasa;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarCancion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnagregarCancion;
        private System.Windows.Forms.Panel pnAgregarCancion;
        private System.Windows.Forms.Button btnAddCancion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtcancion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFiltrarCancion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

