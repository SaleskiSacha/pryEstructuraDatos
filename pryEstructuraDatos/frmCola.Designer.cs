﻿namespace pryEstructuraDatos
{
    partial class frmCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mrcNuevo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lsbMostrar = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mrcNuevo.SuspendLayout();
            this.mrcElementoEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(83, 26);
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
            this.mrcNuevo.Location = new System.Drawing.Point(227, 12);
            this.mrcNuevo.Name = "mrcNuevo";
            this.mrcNuevo.Size = new System.Drawing.Size(203, 223);
            this.mrcNuevo.TabIndex = 4;
            this.mrcNuevo.TabStop = false;
            this.mrcNuevo.Text = "Nuevo Elemento";
            this.mrcNuevo.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.txtTramite.Location = new System.Drawing.Point(83, 105);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 23);
            this.txtTramite.TabIndex = 3;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.lblTramite);
            this.mrcElementoEliminado.Controls.Add(this.lblNombre);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigo);
            this.mrcElementoEliminado.Controls.Add(this.btnEliminar);
            this.mrcElementoEliminado.Controls.Add(this.label2);
            this.mrcElementoEliminado.Controls.Add(this.label5);
            this.mrcElementoEliminado.Controls.Add(this.label6);
            this.mrcElementoEliminado.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcElementoEliminado.Location = new System.Drawing.Point(447, 12);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(201, 223);
            this.mrcElementoEliminado.TabIndex = 5;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            this.mrcElementoEliminado.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblTramite
            // 
            this.lblTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(103, 97);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(92, 19);
            this.lblTramite.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(103, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 19);
            this.lblNombre.TabIndex = 14;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(103, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(92, 19);
            this.lblCodigo.TabIndex = 13;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 171);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 32);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Trámite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Código";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv1.Location = new System.Drawing.Point(227, 241);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(421, 209);
            this.dgv1.TabIndex = 6;
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
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 223);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lsbMostrar
            // 
            this.lsbMostrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbMostrar.FormattingEnabled = true;
            this.lsbMostrar.ItemHeight = 17;
            this.lsbMostrar.Location = new System.Drawing.Point(5, 257);
            this.lsbMostrar.Name = "lsbMostrar";
            this.lsbMostrar.Size = new System.Drawing.Size(216, 157);
            this.lsbMostrar.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Listado en una lista y una grilla";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(5, 421);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 29);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 456);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lsbMostrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevo);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCola";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.mrcNuevo.ResumeLayout(false);
            this.mrcNuevo.PerformLayout();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox mrcNuevo;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbMostrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnVolver;
    }
}