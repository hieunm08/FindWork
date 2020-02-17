namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public  class UngVienModel
    {
        public int ID_UngVien { get; set; }

        public string HoTen { get; set; }

        public string MatKhau { get; set; }

        public string DiaChi { get; set; }

        public DateTime? NgaySinh { get; set; }


        public string GioiTinh { get; set; }


        public string Email { get; set; }

        public string SDT { get; set; }


        public List<CV_UngVien> CV_UngVien { get; set; }

        public  ThanhPho ThanhPho { get; set; }
    }
}
