using Microsoft.AspNetCore.Mvc;
using ProduksiMobilApp.Models;

namespace ProduksiMobilApp.Controllers
{
    public class ProductionController : Controller
    {
        // Simulasi database atau gunakan DB Context
        private static List<ProductionPlan> _history = new List<ProductionPlan>();

        public IActionResult Index()
        {
            return View(_history);
        }

        [HttpPost] // Atribut ini harus di sini
        public IActionResult Create(ProductionPlan input)
        {
            int[] vals = { input.Senin, input.Selasa, input.Rabu, input.Kamis, input.Jumat, input.Sabtu, input.Minggu };
            int total = vals.Sum();
            int activeDays = vals.Count(x => x > 0);

            if (activeDays > 0)
            {
                int avg = total / activeDays;
                int rem = total % activeDays;

                int[] results = new int[7];
                for (int i = 0; i < 7; i++)
                    results[i] = (vals[i] > 0) ? avg : 0;

                var priorities = vals.Select((v, i) => new { v, i })
                                     .Where(x => x.v > 0)
                                     .OrderByDescending(x => x.v)
                                     .Take(rem);

                foreach (var p in priorities) results[p.i]++;

                input.FixSenin = results[0]; input.FixSelasa = results[1];
                input.FixRabu = results[2]; input.FixKamis = results[3];
                input.FixJumat = results[4]; input.FixSabtu = results[5];
                input.FixMinggu = results[6];
            }

            _history.Add(input); 
            return RedirectToAction("Index");
        }
    }
}