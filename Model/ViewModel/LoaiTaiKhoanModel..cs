namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class LoaiTaiKhoanModel
    {
  

        public int ID_LoaiTaiKhoan { get; set; }

   
        public string TenLoai { get; set; }

        
        public List<TaiKhoan> TaiKhoans { get; set; }
    }
}
