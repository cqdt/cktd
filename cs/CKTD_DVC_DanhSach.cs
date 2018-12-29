using System;

namespace CongTTDT_v1.App_Code.ORM.Model
{
    public class CKTD_DVC_DanhSach
    {
        public virtual int ID { get; set; }
        public virtual CKTD_DonVi DonVi { get; set; }
        public virtual string TenDichVu { get; set; }
        public virtual int? LoaiDichVu { get; set; }
        public virtual int? TrangThai { get; set; }
        public virtual string MoTa { get; set; }
    }
}
