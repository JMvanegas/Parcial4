﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimientos
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor obj1 = new Doctor();
            obj1.Show();
        }

        private void empToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp obj2 = new Emp();
            obj2.Show();
        }

        private void enfermeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enfermo obj3 = new Enfermo();
            obj3.Show();
        }

        private void plantillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plantilla obj4 = new Plantilla();
            obj4.Show();
        }

        private void hospitalDeptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hdept obj5 = new Hdept();
            obj5.Show();
        }

        private void hospitalHospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hhospital obj6 = new Hhospital();
            obj6.Show();
        }

        private void hospitalSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hSala obj7 = new hSala();
            obj7.Show();
        }
    }
}
