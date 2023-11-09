using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DH52007101.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DH52007101.Controllers {
    public class NhasanxuatController : Controller {
        QLBHContext db = new QLBHContext();
        public IActionResult Index() {
            ViewBag.nsx = db.Nhasanxuat;
            return View();
        }

        //Thêm
        [HttpGet]
        public ActionResult them() {
            return View();
        }
        [HttpPost]
        public ActionResult them(Nhasanxuat n) {
            if (ModelState.IsValid) {
                if (db.Nhasanxuat.Find(n.Mansx) != null) {
                    //ModelState.AddModelError("Mansx", "Mã nhà sản xuất bị trùng"); // cấp property
                    ModelState.AddModelError("", "Mã nhà sản xuất bị trùng!"); // cấp model
                    return View(n);
                } else {
                    db.Nhasanxuat.Add(n);
                    db.SaveChanges();
                    return RedirectToAction("index");
                }
            } else
                return View(n);
        }

        //Sửa
        [HttpGet]
        public ActionResult sua(string id) {
            if (id == null)
                return new BadRequestResult();
            Nhasanxuat nsx = db.Nhasanxuat.Find(id);
            if (nsx == null)
                return NotFound();
            ViewBag.nsx = nsx;
            return View(nsx);
        }
        [HttpPost]
        public ActionResult sua() {
            string ma = Request.Form["Mansx"].ToString();
            Nhasanxuat nsx = db.Nhasanxuat.Find(ma);
            if (nsx == null)
                return NotFound();
            nsx.Tennsx = Request.Form["Tennsx"].ToString();
            nsx.Diachi = Request.Form["Diachi"].ToString();
            db.Entry(nsx).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        //Xóa
        public ActionResult xoa(string id) {
            var a = db.Hanghoa.Where(k => k.Mansx == id).ToList().Count;
            if (a <= 0)
                ViewBag.flagDelete = true;
            else
                ViewBag.flagDelete = false;

            Nhasanxuat n = db.Nhasanxuat.Find(id);
            ViewBag.nsx = n;
            return View(n);
        }
        [HttpPost, ActionName("xoa")]
        public ActionResult xoa_Post(string id) {
            Nhasanxuat n = db.Nhasanxuat.Find(id);
            db.Nhasanxuat.Remove(n);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}