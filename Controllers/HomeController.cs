using System.Diagnostics;
using Azure.Core;
using DemoWebsite.Models;
using DemoWebsite.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DemoDbContext _context;

        public HomeController(ILogger<HomeController> logger, DemoDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //lay danh sach
        //GET: /Home/Index
        //danh-sach
        //[Route("danh-sach")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> ListSV()
        {
            //lay du lieu tu SQL
            var items = _context.SinhViens.ToList();
            if (items == null) return NotFound();
            return Ok(items);
        }

        //POST: /Home/ThemMoi
        [HttpPost]
        public async Task<IActionResult> ThemMoi(SinhVien input)
        {
            //them 1 dong du lieu
            SinhVien sv1 = new SinhVien();
            sv1.Id = Guid.NewGuid();
            sv1.MSSV = input.MSSV;
            sv1.HoTen = input.HoTen;
            sv1.GioiTinh = input.GioiTinh;
            sv1.DiaChi = input.DiaChi;
            sv1.SoDienThoai = input.SoDienThoai;

            _context.SinhViens.Add(sv1);
            await _context.SaveChangesAsync();
            return Ok();
            //return Redirect("/Home/Index");
        }

        //ham xoa thong tin
        public async Task<IActionResult> Xoa(string id)
        {
            //xoa 1 dong du lieu
            var item = _context.SinhViens.FirstOrDefault(x => x.Id == Guid.Parse(id));
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                _context.SinhViens.Remove(item);
                await _context.SaveChangesAsync();
            }
            return Redirect("/Home/Index");
        }
       
        [HttpPost]
        public async Task<IActionResult> CapNhat(string id, SinhVien input)
        {
            //sua 1 dong du lieu
            var item = _context.SinhViens.FirstOrDefault(x => x.Id == Guid.Parse(id));
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                item.MSSV = input.MSSV;
                item.MSSV = input.MSSV;
                item.HoTen = input.HoTen;
                item.GioiTinh = input.GioiTinh;
                item.DiaChi = input.DiaChi;
                item.SoDienThoai = input.SoDienThoai;

                _context.SinhViens.Update(item);
                await _context.SaveChangesAsync();
            }
            return Redirect("/Home/Index");
        }
    }
}
