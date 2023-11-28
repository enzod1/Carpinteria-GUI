namespace CarpinteriaFront.Presentacion;

partial class FrmConsultarPresupuestos
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
        this.dgv_presupuestos = new System.Windows.Forms.DataGridView();
        this.col_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.col_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.col_acciones = new System.Windows.Forms.DataGridViewButtonColumn();
        this.btn_consultar = new System.Windows.Forms.Button();
        this.dtp_desde = new System.Windows.Forms.DateTimePicker();
        this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
        this.txt_cliente = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.btn_salir = new System.Windows.Forms.Button();
        this.btn_editar = new System.Windows.Forms.Button();
        this.grp_filtros = new System.Windows.Forms.GroupBox();
        this.btn_borrar = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dgv_presupuestos)).BeginInit();
        this.grp_filtros.SuspendLayout();
        this.SuspendLayout();
        // 
        // dgv_presupuestos
        // 
        this.dgv_presupuestos.AllowUserToAddRows = false;
        this.dgv_presupuestos.AllowUserToDeleteRows = false;
        this.dgv_presupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgv_presupuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.col_numero,
        this.col_fecha,
        this.col_cliente,
        this.col_total,
        this.col_acciones});
        this.dgv_presupuestos.Location = new System.Drawing.Point(13, 151);
        this.dgv_presupuestos.Name = "dgv_presupuestos";
        this.dgv_presupuestos.ReadOnly = true;
        this.dgv_presupuestos.Size = new System.Drawing.Size(775, 199);
        this.dgv_presupuestos.TabIndex = 0;
        this.dgv_presupuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        // 
        // col_numero
        // 
        this.col_numero.HeaderText = "Presupuesto N*";
        this.col_numero.Name = "col_numero";
        this.col_numero.ReadOnly = true;
        this.col_numero.Width = 105;
        // 
        // col_fecha
        // 
        this.col_fecha.HeaderText = "Fecha";
        this.col_fecha.Name = "col_fecha";
        this.col_fecha.ReadOnly = true;
        // 
        // col_cliente
        // 
        this.col_cliente.HeaderText = "Cliente";
        this.col_cliente.Name = "col_cliente";
        this.col_cliente.ReadOnly = true;
        this.col_cliente.Width = 327;
        // 
        // col_total
        // 
        this.col_total.HeaderText = "Total";
        this.col_total.Name = "col_total";
        this.col_total.ReadOnly = true;
        // 
        // col_acciones
        // 
        this.col_acciones.HeaderText = "Acciones";
        this.col_acciones.Name = "col_acciones";
        this.col_acciones.ReadOnly = true;
        this.col_acciones.Text = "Ver Detalles";
        this.col_acciones.UseColumnTextForButtonValue = true;
        // 
        // btn_consultar
        // 
        this.btn_consultar.Location = new System.Drawing.Point(662, 83);
        this.btn_consultar.Name = "btn_consultar";
        this.btn_consultar.Size = new System.Drawing.Size(75, 23);
        this.btn_consultar.TabIndex = 1;
        this.btn_consultar.Text = "Consulta";
        this.btn_consultar.UseVisualStyleBackColor = true;
        this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
        // 
        // dtp_desde
        // 
        this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtp_desde.Location = new System.Drawing.Point(105, 30);
        this.dtp_desde.Name = "dtp_desde";
        this.dtp_desde.Size = new System.Drawing.Size(102, 20);
        this.dtp_desde.TabIndex = 2;
        this.dtp_desde.ValueChanged += new System.EventHandler(this.dtp_desde_ValueChanged);
        // 
        // dtp_hasta
        // 
        this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtp_hasta.Location = new System.Drawing.Point(290, 30);
        this.dtp_hasta.Name = "dtp_hasta";
        this.dtp_hasta.Size = new System.Drawing.Size(102, 20);
        this.dtp_hasta.TabIndex = 3;
        // 
        // txt_cliente
        // 
        this.txt_cliente.Location = new System.Drawing.Point(74, 84);
        this.txt_cliente.Name = "txt_cliente";
        this.txt_cliente.Size = new System.Drawing.Size(556, 20);
        this.txt_cliente.TabIndex = 4;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(30, 34);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(72, 13);
        this.label1.TabIndex = 5;
        this.label1.Text = "Fecha desde:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(218, 34);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(69, 13);
        this.label2.TabIndex = 6;
        this.label2.Text = "Fecha hasta:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(30, 88);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(39, 13);
        this.label3.TabIndex = 7;
        this.label3.Text = "Cliente";
        // 
        // btn_salir
        // 
        this.btn_salir.Location = new System.Drawing.Point(713, 415);
        this.btn_salir.Name = "btn_salir";
        this.btn_salir.Size = new System.Drawing.Size(75, 23);
        this.btn_salir.TabIndex = 8;
        this.btn_salir.Text = "Salir";
        this.btn_salir.UseVisualStyleBackColor = true;
        // 
        // btn_editar
        // 
        this.btn_editar.Location = new System.Drawing.Point(14, 392);
        this.btn_editar.Name = "btn_editar";
        this.btn_editar.Size = new System.Drawing.Size(75, 23);
        this.btn_editar.TabIndex = 9;
        this.btn_editar.Text = "Editar";
        this.btn_editar.UseVisualStyleBackColor = true;
        // 
        // grp_filtros
        // 
        this.grp_filtros.Controls.Add(this.dtp_hasta);
        this.grp_filtros.Controls.Add(this.btn_consultar);
        this.grp_filtros.Controls.Add(this.dtp_desde);
        this.grp_filtros.Controls.Add(this.label3);
        this.grp_filtros.Controls.Add(this.txt_cliente);
        this.grp_filtros.Controls.Add(this.label2);
        this.grp_filtros.Controls.Add(this.label1);
        this.grp_filtros.Location = new System.Drawing.Point(12, 12);
        this.grp_filtros.Name = "grp_filtros";
        this.grp_filtros.Size = new System.Drawing.Size(776, 133);
        this.grp_filtros.TabIndex = 10;
        this.grp_filtros.TabStop = false;
        this.grp_filtros.Text = "filtros";
        // 
        // btn_borrar
        // 
        this.btn_borrar.Location = new System.Drawing.Point(96, 392);
        this.btn_borrar.Name = "btn_borrar";
        this.btn_borrar.Size = new System.Drawing.Size(75, 23);
        this.btn_borrar.TabIndex = 11;
        this.btn_borrar.Text = "Eliminar";
        this.btn_borrar.UseVisualStyleBackColor = true;
        // 
        // FrmConsultarPresupuestos
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btn_borrar);
        this.Controls.Add(this.grp_filtros);
        this.Controls.Add(this.btn_editar);
        this.Controls.Add(this.btn_salir);
        this.Controls.Add(this.dgv_presupuestos);
        this.Name = "FrmConsultarPresupuestos";
        this.Text = "FrmConsultarPresupuestos";
        this.Load += new System.EventHandler(this.FrmConsultarPresupuestos_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgv_presupuestos)).EndInit();
        this.grp_filtros.ResumeLayout(false);
        this.grp_filtros.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgv_presupuestos;
    private System.Windows.Forms.Button btn_consultar;
    private System.Windows.Forms.DateTimePicker dtp_desde;
    private System.Windows.Forms.DateTimePicker dtp_hasta;
    private System.Windows.Forms.TextBox txt_cliente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btn_salir;
    private System.Windows.Forms.Button btn_editar;
    private System.Windows.Forms.GroupBox grp_filtros;
    private System.Windows.Forms.Button btn_borrar;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_numero;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
    private System.Windows.Forms.DataGridViewButtonColumn col_acciones;
}