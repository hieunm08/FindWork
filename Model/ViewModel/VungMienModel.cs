namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class VungMienModel
    {
        public int ID_Vung { get; set; }
        public string TenVung { get; set; }
        public List<TaiKhoan> TaiKhoans { get; set; }
        public List<ThanhPho> ThanhPhoes { get; set; }
    }
}
