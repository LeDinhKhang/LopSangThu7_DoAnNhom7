using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNhom7.Models;
namespace DoAnNhom7.Controllers
{
    public class SanPhamController
    {
        public static bool AddSanPham(SanPham SP)
        {
            try
            {
                using (var _context = new DBQuanLiSanPhamEntities())
                {
                    _context.SanPhams.Add(SP);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static int SoLuongSP()
        {
            using(var _context =new DBQuanLiSanPhamEntities())
            {
                var SLSP = _context.SanPhams.Count();
                return SLSP;
            }
        }
        public static void DeleteAddSP()
        {
            using(var _context =new DBQuanLiSanPhamEntities())
            {
                
                foreach (var SP in _context.SanPhams)
                {
                    _context.SanPhams.Attach(SP);
                    _context.SanPhams.Remove(SP);
                }
                _context.SaveChanges();
            }
        }
        public static SanPham getSanPham(string tenSP)
        {
            using (var _context = new DBQuanLiSanPhamEntities())
            {
                var SP = (from u in _context.SanPhams
                            where u.TenSP == tenSP
                            select u).ToList();
                if (SP.Count == 1)
                {
                    return SP[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static int SLSanPhamDaCo(string tenSP)
        {
            using (var _context = new DBQuanLiSanPhamEntities())
            {
                var SP = (from u in _context.SanPhams
                          where u.TenSP == tenSP
                          select u).ToList();
                return SP.Count;
            }
        }

        public static List<SanPham> getListSanPham()
        {
            using (var _context = new DBQuanLiSanPhamEntities())
            {
                var user = (from u in _context.SanPhams.AsEnumerable()
                            select u)
                            .Select(x => new SanPham
                            {
                                TenSP = x.TenSP,
                                LoaiSP = x.LoaiSP,
                                NhaSX = x.NhaSX,
                                NgaySX = x.NgaySX,
                                NgayHH = x.NgayHH,
                                SoLuongSP = x.SoLuongSP,
                                MaSP = x.MaSP
                            }).ToList();
                return user;
            }
        }
        public static bool UpdateSanPham(SanPham SP)
        {
            using (var _context = new DBQuanLiSanPhamEntities())
            {
                _context.SanPhams.AddOrUpdate(SP);
                _context.SaveChanges();
                return true;
            }
        }

        public static bool DeleteSanPham(SanPham SP)
        {
            using (var _context = new DBQuanLiSanPhamEntities())
            {
                var dbsanpham = (from u in _context.SanPhams
                              where u.TenSP == SP.TenSP
                              select u).SingleOrDefault();
                _context.SanPhams.Remove(dbsanpham);
                _context.SaveChanges();
                return true;
            }
        }

    }
}
