using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Mantenimientos
{
    public partial class Doctor : Form
    {
        Mantenimiento neg = new Mantenimiento();

        public Doctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            neg.Doctor_No1 = textBox1.Text;
            neg.Hospital_Cod1 = textBox2.Text;
            neg.Apellido1 = textBox3.Text;
            neg.Especialidad1 = textBox4.Text;
            neg.InsertDoc();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            neg.Doctor_No1 = textBox1.Text;
            neg.Hospital_Cod1 = textBox2.Text;
            neg.Apellido1 = textBox3.Text;
            neg.Especialidad1 = textBox4.Text;
            neg.InsertDoc();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            neg.Doctor_No1 = textBox1.Text;
            neg.Hospital_Cod1 = textBox2.Text;
            neg.Apellido1 = textBox3.Text;
            neg.Especialidad1 = textBox4.Text;
            neg.InsertDoc();
        }
    }
}
