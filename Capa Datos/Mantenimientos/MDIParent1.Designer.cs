namespace Mantenimientos
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalDeptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospitalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hospitalToolStripMenuItem
            // 
            this.hospitalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorToolStripMenuItem,
            this.empToolStripMenuItem,
            this.enfermeroToolStripMenuItem,
            this.plantillaToolStripMenuItem,
            this.hospitalDeptToolStripMenuItem,
            this.hospitalHospitalToolStripMenuItem,
            this.hospitalSalaToolStripMenuItem});
            this.hospitalToolStripMenuItem.Name = "hospitalToolStripMenuItem";
            this.hospitalToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.hospitalToolStripMenuItem.Text = "Hospital";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.doctorToolStripMenuItem.Text = "Doctor";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // empToolStripMenuItem
            // 
            this.empToolStripMenuItem.Name = "empToolStripMenuItem";
            this.empToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.empToolStripMenuItem.Text = "Emp";
            this.empToolStripMenuItem.Click += new System.EventHandler(this.empToolStripMenuItem_Click);
            // 
            // enfermeroToolStripMenuItem
            // 
            this.enfermeroToolStripMenuItem.Name = "enfermeroToolStripMenuItem";
            this.enfermeroToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.enfermeroToolStripMenuItem.Text = "Enfermo";
            this.enfermeroToolStripMenuItem.Click += new System.EventHandler(this.enfermeroToolStripMenuItem_Click);
            // 
            // plantillaToolStripMenuItem
            // 
            this.plantillaToolStripMenuItem.Name = "plantillaToolStripMenuItem";
            this.plantillaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.plantillaToolStripMenuItem.Text = "Plantilla";
            this.plantillaToolStripMenuItem.Click += new System.EventHandler(this.plantillaToolStripMenuItem_Click);
            // 
            // hospitalDeptToolStripMenuItem
            // 
            this.hospitalDeptToolStripMenuItem.Name = "hospitalDeptToolStripMenuItem";
            this.hospitalDeptToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.hospitalDeptToolStripMenuItem.Text = "Hospital.Dept";
            this.hospitalDeptToolStripMenuItem.Click += new System.EventHandler(this.hospitalDeptToolStripMenuItem_Click);
            // 
            // hospitalHospitalToolStripMenuItem
            // 
            this.hospitalHospitalToolStripMenuItem.Name = "hospitalHospitalToolStripMenuItem";
            this.hospitalHospitalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.hospitalHospitalToolStripMenuItem.Text = "Hospital.Hospital";
            this.hospitalHospitalToolStripMenuItem.Click += new System.EventHandler(this.hospitalHospitalToolStripMenuItem_Click);
            // 
            // hospitalSalaToolStripMenuItem
            // 
            this.hospitalSalaToolStripMenuItem.Name = "hospitalSalaToolStripMenuItem";
            this.hospitalSalaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.hospitalSalaToolStripMenuItem.Text = "Hospital.Sala";
            this.hospitalSalaToolStripMenuItem.Click += new System.EventHandler(this.hospitalSalaToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalDeptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalSalaToolStripMenuItem;
    }
}



