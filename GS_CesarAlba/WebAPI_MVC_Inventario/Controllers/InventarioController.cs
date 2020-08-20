using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using WebAPI_MVC_Inventario.Models;

namespace WebAPI_MVC_Inventario.Controllers
{
    public class InventarioController : Controller
    {
        // GET: Inventario
        public ActionResult Index()
        {
            IEnumerable<InventarioViewModel> inventario = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9095/Api/");
                var responseTask = client.GetAsync("inventario");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<InventarioViewModel>>();
                    readJob.Wait();
                    inventario = readJob.Result;
                }
                else
                {
                    inventario = Enumerable.Empty<InventarioViewModel>();
                    ModelState.AddModelError(string.Empty, "Error en servidor. Por favor contactar al administrador");
                }
            }
            return View(inventario);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(InventarioViewModel inventario)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:9095/api/inventario/");
                var postJob = client.PostAsJsonAsync<InventarioViewModel>("agregar", inventario);
                postJob.Wait();

                var postResult = postJob.Result;
                if (postResult.IsSuccessStatusCode)
                    return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Ocurrió un error en el servidor. Por favor contactar al administrador por ayuda");

            return View(inventario);
        }

        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9095/Api/");
                var deleteTask = client.DeleteAsync("inventario/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                    return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }

}