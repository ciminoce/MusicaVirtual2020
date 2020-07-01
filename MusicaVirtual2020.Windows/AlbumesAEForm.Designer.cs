namespace MusicaVirtual2020.Windows
{
    partial class AlbumesAEForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.temasDatosGridView = new System.Windows.Forms.DataGridView();
            this.cmnNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnBorrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.agregarTemaButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pistasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.agregarNegocioButton = new System.Windows.Forms.Button();
            this.agregarSoporteButton = new System.Windows.Forms.Button();
            this.agregarEstiloButton = new System.Windows.Forms.Button();
            this.agregarInterpreteButton = new System.Windows.Forms.Button();
            this.negocioComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.soporteComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.estiloComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.interpretesComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.anioCompraTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TituloTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temasDatosGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistasNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.temasDatosGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 355);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(984, 406);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CancelButton);
            this.panel4.Controls.Add(this.OkButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 76);
            this.panel4.TabIndex = 5;
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(566, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 53);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Aceptar;
            this.OkButton.Location = new System.Drawing.Point(325, 12);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 53);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // temasDatosGridView
            // 
            this.temasDatosGridView.AllowUserToAddRows = false;
            this.temasDatosGridView.AllowUserToDeleteRows = false;
            this.temasDatosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.temasDatosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnNro,
            this.cmnTema,
            this.cmnDuracion,
            this.cmnBorrar,
            this.cmnEditar});
            this.temasDatosGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temasDatosGridView.Location = new System.Drawing.Point(0, 0);
            this.temasDatosGridView.MultiSelect = false;
            this.temasDatosGridView.Name = "temasDatosGridView";
            this.temasDatosGridView.ReadOnly = true;
            this.temasDatosGridView.RowHeadersVisible = false;
            this.temasDatosGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.temasDatosGridView.Size = new System.Drawing.Size(984, 406);
            this.temasDatosGridView.TabIndex = 4;
            // 
            // cmnNro
            // 
            this.cmnNro.HeaderText = "Nro";
            this.cmnNro.Name = "cmnNro";
            this.cmnNro.ReadOnly = true;
            // 
            // cmnTema
            // 
            this.cmnTema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTema.HeaderText = "Tema";
            this.cmnTema.Name = "cmnTema";
            this.cmnTema.ReadOnly = true;
            // 
            // cmnDuracion
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cmnDuracion.DefaultCellStyle = dataGridViewCellStyle3;
            this.cmnDuracion.HeaderText = "Duración";
            this.cmnDuracion.Name = "cmnDuracion";
            this.cmnDuracion.ReadOnly = true;
            // 
            // cmnBorrar
            // 
            this.cmnBorrar.HeaderText = "";
            this.cmnBorrar.Name = "cmnBorrar";
            this.cmnBorrar.ReadOnly = true;
            // 
            // cmnEditar
            // 
            this.cmnEditar.HeaderText = "";
            this.cmnEditar.Name = "cmnEditar";
            this.cmnEditar.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.agregarTemaButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 54);
            this.panel3.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(53, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Temas";
            // 
            // agregarTemaButton
            // 
            this.agregarTemaButton.Enabled = false;
            this.agregarTemaButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.agregarTemaButton.Location = new System.Drawing.Point(941, 14);
            this.agregarTemaButton.Name = "agregarTemaButton";
            this.agregarTemaButton.Size = new System.Drawing.Size(31, 30);
            this.agregarTemaButton.TabIndex = 0;
            this.agregarTemaButton.UseVisualStyleBackColor = true;
            this.agregarTemaButton.Click += new System.EventHandler(this.agregarTemaButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pistasNumericUpDown);
            this.panel2.Controls.Add(this.agregarNegocioButton);
            this.panel2.Controls.Add(this.agregarSoporteButton);
            this.panel2.Controls.Add(this.agregarEstiloButton);
            this.panel2.Controls.Add(this.agregarInterpreteButton);
            this.panel2.Controls.Add(this.negocioComboBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.soporteComboBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.estiloComboBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.interpretesComboBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.costoTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.anioCompraTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TituloTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 242);
            this.panel2.TabIndex = 6;
            // 
            // pistasNumericUpDown
            // 
            this.pistasNumericUpDown.Location = new System.Drawing.Point(89, 172);
            this.pistasNumericUpDown.Name = "pistasNumericUpDown";
            this.pistasNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.pistasNumericUpDown.TabIndex = 4;
            this.pistasNumericUpDown.ValueChanged += new System.EventHandler(this.pistasNumericUpDown_ValueChanged);
            // 
            // agregarNegocioButton
            // 
            this.agregarNegocioButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.agregarNegocioButton.Location = new System.Drawing.Point(932, 131);
            this.agregarNegocioButton.Name = "agregarNegocioButton";
            this.agregarNegocioButton.Size = new System.Drawing.Size(31, 30);
            this.agregarNegocioButton.TabIndex = 15;
            this.agregarNegocioButton.UseVisualStyleBackColor = true;
            // 
            // agregarSoporteButton
            // 
            this.agregarSoporteButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.agregarSoporteButton.Location = new System.Drawing.Point(442, 131);
            this.agregarSoporteButton.Name = "agregarSoporteButton";
            this.agregarSoporteButton.Size = new System.Drawing.Size(31, 30);
            this.agregarSoporteButton.TabIndex = 15;
            this.agregarSoporteButton.UseVisualStyleBackColor = true;
            // 
            // agregarEstiloButton
            // 
            this.agregarEstiloButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.agregarEstiloButton.Location = new System.Drawing.Point(442, 91);
            this.agregarEstiloButton.Name = "agregarEstiloButton";
            this.agregarEstiloButton.Size = new System.Drawing.Size(31, 30);
            this.agregarEstiloButton.TabIndex = 15;
            this.agregarEstiloButton.UseVisualStyleBackColor = true;
            // 
            // agregarInterpreteButton
            // 
            this.agregarInterpreteButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.AgregarAE;
            this.agregarInterpreteButton.Location = new System.Drawing.Point(442, 53);
            this.agregarInterpreteButton.Name = "agregarInterpreteButton";
            this.agregarInterpreteButton.Size = new System.Drawing.Size(31, 30);
            this.agregarInterpreteButton.TabIndex = 15;
            this.agregarInterpreteButton.UseVisualStyleBackColor = true;
            // 
            // negocioComboBox
            // 
            this.negocioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.negocioComboBox.FormattingEnabled = true;
            this.negocioComboBox.Location = new System.Drawing.Point(579, 137);
            this.negocioComboBox.Name = "negocioComboBox";
            this.negocioComboBox.Size = new System.Drawing.Size(332, 21);
            this.negocioComboBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Negocio:";
            // 
            // soporteComboBox
            // 
            this.soporteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soporteComboBox.FormattingEnabled = true;
            this.soporteComboBox.Location = new System.Drawing.Point(89, 137);
            this.soporteComboBox.Name = "soporteComboBox";
            this.soporteComboBox.Size = new System.Drawing.Size(332, 21);
            this.soporteComboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Soporte:";
            // 
            // estiloComboBox
            // 
            this.estiloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estiloComboBox.FormattingEnabled = true;
            this.estiloComboBox.Location = new System.Drawing.Point(89, 97);
            this.estiloComboBox.Name = "estiloComboBox";
            this.estiloComboBox.Size = new System.Drawing.Size(332, 21);
            this.estiloComboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Estilo:";
            // 
            // interpretesComboBox
            // 
            this.interpretesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interpretesComboBox.FormattingEnabled = true;
            this.interpretesComboBox.Location = new System.Drawing.Point(89, 59);
            this.interpretesComboBox.Name = "interpretesComboBox";
            this.interpretesComboBox.Size = new System.Drawing.Size(332, 21);
            this.interpretesComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Intérprete:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pistas:";
            // 
            // costoTextBox
            // 
            this.costoTextBox.Location = new System.Drawing.Point(579, 194);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(90, 20);
            this.costoTextBox.TabIndex = 7;
            this.costoTextBox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Costo:";
            // 
            // anioCompraTextBox
            // 
            this.anioCompraTextBox.Location = new System.Drawing.Point(579, 168);
            this.anioCompraTextBox.Name = "anioCompraTextBox";
            this.anioCompraTextBox.Size = new System.Drawing.Size(90, 20);
            this.anioCompraTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Año Compra:";
            // 
            // TituloTextBox
            // 
            this.TituloTextBox.Location = new System.Drawing.Point(89, 19);
            this.TituloTextBox.Name = "TituloTextBox";
            this.TituloTextBox.Size = new System.Drawing.Size(592, 20);
            this.TituloTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Título:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 59);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AlbumesAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlbumesAEForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumesAEForm";
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temasDatosGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistasNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridView temasDatosGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button agregarTemaButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown pistasNumericUpDown;
        private System.Windows.Forms.Button agregarNegocioButton;
        private System.Windows.Forms.Button agregarSoporteButton;
        private System.Windows.Forms.Button agregarEstiloButton;
        private System.Windows.Forms.Button agregarInterpreteButton;
        private System.Windows.Forms.ComboBox negocioComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox soporteComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox estiloComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox interpretesComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox anioCompraTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TituloTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDuracion;
        private System.Windows.Forms.DataGridViewImageColumn cmnBorrar;
        private System.Windows.Forms.DataGridViewImageColumn cmnEditar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}