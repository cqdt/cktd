﻿using System;

namespace CongTTDT_v1.App_Code.ORM.Model
{
    public class CKTD_VanBan_TienTrinh
    {
        public virtual int ID { get; set; }
        public virtual string TenTienTrinh { get; set; }
        public virtual string ThoiGian { get; set; }
        public virtual int? TrangThai { get; set; }
        public virtual string CSDL_VanBan { get; set; }
        public virtual string LenhTruyVan { get; set; }
    }
}
