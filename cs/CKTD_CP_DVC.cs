using System;

namespace CongTTDT_v1.App_Code.ORM.Model
{
    public class CKTD_CP_DVC
    {
        public virtual int ID { get; set; }
        public virtual DateTime TuNgay { get; set; }
        public virtual DateTime DenNgay { get; set; }
        public virtual DateTime ThoiGianCapNhat { get; set; }
        public virtual int TongSoDVCTiepNhan { get; set; }
        public virtual int TongSoDVCDaXuLy { get; set; }
        public virtual int TongSoDVCXuLyDungHan { get; set; }
        public virtual string MoTa { get; set; }
        public virtual float? TyLeDungHan { get; set; }
        public virtual int? TrangThai { get; set; }
        public virtual string ChuThich { get; set; }
    }
}
