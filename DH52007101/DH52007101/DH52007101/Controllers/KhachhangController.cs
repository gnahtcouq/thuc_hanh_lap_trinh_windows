using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DH52007101.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace DH52007101.Controllers {
    public class KhachhangController : Controller {
        QLBHContext db = new QLBHContext();
        public IActionResult Index() {
            ViewBag.kh = db.Khachhang;
            return View();
        }

        // Thêm
        [HttpGet]
        public ActionResult them() {
            return View();
        }
        [HttpPost]
        public ActionResult them(Khachhang n) {
            if (ModelState.IsValid) {
                db.Khachhang.Add(n);
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
            Khachhang kh = db.Khachhang.Find(id);
            if (kh == null)
                return NotFound();
            ViewBag.kh = kh;
            return View(kh);
        }
        [HttpPost]
        public ActionResult sua() {
            string ma = Request.Form["Makh"].ToString();
            Khachhang kh = db.Khachhang.Find(ma);
            if (kh == null)
                return NotFound();
            kh.Tenkh = Request.Form["Tenkh"].ToString();
            kh.Namsinh = int.Parse(Request.Form["Namsinh"]);
            kh.Phai = bool.Parse(Request.Form["Phai"]);
            //kh.Phai = Request.Form["Phai"] == "true" ? true : false;
            kh.Dienthoai = Request.Form["Dienthoai"].ToString();
            kh.Diachi = Request.Form["Diachi"].ToString();
            kh.Password = Request.Form["Password"].ToString();

            db.Entry(kh).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        //Xóa
        public ActionResult xoa(string id) {
            if (id == null) {
                return new BadRequestResult();
            }
            Khachhang n = db.Khachhang.Find(id);
            if (n == null) {
                return NotFound();
            }
            ViewBag.kh = n;
            return View(n);
        }
        [HttpPost, ActionName("xoa")]
        public ActionResult xoa_Post(string id) {
            Khachhang n = db.Khachhang.Find(id);
            db.Khachhang.Remove(n);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        // Đăng nhập
        public IActionResult DangNhap() {
            ViewBag.loginCheck = null;
            return View();
        }
        [HttpPost]
        public IActionResult DangNhap(Khachhang kh) {
            ViewBag.loginCheck = false;
            Khachhang k = db.Khachhang.Find(kh.Makh);
            if (k != null) {
                if (k.Password == kh.Password) {
                    string json = JsonConvert.SerializeObject(k);
                    HttpContext.Session.SetString("Khachhang", json);
                    ViewBag.loginCheck = true;
                    //return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        // Đăng xuất
        public IActionResult DangXuat(Khachhang kh) {
            HttpContext.Session.Remove("Khachhang");
            return RedirectToAction("Index", "Home");
        }
    }
}