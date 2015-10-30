using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WcfService.Models;
using System.Diagnostics;

namespace WcfService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : IWebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<SanPham> GetAllSP()
        {
            try
            {
                using (ShopttEntities data = new ShopttEntities())
                {
                    var my_data = (data.SanPhams.Select(p => p)).ToList();
                    return my_data;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
        [WebMethod]
        public List<SanPham> GetSanPhamID(int id)
        {
            try
            {
                using (ShopttEntities db = new ShopttEntities())
                {
                    var Sp = (from p in db.SanPhams where p.MaNSX == id select p).ToList() ;
                    if (Sp!= null)
                    return Sp;
                    else
                        throw new Exception("Invalid product id");

                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
        
        [WebMethod]
        public bool AddSP(string TenSP)
        {
            SanPham sp = new SanPham();
            sp.TenSP = TenSP;
             try
            {
                using (ShopttEntities data = new ShopttEntities())
                {
                    data.SanPhams.Add(sp);
                    data.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }

        private Product TranslateEntity(SanPham Sp)
        {
            Product product = new Product();
            product._MaSP = Sp.MaSP;
            product._TenSP = Sp.TenSP;
            product._GiaBan = (decimal)Sp.GiaBan;
            product._HinhAnh = Sp.HinhAnh;
            product._NgayCapNhat = (DateTime)Sp.NgayCapNhat;
            product._SoLuong =(int) Sp.SoLuong;
            product._MaNSX = (int)Sp.MaNSX;
            product._MaLoai =(int) Sp.MaLoai;
            return product;
        }
        private SanPham TranslateProDuct(Product sp)
        {
            SanPham _SP = new SanPham();
            _SP.MaSP = sp._MaSP;
            _SP.TenSP = sp._TenSP;
            _SP.GiaBan = (decimal)sp._GiaBan;
            _SP.HinhAnh = sp._HinhAnh;
            _SP.NgayCapNhat =(DateTime)sp._NgayCapNhat;
            _SP.SoLuong = (int)sp._SoLuong;
            _SP.MaNSX = (int)sp._MaNSX;
            _SP.MaLoai = (int)sp._MaLoai;
            return _SP;
        }
    }
}
