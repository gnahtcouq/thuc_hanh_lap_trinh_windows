using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DH52007101.Models;
using Microsoft.EntityFrameworkCore;

namespace DH52007101.Controllers {
    public class NhanvienController : Controller {
        QLBHContext db = new QLBHContext();
        public IActionResult Index() {
            ViewBag.nv = db.Nhanvien;
            return View();
        }

        // Thêm
        [HttpGet]
        public ActionResult them() {
            return View();
        }
        [HttpPost]
        public ActionResult them(Nhanvien n) {
            if (ModelState.IsValid) {
                db.Nhanvien.Add(n);
                db.SaveChanges();
                return RedirectToAction("index");
            } else
                return View(n);
        }

        // Sửa
        [HttpGet]
        public ActionResult sua(string id) {
            if (id == null)
                return new BadRequestResult();
            Nhanvien nv = db.Nhanvien.Find(id);
            if (nv == null)
                return NotFound();
            ViewBag.nv = nv;
            return View(nv);
        }
        [HttpPost]
        public ActionResult sua() {
            string ma = Request.Form["Manv"].ToString();
            Nhanvien nv = db.Nhanvien.Find(ma);
            if (nv == null)
                return NotFound();
            nv.Tennv = Request.Form["Tennv"].ToString();
            nv.Phai = bool.Parse(Request.Form["Phai"]);
            nv.Diachi = Request.Form["Diachi"].ToString();
            nv.Password = Request.Form["Password"].ToString();
            if (DateTime.TryParse(Request.Form["Ngaysinh"], out DateTime ngaysinh)) {
                nv.Ngaysinh = ngaysinh;
            } else {
                ModelState.AddModelError("Ngaysinh", "Ngày sinh không hợp lệ");
                return View(nv);
            }
            db.Entry(nv).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        //Xóa
        public ActionResult xoa(string id) {
            if (id == null) {
                return new BadRequestResult();
            }
            Nhanvien n = db.Nhanvien.Find(id);
            if (n == null) {
                return NotFound();
            }
            ViewBag.nv = n;
            return View(n);
        }
        [HttpPost, ActionName("xoa")]
        public ActionResult xoa_Post(string id) {
            Nhanvien n = db.Nhanvien.Find(id);
            db.Nhanvien.Remove(n);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}