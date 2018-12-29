using System;

namespace CongTTDT_v1.App_Code.ORM.Model
{
    public class CKTD_TaiKhoan
    {
        public virtual int ID { get; set; }
        public virtual CKTD_DonVi DonVi {get;set;}
        public virtual string TaiKhoan { get; set; }
        public virtual string MatKhau { get; set; }
        public virtual int? TrangThai { get; set; }
        public virtual string Ten { get; set; }
    }
}
