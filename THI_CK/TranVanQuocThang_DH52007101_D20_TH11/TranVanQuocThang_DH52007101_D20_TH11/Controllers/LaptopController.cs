using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TranVanQuocThang_DH52007101_D20_TH11.Models;

namespace TranVanQuocThang_DH52007101_D20_TH11.Controllers {
    public class LaptopController : Controller {
        QLLAPTOPContext db = new QLLAPTOPContext();
        public IActionResult Index() {
            ViewBag.laptop = db.Laptop;
            return View();
        }

        // Thêm
        [HttpGet]
        public ActionResult them() {
            return View();
        }
        [HttpPost]
        public ActionResult them(Laptop s) {
            if (ModelState.IsValid) {
                if (db.Laptop.Find(s.MaLaptop) != null) {
                    ModelState.AddModelError("MaLaptop", "Mã laptop này đã tồn tại, không thêm được nữa!"); // cấp property
                    //ModelState.AddModelError("", "Mã sách này đã tồn tại không thêm được nữa!"); // cấp model
                    return View(s);
                } else {
                    db.Laptop.Add(s);
                    db.SaveChanges();
                    return RedirectToAction("index");
                }
            } else
                return View(s);
        }

        public IActionResult xemNhaSanXuat(string id) {
            NhaSanXuat nsx = db.NhaSanXuat.Find(id);
            return PartialView(nsx);
        }


        //Xóa
        public ActionResult xoa(string id) {
            var a = db.ChiTietHoaDon.Where(k => k.MaLaptop == id).ToList().Count;
            if (a <= 0)
                ViewBag.flagDelete = true;
            else
                ViewBag.flagDelete = false;

            Laptop s = db.Laptop.Find(id);
            ViewBag.hoadon = s;
            return View(s);
        }
        [HttpPost, ActionName("xoa")]
        public ActionResult xoa_Post(string id) {
            Laptop s = db.Laptop.Find(id);
            db.Laptop.Remove(s);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}