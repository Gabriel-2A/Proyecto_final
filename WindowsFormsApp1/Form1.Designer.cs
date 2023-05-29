

namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarComoCompletadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.BotonFiltrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.FiltrarCategoria = new System.Windows.Forms.ToolStripComboBox();
            this.aceparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Boton_Informe = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.marcarComoCompletadaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(251, 76);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // marcarComoCompletadaToolStripMenuItem
            // 
            this.marcarComoCompletadaToolStripMenuItem.Name = "marcarComoCompletadaToolStripMenuItem";
            this.marcarComoCompletadaToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.marcarComoCompletadaToolStripMenuItem.Text = "Marcar como completada";
            this.marcarComoCompletadaToolStripMenuItem.Click += new System.EventHandler(this.marcarComoCompletadaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Tomato;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.BotonFiltrar,
            this.toolStripDropDownButton1,
            this.Boton_Informe});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(144, 522);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.OldLace;
            this.toolStripButton1.Image = global::WindowsFormsApp1.Properties.Resources.aggretsuko_metal_waifu2x_art_noise3_scale;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.LavenderBlush;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(127, 24);
            this.toolStripButton1.Text = "Agregar Tarea";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // BotonFiltrar
            // 
            this.BotonFiltrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiltrarCategoria,
            this.aceparToolStripMenuItem});
            this.BotonFiltrar.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonFiltrar.ForeColor = System.Drawing.Color.OldLace;
            this.BotonFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("BotonFiltrar.Image")));
            this.BotonFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonFiltrar.Name = "BotonFiltrar";
            this.BotonFiltrar.Size = new System.Drawing.Size(130, 24);
            this.BotonFiltrar.Text = "Filtrar Tarea";
            this.BotonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click);
            // 
            // FiltrarCategoria
            // 
            this.FiltrarCategoria.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.FiltrarCategoria.Items.AddRange(new object[] {
            "Todo",
            "Escuela",
            "Trabajo",
            "Personal",
            "Urgente",
            "Completadas",
            "No Completadas"});
            this.FiltrarCategoria.Name = "FiltrarCategoria";
            this.FiltrarCategoria.Size = new System.Drawing.Size(121, 30);
            this.FiltrarCategoria.Text = "Filtrar por:";
            // 
            // aceparToolStripMenuItem
            // 
            this.aceparToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.aceparToolStripMenuItem.Name = "aceparToolStripMenuItem";
            this.aceparToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.aceparToolStripMenuItem.Text = "Aceptar";
            this.aceparToolStripMenuItem.Click += new System.EventHandler(this.aceparToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.OldLace;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(135, 24);
            this.toolStripDropDownButton1.Text = "Recordatorios";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // Boton_Informe
            // 
            this.Boton_Informe.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Informe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Boton_Informe.Image = global::WindowsFormsApp1.Properties.Resources.aggretsuko_metal_waifu2x_art_noise3_scale;
            this.Boton_Informe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Boton_Informe.Name = "Boton_Informe";
            this.Boton_Informe.Size = new System.Drawing.Size(143, 24);
            this.Boton_Informe.Text = "Generar Informe";
            this.Boton_Informe.Click += new System.EventHandler(this.Boton_Informe_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(161, -1);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(464, 532);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(627, 522);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckTasks";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcarComoCompletadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton BotonFiltrar;
        private System.Windows.Forms.ToolStripComboBox FiltrarCategoria;
        private System.Windows.Forms.ToolStripMenuItem aceparToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton Boton_Informe;
    }
}

