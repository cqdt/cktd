using System;

namespace CongTTDT_v1.App_Code.ORM.Model
{
    public class CKTD_CP_VanBan
    {
        public virtual int ID { get; set; }
        public virtual DateTime TuNgay { get; set; }
        public virtual DateTime DenNgay { get; set; }
        public virtual DateTime ThoiGianCapNhat { get; set; }
        public virtual string MoTa { get; set; }
        public virtual string ChuThich { get; set; }
        public virtual int? TrangThai { get; set; }
        public virtual int TongSoVanBan { get; set; }
    }
}
