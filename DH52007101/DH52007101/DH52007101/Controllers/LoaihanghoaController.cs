using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DH52007101.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DH52007101.Controllers {
    public class LoaihanghoaController : Controller {
        QLBHContext db = new QLBHContext();
        public IActionResult Index() {
            ViewBag.lhh = db.Loaihanghoa;
            return View();
        }

        // Thêm
        [HttpGet]
        public ActionResult them() {
            return View();
        }
        [HttpPost]
        public ActionResult them(Loaihanghoa n) {
            db.Loaihanghoa.Add(n);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        //Sửa
        [HttpGet]
        public ActionResult sua(string id) {
            if (id == null)
                return new BadRequestResult();
            Loaihanghoa lhh = db.Loaihanghoa.Find(id);
            if (lhh == null)
                return NotFound();
            ViewBag.lhh = lhh;
            return View(lhh);
        }
        [HttpPost]
        public ActionResult sua() {
            string ma = Request.Form["Maloai"].ToString();
            Loaihanghoa lhh = db.Loaihanghoa.Find(ma);
            if (lhh == null)
                return NotFound();
            lhh.Tenloai = Request.Form["Tenloai"].ToString();
            db.Entry(lhh).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        //Xóa
        public ActionResult xoa(string id) {
            //if (id == null) {
            //    return new BadRequestResult();
            //}
            //Loaihanghoa n = db.Loaihanghoa.Find(id);
            //if (n == null) {
            //    return NotFound();
            //}
            //ViewBag.lhh = n;
            //return View(n);

            var a = db.Hanghoa.Where(k => k.Maloai == id).ToList().Count;
            if (a <= 0)
                ViewBag.flagDelete = true;
            else
                ViewBag.flagDelete = false;

            Loaihanghoa n = db.Loaihanghoa.Find(id);
            ViewBag.lhh = n;
            return View(n);
        }
        [HttpPost, ActionName("xoa")]
        public ActionResult xoa_Post(string id) {
            Loaihanghoa n = db.Loaihanghoa.Find(id);
            db.Loaihanghoa.Remove(n);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}