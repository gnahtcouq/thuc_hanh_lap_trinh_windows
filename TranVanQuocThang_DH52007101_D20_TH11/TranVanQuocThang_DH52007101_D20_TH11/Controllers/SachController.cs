using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TranVanQuocThang_DH52007101_D20_TH11.Models;

namespace TranVanQuocThang_DH52007101_D20_TH11.Controllers {
    public class SachController : Controller {
        QLSACHContext db = new QLSACHContext();
        public IActionResult Index() {
            ViewBag.sach = db.Sach;
            return View();
        }

        // Thêm
        [HttpGet]
        public ActionResult them() {
            ViewBag.ls = new SelectList(db.LoaiSach.ToList(), "MaLoai", "TenLoai");
            return View();
        }
        [HttpPost]
        public ActionResult them(Sach n) {
            ViewBag.ls = new SelectList(db.LoaiSach.ToList(), "MaLoai", "TenLoai");
            if (ModelState.IsValid) {
                if (db.Sach.Find(n.MaSach) != null) {
                    ModelState.AddModelError("MaSach", "Mã sách này đã tồn tại không thêm được nữa!"); // cấp property
                    //ModelState.AddModelError("", "Mã sách này đã tồn tại không thêm được nữa!"); // cấp model
                    return View(n);
                } else {
                    db.Sach.Add(n);
                    db.SaveChanges();
                    return RedirectToAction("index");
                }
            } else
                return View(n);
        }

        //Xóa
        public ActionResult xoa(string id) {
            var a = db.ChiTietPhieuMuon.Where(k => k.MaSach == id).ToList().Count;
            if (a <= 0)
                ViewBag.flagDelete = true;
            else
                ViewBag.flagDelete = false;

            Sach n = db.Sach.Find(id);
            ViewBag.lhh = n;
            return View(n);
        }
        [HttpPost, ActionName("xoa")]
        public ActionResult xoa_Post(string id) {
            Sach n = db.Sach.Find(id);
            db.Sach.Remove(n);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}