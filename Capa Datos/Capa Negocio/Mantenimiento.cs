using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;//*****-

namespace Capa_Negocio
{
    public class Mantenimiento
    {
        bdConex test = new bdConex();
        private String Doctor_No, Hospital_Cod, Apellido, Especialidad;
        public DataTable dt = new DataTable();

        public String Especialidad1
        {
            get { return Especialidad; }
            set { Especialidad = value; }
        }

        public String Apellido1
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public String Hospital_Cod1
        {
            get { return Hospital_Cod; }
            set { Hospital_Cod = value; }
        }
        

        public String Doctor_No1
        {
            get { return Doctor_No; }
            set { Doctor_No = value; }
        }

        public void InsertDoc() 
        { 
            try
            {
                String insert = "INSERT INTO DOCTOR(DOCTOR_NO, HOSPITAL_COD, APELLIDO, ESPECIALIDAD) VALUES ('"+Doctor_No+"','"+Hospital_Cod+"','"+Apellido+"','"+Apellido+"')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void ActualizarDoc()
        {
            try
            {
                String insert = "UPDDATE DOCTOR set DOCTOR_NO='" + Doctor_No + "',HOSPITAL_COD='" + Hospital_Cod + "',APELLIDO= '" + Apellido + "', ESPECIALIDAD='" + Especialidad + "' where DOCTOR='"+Doctor_No+"'";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }
    }
}
