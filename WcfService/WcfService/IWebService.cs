using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Models;

namespace WcfService
{
    [ServiceContract]
    public interface IWebService
    {
        [OperationContract]
        List<SanPham> GetAllSP();
        [OperationContract]
        bool AddSP(string TenSP);
        [OperationContract]
        List<SanPham> GetSanPhamID(int id);

    }
    [DataContract]
    public class Product
    {
        int MaSP = 0;
        string TenSP = "";
        decimal GiaBan = 0;
        string HinhAnh = "";
        DateTime NgayCapNhat = DateTime.Now;
        int SoLuong = 0;
        int MaNSX = 0;
        int MaLoai = 0;
        [DataMember]
        public int _MaSP 
        {
            get { return this.MaSP; }
            set { MaSP = value; }
        }
        [DataMember]
        public string _TenSP
        {
            get { return this.TenSP; }
            set { TenSP = value; }
        }
        [DataMember]
        public decimal _GiaBan
        {
            get { return this.GiaBan; }
            set { this.GiaBan = value; }
        }
        [DataMember]
        public string _HinhAnh
        {
            get { return this.HinhAnh; }
            set { this.HinhAnh = value; }
        }
        [DataMember]
        public DateTime _NgayCapNhat
        {
            get { return this.NgayCapNhat; }
            set { this.NgayCapNhat = value; }
        }
        [DataMember]
        public int _SoLuong
        {
            get { return this.SoLuong; }
            set { this.SoLuong = value; }
        }
        [DataMember]
        public int _MaNSX
        {
            get { return this.MaNSX; }
            set { this.MaNSX = value; }
        }
        [DataMember]
        public int _MaLoai
        {
            get { return this.MaLoai; }
            set { this.MaLoai = value; }
        }
    }
}