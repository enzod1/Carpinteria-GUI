namespace CarpinteriaFront.Presentacion;

partial class FormPresupuesto
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
        this.lbl_npresupuesto = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.txt_cliente = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.txt_descuento = new System.Windows.Forms.TextBox();
        this.cb_productos = new System.Windows.Forms.ComboBox();
        this.txt_cantidad = new System.Windows.Forms.TextBox();
        this.btn_agregar = new System.Windows.Forms.Button();
        this.dgv_detalles = new System.Windows.Forms.DataGridView();
        this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Col_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.col_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.col_acciones = new System.Windows.Forms.DataGridViewButtonColumn();
        this.label5 = new System.Windows.Forms.Label();
        this.txt_subtotal = new System.Windows.Forms.TextBox();
        this.txt_total = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.btn_aceptar = new System.Windows.Forms.Button();
        this.btn_cancelar = new System.Windows.Forms.Button();
        this.txt_fecha = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).BeginInit();
        this.SuspendLayout();
        // 
        // lbl_npresupuesto
        // 
        this.lbl_npresupuesto.AutoSize = true;
        this.lbl_npresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lbl_npresupuesto.Location = new System.Drawing.Point(49, 18);
        this.lbl_npresupuesto.Name = "lbl_npresupuesto";
        this.lbl_npresupuesto.Size = new System.Drawing.Size(114, 16);
        this.lbl_npresupuesto.TabIndex = 0;
        this.lbl_npresupuesto.Text = "Presupuesto N°";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(36, 62);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(40, 13);
        this.label2.TabIndex = 1;
        this.label2.Text = "Fecha:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(34, 95);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(42, 13);
        this.label3.TabIndex = 3;
        this.label3.Text = "Cliente:";
        // 
        // txt_cliente
        // 
        this.txt_cliente.Location = new System.Drawing.Point(79, 91);
        this.txt_cliente.Name = "txt_cliente";
        this.txt_cliente.Size = new System.Drawing.Size(507, 20);
        this.txt_cliente.TabIndex = 4;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(8, 128);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(68, 13);
        this.label4.TabIndex = 5;
        this.label4.Text = "%descuento:";
        // 
        // txt_descuento
        // 
        this.txt_descuento.Location = new System.Drawing.Point(79, 123);
        this.txt_descuento.Name = "txt_descuento";
        this.txt_descuento.Size = new System.Drawing.Size(100, 20);
        this.txt_descuento.TabIndex = 6;
        // 
        // cb_productos
        // 
        this.cb_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cb_productos.FormattingEnabled = true;
        this.cb_productos.Location = new System.Drawing.Point(12, 159);
        this.cb_productos.Name = "cb_productos";
        this.cb_productos.Size = new System.Drawing.Size(296, 21);
        this.cb_productos.TabIndex = 7;
        // 
        // txt_cantidad
        // 
        this.txt_cantidad.Location = new System.Drawing.Point(315, 159);
        this.txt_cantidad.Name = "txt_cantidad";
        this.txt_cantidad.Size = new System.Drawing.Size(165, 20);
        this.txt_cantidad.TabIndex = 8;
        // 
        // btn_agregar
        // 
        this.btn_agregar.Location = new System.Drawing.Point(486, 156);
        this.btn_agregar.Name = "btn_agregar";
        this.btn_agregar.Size = new System.Drawing.Size(100, 23);
        this.btn_agregar.TabIndex = 9;
        this.btn_agregar.Text = "Agregar";
        this.btn_agregar.UseVisualStyleBackColor = true;
        this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
        // 
        // dgv_detalles
        // 
        this.dgv_detalles.AllowUserToAddRows = false;
        this.dgv_detalles.AllowUserToDeleteRows = false;
        this.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgv_detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.col_id,
        this.Col_producto,
        this.col_precio,
        this.col_cantidad,
        this.col_acciones});
        this.dgv_detalles.Location = new System.Drawing.Point(11, 202);
        this.dgv_detalles.Name = "dgv_detalles";
        this.dgv_detalles.ReadOnly = true;
        this.dgv_detalles.Size = new System.Drawing.Size(575, 150);
        this.dgv_detalles.TabIndex = 10;
        this.dgv_detalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalles_CellContentClick);
        // 
        // col_id
        // 
        this.col_id.HeaderText = "id";
        this.col_id.Name = "col_id";
        this.col_id.ReadOnly = true;
        this.col_id.Visible = false;
        // 
        // Col_producto
        // 
        this.Col_producto.HeaderText = "Producto";
        this.Col_producto.Name = "Col_producto";
        this.Col_producto.ReadOnly = true;
        this.Col_producto.Width = 222;
        // 
        // col_precio
        // 
        this.col_precio.HeaderText = "Precio";
        this.col_precio.Name = "col_precio";
        this.col_precio.ReadOnly = true;
        // 
        // col_cantidad
        // 
        this.col_cantidad.HeaderText = "Cantidad";
        this.col_cantidad.Name = "col_cantidad";
        this.col_cantidad.ReadOnly = true;
        // 
        // col_acciones
        // 
        this.col_acciones.HeaderText = "Acciones";
        this.col_acciones.Name = "col_acciones";
        this.col_acciones.ReadOnly = true;
        this.col_acciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        this.col_acciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
        this.col_acciones.Width = 110;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label5.Location = new System.Drawing.Point(420, 383);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(69, 13);
        this.label5.TabIndex = 11;
        this.label5.Text = "SubTotal $";
        // 
        // txt_subtotal
        // 
        this.txt_subtotal.Enabled = false;
        this.txt_subtotal.Location = new System.Drawing.Point(486, 380);
        this.txt_subtotal.Name = "txt_subtotal";
        this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
        this.txt_subtotal.TabIndex = 12;
        // 
        // txt_total
        // 
        this.txt_total.Enabled = false;
        this.txt_total.Location = new System.Drawing.Point(486, 408);
        this.txt_total.Name = "txt_total";
        this.txt_total.Size = new System.Drawing.Size(100, 20);
        this.txt_total.TabIndex = 13;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label6.Location = new System.Drawing.Point(439, 412);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(47, 13);
        this.label6.TabIndex = 14;
        this.label6.Text = "Total $";
        // 
        // btn_aceptar
        // 
        this.btn_aceptar.Location = new System.Drawing.Point(160, 457);
        this.btn_aceptar.Name = "btn_aceptar";
        this.btn_aceptar.Size = new System.Drawing.Size(124, 23);
        this.btn_aceptar.TabIndex = 15;
        this.btn_aceptar.Text = "Aceptar";
        this.btn_aceptar.UseVisualStyleBackColor = true;
        this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
        // 
        // btn_cancelar
        // 
        this.btn_cancelar.Location = new System.Drawing.Point(314, 457);
        this.btn_cancelar.Name = "btn_cancelar";
        this.btn_cancelar.Size = new System.Drawing.Size(124, 23);
        this.btn_cancelar.TabIndex = 16;
        this.btn_cancelar.Text = "Cancelar";
        this.btn_cancelar.UseVisualStyleBackColor = true;
        this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
        // 
        // txt_fecha
        // 
        this.txt_fecha.Enabled = false;
        this.txt_fecha.Location = new System.Drawing.Point(83, 62);
        this.txt_fecha.Name = "txt_fecha";
        this.txt_fecha.Size = new System.Drawing.Size(100, 20);
        this.txt_fecha.TabIndex = 17;
        // 
        // FormPresupuesto
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(599, 491);
        this.Controls.Add(this.txt_fecha);
        this.Controls.Add(this.btn_cancelar);
        this.Controls.Add(this.btn_aceptar);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.txt_total);
        this.Controls.Add(this.txt_subtotal);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.dgv_detalles);
        this.Controls.Add(this.btn_agregar);
        this.Controls.Add(this.txt_cantidad);
        this.Controls.Add(this.cb_productos);
        this.Controls.Add(this.txt_descuento);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txt_cliente);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.lbl_npresupuesto);
        this.Name = "FormPresupuesto";
        this.Text = "Nuevo Presupuesto";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_npresupuesto;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt_cliente;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txt_descuento;
    private System.Windows.Forms.ComboBox cb_productos;
    private System.Windows.Forms.TextBox txt_cantidad;
    private System.Windows.Forms.Button btn_agregar;
    private System.Windows.Forms.DataGridView dgv_detalles;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txt_subtotal;
    private System.Windows.Forms.TextBox txt_total;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btn_aceptar;
    private System.Windows.Forms.Button btn_cancelar;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Col_producto;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_precio;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
    private System.Windows.Forms.DataGridViewButtonColumn col_acciones;
    private System.Windows.Forms.TextBox txt_fecha;
}