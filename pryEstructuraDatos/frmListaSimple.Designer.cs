﻿namespace pryEstructuraDatos
{
    partial class frmListaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaSimple));
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
            this.label7 = new System.Windows.Forms.Label();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv1.Location = new System.Drawing.Point(263, 250);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(421, 222);
            this.dgv1.TabIndex = 12;
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
            this.mrcElementoEliminado.Location = new System.Drawing.Point(483, 21);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(201, 106);
            this.mrcElementoEliminado.TabIndex = 11;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(86, 27);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(96, 25);
            this.cmb1.TabIndex = 13;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 58);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 32);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 32);
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
            this.mrcNuevo.Location = new System.Drawing.Point(263, 21);
            this.mrcNuevo.Name = "mrcNuevo";
            this.mrcNuevo.Size = new System.Drawing.Size(203, 223);
            this.mrcNuevo.TabIndex = 10;
            this.mrcNuevo.TabStop = false;
            this.mrcNuevo.Text = "Nuevo Elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Trámite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(97, 106);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 23);
            this.txtTramite.TabIndex = 3;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 171);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Listado en una lista y una grilla";
            // 
            // lst1
            // 
            this.lst1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 17;
            this.lst1.Location = new System.Drawing.Point(26, 276);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(216, 157);
            this.lst1.TabIndex = 13;
            // 
            // pcbImagen
            // 
            this.pcbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pcbImagen.Image")));
            this.pcbImagen.Location = new System.Drawing.Point(27, 16);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(215, 228);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 15;
            this.pcbImagen.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(26, 440);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 32);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 479);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevo);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Simple";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevo.ResumeLayout(false);
            this.mrcNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Button btnVolver;
    }
}