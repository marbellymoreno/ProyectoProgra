namespace Capa_desconectada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarNt = new System.Windows.Forms.Button();
            this.tbBusquedaNt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerNoTipado = new System.Windows.Forms.Button();
            this.gridNotipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTipado = new System.Windows.Forms.Button();
            this.tboxBuscarTipado = new System.Windows.Forms.TextBox();
            this.btnObtenerTipado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxContactName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxAddres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.btnInsertarT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertarT);
            this.groupBox1.Controls.Add(this.btnBuscarNt);
            this.groupBox1.Controls.Add(this.tbBusquedaNt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnObtenerNoTipado);
            this.groupBox1.Controls.Add(this.gridNotipado);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(851, 729);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet no Tipado";
            // 
            // btnBuscarNt
            // 
            this.btnBuscarNt.Location = new System.Drawing.Point(54, 642);
            this.btnBuscarNt.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarNt.Name = "btnBuscarNt";
            this.btnBuscarNt.Size = new System.Drawing.Size(336, 44);
            this.btnBuscarNt.TabIndex = 4;
            this.btnBuscarNt.Text = "Buscar";
            this.btnBuscarNt.UseVisualStyleBackColor = true;
            this.btnBuscarNt.Click += new System.EventHandler(this.btnBuscarNt_Click);
            // 
            // tbBusquedaNt
            // 
            this.tbBusquedaNt.Location = new System.Drawing.Point(374, 571);
            this.tbBusquedaNt.Margin = new System.Windows.Forms.Padding(6);
            this.tbBusquedaNt.Name = "tbBusquedaNt";
            this.tbBusquedaNt.Size = new System.Drawing.Size(249, 31);
            this.tbBusquedaNt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 577);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(54, 485);
            this.btnObtenerNoTipado.Margin = new System.Windows.Forms.Padding(6);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(737, 54);
            this.btnObtenerNoTipado.TabIndex = 1;
            this.btnObtenerNoTipado.Text = "Obtener no Tipado";
            this.btnObtenerNoTipado.UseVisualStyleBackColor = true;
            this.btnObtenerNoTipado.Click += new System.EventHandler(this.btnObtenerNoTipado_Click);
            // 
            // gridNotipado
            // 
            this.gridNotipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNotipado.Location = new System.Drawing.Point(54, 37);
            this.gridNotipado.Margin = new System.Windows.Forms.Padding(6);
            this.gridNotipado.Name = "gridNotipado";
            this.gridNotipado.RowHeadersWidth = 82;
            this.gridNotipado.Size = new System.Drawing.Size(737, 410);
            this.gridNotipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarTipado);
            this.groupBox2.Controls.Add(this.tboxBuscarTipado);
            this.groupBox2.Controls.Add(this.btnObtenerTipado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.gridTipado);
            this.groupBox2.Location = new System.Drawing.Point(924, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(848, 729);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet Tipado";
            // 
            // btnBuscarTipado
            // 
            this.btnBuscarTipado.Location = new System.Drawing.Point(218, 642);
            this.btnBuscarTipado.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarTipado.Name = "btnBuscarTipado";
            this.btnBuscarTipado.Size = new System.Drawing.Size(421, 44);
            this.btnBuscarTipado.TabIndex = 7;
            this.btnBuscarTipado.Text = "Buscar";
            this.btnBuscarTipado.UseVisualStyleBackColor = true;
            this.btnBuscarTipado.Click += new System.EventHandler(this.btnBuscarTipado_Click);
            // 
            // tboxBuscarTipado
            // 
            this.tboxBuscarTipado.Location = new System.Drawing.Point(374, 571);
            this.tboxBuscarTipado.Margin = new System.Windows.Forms.Padding(6);
            this.tboxBuscarTipado.Name = "tboxBuscarTipado";
            this.tboxBuscarTipado.Size = new System.Drawing.Size(261, 31);
            this.tboxBuscarTipado.TabIndex = 6;
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(50, 485);
            this.btnObtenerTipado.Margin = new System.Windows.Forms.Padding(6);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.Size = new System.Drawing.Size(749, 54);
            this.btnObtenerTipado.TabIndex = 2;
            this.btnObtenerTipado.Text = "Obtener Tipado";
            this.btnObtenerTipado.UseVisualStyleBackColor = true;
            this.btnObtenerTipado.Click += new System.EventHandler(this.btnObtenerTipado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 577);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer ID";
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(50, 37);
            this.gridTipado.Margin = new System.Windows.Forms.Padding(6);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.RowHeadersWidth = 82;
            this.gridTipado.Size = new System.Drawing.Size(749, 410);
            this.gridTipado.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1788, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.Location = new System.Drawing.Point(1955, 56);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(274, 31);
            this.tboxCustomerID.TabIndex = 3;
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.Location = new System.Drawing.Point(1955, 130);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(274, 31);
            this.tboxCompanyName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1788, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Company Name";
            // 
            // tboxContactName
            // 
            this.tboxContactName.Location = new System.Drawing.Point(1955, 204);
            this.tboxContactName.Name = "tboxContactName";
            this.tboxContactName.Size = new System.Drawing.Size(274, 31);
            this.tboxContactName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1788, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contact Name";
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.Location = new System.Drawing.Point(1955, 278);
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(274, 31);
            this.tboxContactTitle.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1788, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contact Title";
            // 
            // tboxAddres
            // 
            this.tboxAddres.Location = new System.Drawing.Point(1955, 353);
            this.tboxAddres.Name = "tboxAddres";
            this.tboxAddres.Size = new System.Drawing.Size(274, 31);
            this.tboxAddres.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1797, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Addres";
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(1877, 426);
            this.btnInsertarCliente.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(319, 44);
            this.btnInsertarCliente.TabIndex = 12;
            this.btnInsertarCliente.Text = "Enviar";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // btnInsertarT
            // 
            this.btnInsertarT.Location = new System.Drawing.Point(455, 642);
            this.btnInsertarT.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsertarT.Name = "btnInsertarT";
            this.btnInsertarT.Size = new System.Drawing.Size(336, 44);
            this.btnInsertarT.TabIndex = 5;
            this.btnInsertarT.Text = "Enviar";
            this.btnInsertarT.UseVisualStyleBackColor = true;
            this.btnInsertarT.Click += new System.EventHandler(this.btnInsertarT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2241, 783);
            this.Controls.Add(this.btnInsertarCliente);
            this.Controls.Add(this.tboxAddres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxContactName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObtenerNoTipado;
        private System.Windows.Forms.DataGridView gridNotipado;
        private System.Windows.Forms.Button btnObtenerTipado;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Button btnBuscarNt;
        private System.Windows.Forms.TextBox tbBusquedaNt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarTipado;
        private System.Windows.Forms.TextBox tboxBuscarTipado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.TextBox tboxCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxContactName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxAddres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.Button btnInsertarT;
    }
}

