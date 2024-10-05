using Microsoft.AspNetCore.Mvc;

namespace Zust.WebUI.Controllers
{
    public class LiveChatController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: LiveChat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LiveChat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LiveChat/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LiveChat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LiveChat/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LiveChat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LiveChat/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
