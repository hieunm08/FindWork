namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public  class ThanhPhoModel
    {
      
        public int ID_ThanhPho { get; set; }

    
        public string TenThanhPho { get; set; }

        public int? ID_Vung { get; set; }


        public List<CongTy> CongTies { get; set; }

        public  VungMien VungMien { get; set; }

        public List<UngVien> UngViens { get; set; }
    }
}
