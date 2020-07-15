namespace MusicaVirtual2020.Windows
{
    partial class AlbumesPorNegocioForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.CerrarlButton = new System.Windows.Forms.Button();
            this.cmnNegocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CerrarlButton);
            this.splitContainer1.Size = new System.Drawing.Size(865, 599);
            this.splitContainer1.SplitterDistance = 494;
            this.splitContainer1.TabIndex = 1;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnNegocio,
            this.cmnCantidad});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.Size = new System.Drawing.Size(865, 494);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // CerrarlButton
            // 
            this.CerrarlButton.Image = global::MusicaVirtual2020.Windows.Properties.Resources.Cancelar;
            this.CerrarlButton.Location = new System.Drawing.Point(756, 24);
            this.CerrarlButton.Name = "CerrarlButton";
            this.CerrarlButton.Size = new System.Drawing.Size(94, 53);
            this.CerrarlButton.TabIndex = 3;
            this.CerrarlButton.Text = "Cerrar";
            this.CerrarlButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CerrarlButton.UseVisualStyleBackColor = true;
            this.CerrarlButton.Click += new System.EventHandler(this.CerrarlButton_Click);
            // 
            // cmnNegocio
            // 
            this.cmnNegocio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnNegocio.HeaderText = "Negocio";
            this.cmnNegocio.Name = "cmnNegocio";
            this.cmnNegocio.ReadOnly = true;
            // 
            // cmnCantidad
            // 
            this.cmnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnCantidad.HeaderText = "Cantidad";
            this.cmnCantidad.Name = "cmnCantidad";
            this.cmnCantidad.ReadOnly = true;
            // 
            // AlbumesPorNegocioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 599);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AlbumesPorNegocioForm";
            this.Text = "AlbumesPorNegocioForm";
            this.Load += new System.EventHandler(this.AlbumesPorNegocioForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNegocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCantidad;
        private System.Windows.Forms.Button CerrarlButton;
    }
}