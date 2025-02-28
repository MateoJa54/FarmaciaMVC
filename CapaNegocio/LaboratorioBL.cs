using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class LaboratorioBL
    {
        public List<LaboratorioCLS> ListarLaboratorio()
        {
            LaboratorioDAL obj = new LaboratorioDAL();
            return obj.ListarLaboratorio();
        }

        public List<LaboratorioCLS> FiltrarLaboratorio(LaboratorioCLS objLab)
        {
            LaboratorioDAL obj = new LaboratorioDAL();
            return obj.FiltrarLaboratorio(objLab);
        }

        public int GuardarLaboratorio(LaboratorioCLS objLab)
        {
            LaboratorioDAL obj = new LaboratorioDAL();
            return obj.GuardarLaboratorio(objLab);
        }

        public LaboratorioCLS RecuperarLaboratorio(int idLaboratorio)
        {
            LaboratorioDAL obj = new LaboratorioDAL();
            return obj.RecuperarLaboratorio(idLaboratorio);
        }

        public int EliminarLaboratorio(int idLaboratorio)
        {
            LaboratorioDAL obj = new LaboratorioDAL();
            return obj.EliminarLaboratorio(idLaboratorio);
        }
    }
}