namespace Neptuno2023.Windows
{
    partial class fmrPaises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPaises));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBNuevo = new System.Windows.Forms.ToolStripButton();
            this.TSBBorrar = new System.Windows.Forms.ToolStripButton();
            this.TSBEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBFiltrar = new System.Windows.Forms.ToolStripButton();
            this.TSBActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBCerrar = new System.Windows.Forms.ToolStripButton();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelGrilla = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBNuevo,
            this.TSBBorrar,
            this.TSBEditar,
            this.toolStripSeparator1,
            this.TSBFiltrar,
            this.TSBActualizar,
            this.toolStripSeparator2,
            this.TSBImprimir,
            this.toolStripSeparator3,
            this.TSBCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(652, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBNuevo
            // 
            this.TSBNuevo.Image = ((System.Drawing.Image)(resources.GetObject("TSBNuevo.Image")));
            this.TSBNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBNuevo.Name = "TSBNuevo";
            this.TSBNuevo.Size = new System.Drawing.Size(46, 35);
            this.TSBNuevo.Text = "Nuevo";
            this.TSBNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TSBBorrar
            // 
            this.TSBBorrar.Image = ((System.Drawing.Image)(resources.GetObject("TSBBorrar.Image")));
            this.TSBBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBBorrar.Name = "TSBBorrar";
            this.TSBBorrar.Size = new System.Drawing.Size(43, 35);
            this.TSBBorrar.Text = "Borrar";
            this.TSBBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TSBEditar
            // 
            this.TSBEditar.Image = ((System.Drawing.Image)(resources.GetObject("TSBEditar.Image")));
            this.TSBEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBEditar.Name = "TSBEditar";
            this.TSBEditar.Size = new System.Drawing.Size(41, 35);
            this.TSBEditar.Text = "Editar";
            this.TSBEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // TSBFiltrar
            // 
            this.TSBFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("TSBFiltrar.Image")));
            this.TSBFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBFiltrar.Name = "TSBFiltrar";
            this.TSBFiltrar.Size = new System.Drawing.Size(41, 35);
            this.TSBFiltrar.Text = "Filtrar";
            this.TSBFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TSBActualizar
            // 
            this.TSBActualizar.Image = ((System.Drawing.Image)(resources.GetObject("TSBActualizar.Image")));
            this.TSBActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBActualizar.Name = "TSBActualizar";
            this.TSBActualizar.Size = new System.Drawing.Size(63, 35);
            this.TSBActualizar.Text = "Actualizar";
            this.TSBActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // TSBImprimir
            // 
            this.TSBImprimir.Image = ((System.Drawing.Image)(resources.GetObject("TSBImprimir.Image")));
            this.TSBImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBImprimir.Name = "TSBImprimir";
            this.TSBImprimir.Size = new System.Drawing.Size(57, 35);
            this.TSBImprimir.Text = "Imprimir";
            this.TSBImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // TSBCerrar
            // 
            this.TSBCerrar.Image = ((System.Drawing.Image)(resources.GetObject("TSBCerrar.Image")));
            this.TSBCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCerrar.Name = "TSBCerrar";
            this.TSBCerrar.Size = new System.Drawing.Size(43, 35);
            this.TSBCerrar.Text = "Cerrar";
            this.TSBCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panelInferior
            // 
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 374);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(652, 50);
            this.panelInferior.TabIndex = 1;
            // 
            // panelGrilla
            // 
            this.panelGrilla.Controls.Add(this.dgvDatos);
            this.panelGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrilla.Location = new System.Drawing.Point(0, 38);
            this.panelGrilla.Name = "panelGrilla";
            this.panelGrilla.Size = new System.Drawing.Size(652, 336);
            this.panelGrilla.TabIndex = 2;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPais});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(652, 336);
            this.dgvDatos.TabIndex = 0;
            // 
            // colPais
            // 
            this.colPais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPais.HeaderText = "Pais";
            this.colPais.Name = "colPais";
            this.colPais.ReadOnly = true;
            // 
            // fmrPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 424);
            this.ControlBox = false;
            this.Controls.Add(this.panelGrilla);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(668, 463);
            this.MinimumSize = new System.Drawing.Size(668, 463);
            this.Name = "fmrPaises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrPaises";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBNuevo;
        private System.Windows.Forms.ToolStripButton TSBBorrar;
        private System.Windows.Forms.ToolStripButton TSBEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBFiltrar;
        private System.Windows.Forms.ToolStripButton TSBActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSBImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSBCerrar;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelGrilla;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
    }
}