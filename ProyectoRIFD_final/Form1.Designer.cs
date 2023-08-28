namespace ProyectoRIFD_final
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idregistrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_RIFD_ProyectDataSet1 = new ProyectoRIFD_final.db_RIFD_ProyectDataSet1();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.tbcodigosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_codigosTableAdapter = new ProyectoRIFD_final.db_RIFD_ProyectDataSet1TableAdapters.tb_codigosTableAdapter();
            this.registrosTableAdapter = new ProyectoRIFD_final.db_RIFD_ProyectDataSet1TableAdapters.registrosTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnentrada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RIFD_ProyectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcodigosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idregistrosDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registrosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 247);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idregistrosDataGridViewTextBoxColumn
            // 
            this.idregistrosDataGridViewTextBoxColumn.DataPropertyName = "id_registros";
            this.idregistrosDataGridViewTextBoxColumn.HeaderText = "id_registros";
            this.idregistrosDataGridViewTextBoxColumn.Name = "idregistrosDataGridViewTextBoxColumn";
            this.idregistrosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // registrosBindingSource
            // 
            this.registrosBindingSource.DataMember = "registros";
            this.registrosBindingSource.DataSource = this.db_RIFD_ProyectDataSet1;
            // 
            // db_RIFD_ProyectDataSet1
            // 
            this.db_RIFD_ProyectDataSet1.DataSetName = "db_RIFD_ProyectDataSet1";
            this.db_RIFD_ProyectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(107, 23);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(143, 20);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "codigo de serie ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(19, 344);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(85, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Registar Usuario";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(107, 49);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(143, 20);
            this.txtusuario.TabIndex = 11;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // tbcodigosBindingSource
            // 
            this.tbcodigosBindingSource.DataMember = "tb_codigos";
            this.tbcodigosBindingSource.DataSource = this.db_RIFD_ProyectDataSet1;
            // 
            // tb_codigosTableAdapter
            // 
            this.tb_codigosTableAdapter.ClearBeforeFill = true;
            // 
            // registrosTableAdapter
            // 
            this.registrosTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnentrada
            // 
            this.btnentrada.Location = new System.Drawing.Point(256, 16);
            this.btnentrada.Name = "btnentrada";
            this.btnentrada.Size = new System.Drawing.Size(98, 40);
            this.btnentrada.TabIndex = 17;
            this.btnentrada.Text = "Registros";
            this.btnentrada.UseVisualStyleBackColor = true;
            this.btnentrada.Click += new System.EventHandler(this.btnentrada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 389);
            this.Controls.Add(this.btnentrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RIFD_ProyectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcodigosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusuario;
        private db_RIFD_ProyectDataSet1 db_RIFD_ProyectDataSet1;
        private System.Windows.Forms.BindingSource tbcodigosBindingSource;
        private db_RIFD_ProyectDataSet1TableAdapters.tb_codigosTableAdapter tb_codigosTableAdapter;
        private System.Windows.Forms.BindingSource registrosBindingSource;
        private db_RIFD_ProyectDataSet1TableAdapters.registrosTableAdapter registrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idregistrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnentrada;
    }
}

