using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class TipoMedicamentoBL
    {
        public List<TipoMedicamentoCLS> ListartipoMedicamento()
        {
            TipoMedicamentoDAL tipoMedicamentoDAL = new TipoMedicamentoDAL();
            return tipoMedicamentoDAL.ListarTipoMedicamento();
        }

        public List<TipoMedicamentoCLS> FiltrartipoMedicamento(string nombre)
        {
            TipoMedicamentoDAL tipoMedicamentoDAL = new TipoMedicamentoDAL();
            return tipoMedicamentoDAL.FiltrarTipoMedicamento(nombre);
        }

        public int GuardarTipoMedicamento(TipoMedicamentoCLS oTipoMedicamentoCLS)
        {
            TipoMedicamentoDAL tipoMedicamentoDAL = new TipoMedicamentoDAL();
            return tipoMedicamentoDAL.GuardarTipoMedicamento(oTipoMedicamentoCLS);
        }


        public TipoMedicamentoCLS RecuperarTipoMedicamento(int idTipoMedicamento)
        {
            TipoMedicamentoDAL tipoMedicamentoDAL = new TipoMedicamentoDAL();
            return tipoMedicamentoDAL.RecuperarTipoMedicamento(idTipoMedicamento);
        }

        public int EliminarTipoMedicamento(int idTipoMedicamento)
        {
            TipoMedicamentoDAL tipoMedicamentoDAL = new TipoMedicamentoDAL();
            return tipoMedicamentoDAL.EliminarTipoMedicamento(idTipoMedicamento);
        }

    }
}
