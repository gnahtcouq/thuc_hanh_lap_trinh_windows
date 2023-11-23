using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DH52007101.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DH52007101.Controllers {
    public class HanghoaController : Controller {
        QLBHContext db = new QLBHContext();
        public IActionResult Index() {
            var hanghoa = db.Hanghoa.Include(h => h.MaloaiNavigation).Include(h => h.MansxNavigation);
            ViewBag.hh = db.Hanghoa;
            return View();
        }

        //public IActionResult chiTietHanghoa(string id) {
        //    var a = db.Hanghoa.Include(h => h.MaloaiNavigation).Include(h => h.MansxNavigation).Where(n => n.Mahang == id).;
        //    return View(a);
        //}

        // Thêm
        [HttpGet]
        public ActionResult them() {
            //ViewBag.lhh = db.Loaihanghoa;
            //ViewBag.nsx = db.Nhasanxuat;
            ViewBag.lhh = new SelectList(db.Loaihanghoa.ToList(), "Maloai", "Tenloai");
            ViewBag.nsx = new SelectList(db.Nhasanxuat.ToList(), "Mansx", "Tennsx");
            return View();
        }
        [HttpPost]
        public ActionResult them(Hanghoa n) {
            if (ModelState.IsValid) {
                db.Hanghoa.Add(n);
                db.SaveChanges();
                return RedirectToAction("index");
            } else
                return View(n);
        }

        //Sửa
        [HttpGet]
        public ActionResult sua(string id) {
            if (id == null)
                return new BadRequestResult();
            Hanghoa hh = db.Hanghoa.Find(id);
            if (hh == null)
                return NotFound();
            ViewBag.hh = hh;
            ViewBag.lhh = new SelectList(db.Loaihanghoa.ToList(), "Maloai", "Tenloai");
            ViewBag.nsx = new SelectList(db.Nhasanxuat.ToList(), "Mansx", "Tennsx");
            return View(hh);
        }
        [HttpPost]
        public ActionResult sua() {
            string ma = Request.Form["Mahang"].ToString();
            Hanghoa hh = db.Hanghoa.Find(ma);
            if (hh == null)
                return NotFound();
            hh.Tenhang = Request.Form["Mahang"].ToString();
            hh.Donvitinh = Request.Form["Donvitinh"].ToString();
            hh.Dongia = double.Parse(Request.Form["Dongia"]);
            hh.Maloai = Request.Form["Maloai"].ToString();
            hh.Mansx = Request.Form["Mansx"].ToString();
            db.Entry(hh).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        //Xóa
        public ActionResult xoa(string id) {
            if (id == null) {
                return new BadRequestResult();
            }
            Hanghoa n = db.Hanghoa.Find(id);
            if (n == null) {
                return NotFound();
            }
            ViewBag.hh = n;
            return View(n);
        }
        [HttpPost, ActionName("xoa")]
        public ActionResult xoa_Post(string id) {
            Hanghoa n = db.Hanghoa.Find(id);
            db.Hanghoa.Remove(n);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}