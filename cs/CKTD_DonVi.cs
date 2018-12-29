using System;

namespace CongTTDT_v1.App_Code.ORM.Model
{
    public class CKTD_DonVi
    {
        public virtual int ID { get; set; }
        public virtual string TenDonVi { get; set; }
        public virtual int? TrangThai { get; set; }
        public virtual int? LoaiDonVi { get; set; }
        public virtual int? STT { get; set; }
        public virtual string DiaChi { get; set; }
        public virtual string Email { get; set; }
        public virtual string DienThoai { get; set; }
        public virtual string Fax { get; set; }
    }
}
