namespace pryEstructuraDatos
{
    partial class frmArbolBinario
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mrcNuevo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.trvVer = new System.Windows.Forms.TreeView();
            this.optInOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optInOrdenDes = new System.Windows.Forms.RadioButton();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv1.Location = new System.Drawing.Point(285, 315);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(491, 260);
            this.dgv1.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.Name = "Column3";
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.cmb1);
            this.mrcElementoEliminado.Controls.Add(this.btnEliminar);
            this.mrcElementoEliminado.Controls.Add(this.label6);
            this.mrcElementoEliminado.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcElementoEliminado.Location = new System.Drawing.Point(541, 16);
            this.mrcElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcElementoEliminado.Size = new System.Drawing.Size(234, 139);
            this.mrcElementoEliminado.TabIndex = 14;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(100, 35);
            this.cmb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(111, 25);
            this.cmb1.TabIndex = 13;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(21, 76);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(191, 42);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Código";
            // 
            // mrcNuevo
            // 
            this.mrcNuevo.Controls.Add(this.label1);
            this.mrcNuevo.Controls.Add(this.label3);
            this.mrcNuevo.Controls.Add(this.label4);
            this.mrcNuevo.Controls.Add(this.txtTramite);
            this.mrcNuevo.Controls.Add(this.txtNombre);
            this.mrcNuevo.Controls.Add(this.txtCodigo);
            this.mrcNuevo.Controls.Add(this.btnAgregar);
            this.mrcNuevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcNuevo.Location = new System.Drawing.Point(285, 16);
            this.mrcNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcNuevo.Name = "mrcNuevo";
            this.mrcNuevo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcNuevo.Size = new System.Drawing.Size(237, 292);
            this.mrcNuevo.TabIndex = 13;
            this.mrcNuevo.TabStop = false;
            this.mrcNuevo.Text = "Nuevo Elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Trámite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(113, 139);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(116, 23);
            this.txtTramite.TabIndex = 3;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 86);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 35);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 224);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(191, 42);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(562, 239);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(191, 42);
            this.btnEquilibrar.TabIndex = 14;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // trvVer
            // 
            this.trvVer.Location = new System.Drawing.Point(14, 16);
            this.trvVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trvVer.Name = "trvVer";
            this.trvVer.Size = new System.Drawing.Size(242, 290);
            this.trvVer.TabIndex = 16;
            // 
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInOrden.Location = new System.Drawing.Point(72, 340);
            this.optInOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(150, 21);
            this.optInOrden.TabIndex = 17;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "In-Orden Ascendente";
            this.optInOrden.UseVisualStyleBackColor = true;
            this.optInOrden.CheckedChanged += new System.EventHandler(this.optInOrden_CheckedChanged);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPreOrden.Location = new System.Drawing.Point(72, 429);
            this.optPreOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(87, 21);
            this.optPreOrden.TabIndex = 18;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.CheckedChanged += new System.EventHandler(this.optPreOrden_CheckedChanged);
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPostOrden.Location = new System.Drawing.Point(72, 473);
            this.optPostOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(93, 21);
            this.optPostOrden.TabIndex = 19;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            // 
            // optInOrdenDes
            // 
            this.optInOrdenDes.AutoSize = true;
            this.optInOrdenDes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInOrdenDes.Location = new System.Drawing.Point(72, 383);
            this.optInOrdenDes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optInOrdenDes.Name = "optInOrdenDes";
            this.optInOrdenDes.Size = new System.Drawing.Size(158, 21);
            this.optInOrdenDes.TabIndex = 20;
            this.optInOrdenDes.TabStop = true;
            this.optInOrdenDes.Text = "In-Orden Descendente";
            this.optInOrdenDes.UseVisualStyleBackColor = true;
            this.optInOrdenDes.CheckedChanged += new System.EventHandler(this.optInOrdenDes_CheckedChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(14, 533);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 42);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 588);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.optInOrdenDes);
            this.Controls.Add(this.optPostOrden);
            this.Controls.Add(this.optPreOrden);
            this.Controls.Add(this.optInOrden);
            this.Controls.Add(this.trvVer);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevo);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArbolBinario";
            this.Text = "frmArbolBinario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevo.ResumeLayout(false);
            this.mrcNuevo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox mrcNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.TreeView trvVer;
        private System.Windows.Forms.RadioButton optInOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optInOrdenDes;
        private System.Windows.Forms.Button btnVolver;
    }
}