﻿namespace pjVentaHeredada
{
    partial class frmCredito
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
            this.btnAdquirir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvResumen = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnResumen = new System.Windows.Forms.Button();
            this.cboLetras = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lvDetalle = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdquirir
            // 
            this.btnAdquirir.Location = new System.Drawing.Point(458, 220);
            this.btnAdquirir.Name = "btnAdquirir";
            this.btnAdquirir.Size = new System.Drawing.Size(75, 23);
            this.btnAdquirir.TabIndex = 15;
            this.btnAdquirir.Text = "ADQUIRIR";
            this.btnAdquirir.UseVisualStyleBackColor = true;
            this.btnAdquirir.Click += new System.EventHandler(this.btnAdquirir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboProducto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(42, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 88);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA VENTA";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(210, 52);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "CANTIDAD SOLICITADA";
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(0, 52);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(164, 23);
            this.cboProducto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "SELECCIONE UN PRODUCTO";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(525, 144);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 15);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(445, 144);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "FECHA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRUC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(41, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 87);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(210, 48);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(100, 23);
            this.txtRUC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUC";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(0, 48);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(164, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLIENTE O RAZON SOCIAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "VENTA DE PRODUCTOS AL CREDITO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvResumen);
            this.groupBox3.Controls.Add(this.btnResumen);
            this.groupBox3.Controls.Add(this.cboLetras);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(43, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 141);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OPCIONES DEL CREDITO";
            // 
            // lvResumen
            // 
            this.lvResumen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.lvResumen.GridLines = true;
            this.lvResumen.Location = new System.Drawing.Point(153, 22);
            this.lvResumen.Name = "lvResumen";
            this.lvResumen.Size = new System.Drawing.Size(309, 103);
            this.lvResumen.TabIndex = 3;
            this.lvResumen.UseCompatibleStateImageBehavior = false;
            this.lvResumen.View = System.Windows.Forms.View.Details;
            this.lvResumen.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "No.Letras";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Monto";
            this.columnHeader7.Width = 180;
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(14, 85);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(133, 23);
            this.btnResumen.TabIndex = 2;
            this.btnResumen.Text = "MOSTRAR RESUMEN";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // cboLetras
            // 
            this.cboLetras.FormattingEnabled = true;
            this.cboLetras.Location = new System.Drawing.Point(14, 56);
            this.cboLetras.Name = "cboLetras";
            this.cboLetras.Size = new System.Drawing.Size(121, 23);
            this.cboLetras.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "SELLECIONE LETRAS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(521, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "MONTO A PAGAR $";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonto.Location = new System.Drawing.Point(564, 467);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(66, 21);
            this.lblMonto.TabIndex = 20;
            this.lblMonto.Text = "label10";
            // 
            // lvDetalle
            // 
            this.lvDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDetalle.GridLines = true;
            this.lvDetalle.Location = new System.Drawing.Point(34, 297);
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.Size = new System.Drawing.Size(626, 97);
            this.lvDetalle.TabIndex = 21;
            this.lvDetalle.UseCompatibleStateImageBehavior = false;
            this.lvDetalle.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ITEM";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DESCRIPCION DEL PRODUCO";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CANTIDAD";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PRECIO";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SUBTOTAL";
            this.columnHeader5.Width = 120;
            // 
            // frmCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 615);
            this.Controls.Add(this.lvDetalle);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdquirir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCredito";
            this.Text = "frmCredito";
            this.Load += new System.EventHandler(this.frmCredito_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAdquirir;
        private GroupBox groupBox2;
        private TextBox txtCantidad;
        private Label label9;
        private ComboBox cboProducto;
        private Label label8;
        private Label lblHora;
        private Label label6;
        private Label lblFecha;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtRUC;
        private Label label3;
        private TextBox txtCliente;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private ListView lvResumen;
        private Button btnResumen;
        private ComboBox cboLetras;
        private Label label5;
        private Label label7;
        private Label lblMonto;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ListView lvDetalle;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}