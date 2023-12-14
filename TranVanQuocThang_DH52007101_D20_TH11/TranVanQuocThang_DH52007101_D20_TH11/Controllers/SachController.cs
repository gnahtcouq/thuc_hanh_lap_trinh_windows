using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            //ViewBag.ls = new SelectList(db.LoaiSach.ToList(), "MaLoai", "TenLoai");
            return View();
        }
        [HttpPost]
        public ActionResult them(Sach s) {
            //ViewBag.ls = new SelectList(db.LoaiSach.ToList(), "MaLoai", "TenLoai");
            if (ModelState.IsValid) {
                if (db.Sach.Find(s.MaSach) != null) {
                    ModelState.AddModelError("MaSach", "Mã sách này đã tồn tại không thêm được nữa!"); // cấp property
                    //ModelState.AddModelError("", "Mã sách này đã tồn tại không thêm được nữa!"); // cấp model
                    return View(s);
                } else {
                    db.Sach.Add(s);
                    db.SaveChanges();
                    return RedirectToAction("index");
                }
            } else
                return View(s);
        }

        //Xóa
        public ActionResult xoa(string id) {
            var a = db.ChiTietPhieuMuon.Where(k => k.MaSach == id).ToList().Count;
            if (a <= 0)
                ViewBag.flagDelete = true;
            else
                ViewBag.flagDelete = false;

            Sach s = db.Sach.Find(id);
            ViewBag.lhh = s;
            return View(s);
        }
        [HttpPost, ActionName("xoa")]
        public ActionResult xoa_Post(string id) {
            Sach s = db.Sach.Find(id);
            db.Sach.Remove(s);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        // Sửa
        [HttpGet]
        public ActionResult sua(string id) {
            if (id == null)
                return new BadRequestResult();
            Sach s = db.Sach.Find(id);
            if (s == null)
                return NotFound();
            ViewBag.sach = s;
            //ViewBag.ls = new SelectList(db.LoaiSach.ToList(), "MaLoai", "TenLoai");
            return View(s);
        }

        [HttpPost]
        public ActionResult sua() {
            string ma = Request.Form["MaSach"].ToString();
            Sach s = db.Sach.Find(ma);
            if (s == null)
                return NotFound();
            s.TenSach = Request.Form["TenSach"].ToString();
            if (DateTime.TryParse(Request.Form["NgayXb"], out DateTime ngayxb)) {
                s.NgayXb = ngayxb;
            } else {
                ModelState.AddModelError("NgayXb", "Ngày xuất bản không hợp lệ");
                return View(s);
            }
            s.Gia = int.Parse(Request.Form["Gia"]);
            s.MaLoai = Request.Form["MaLoai"].ToString();
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult xemLoaiSach(string id) {
            LoaiSach ls = db.LoaiSach.Find(id);
            return PartialView(ls);
        }
    }
}