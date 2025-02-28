using CapaEntidad;
using CapaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiPrimeraAppMVC.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public List<MedicamentoCLS> ListarMedicamento()
        {
            MedicamentoBL obj = new MedicamentoBL();
            return obj.ListarMedicamento();
        }

        public int GuardarMedicamento(MedicamentoCLS oMedicamentoCLS)
        {
            MedicamentoBL obj = new MedicamentoBL();
            return obj.GuardarMedicamento(oMedicamentoCLS);
        }

        public MedicamentoCLS RecuperarMedicamento(int idMedicamento)
        {
            MedicamentoBL obj = new MedicamentoBL();
            return obj.RecuperarMedicamento(idMedicamento);
        }

        public int EliminarMedicamento(int idMedicamento)
        {
            MedicamentoBL obj = new MedicamentoBL();
            return obj.EliminarMedicamento(idMedicamento);
        }
    }
}
