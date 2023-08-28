namespace ProyectoRIFD_final
{
    partial class frm_usuario
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
            this.components = new System.ComponentModel.Container();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbusuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_RIFD_ProyectDataSet = new ProyectoRIFD_final.db_RIFD_ProyectDataSet();
            this.tb_usuariosTableAdapter = new ProyectoRIFD_final.db_RIFD_ProyectDataSetTableAdapters.tb_usuariosTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RIFD_ProyectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(55, 63);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(118, 26);
            this.txtcodigo.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(259, 63);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 26);
            this.txtnombre.TabIndex = 2;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(458, 63);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 26);
            this.txtcontraseña.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Registar Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcodigoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbusuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 245);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idcodigoDataGridViewTextBoxColumn
            // 
            this.idcodigoDataGridViewTextBoxColumn.DataPropertyName = "Id_codigo";
            this.idcodigoDataGridViewTextBoxColumn.HeaderText = "Id_codigo";
            this.idcodigoDataGridViewTextBoxColumn.Name = "idcodigoDataGridViewTextBoxColumn";
            this.idcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // tbusuariosBindingSource
            // 
            this.tbusuariosBindingSource.DataMember = "tb_usuarios";
            this.tbusuariosBindingSource.DataSource = this.db_RIFD_ProyectDataSet;
            // 
            // db_RIFD_ProyectDataSet
            // 
            this.db_RIFD_ProyectDataSet.DataSetName = "db_RIFD_ProyectDataSet";
            this.db_RIFD_ProyectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_usuariosTableAdapter
            // 
            this.tb_usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Name = "frm_usuario";
            this.Text = "frm_usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_usuario_FormClosing);
            this.Load += new System.EventHandler(this.frm_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RIFD_ProyectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_RIFD_ProyectDataSet db_RIFD_ProyectDataSet;
        private System.Windows.Forms.BindingSource tbusuariosBindingSource;
        private db_RIFD_ProyectDataSetTableAdapters.tb_usuariosTableAdapter tb_usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}