using Model.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    class DangTuyenDungModel
    {
        public int ID_ViecLam { get; set; }

        [StringLength(250)]
        public string TieuDeViecLam { get; set; }

        public string MoTa { get; set; }

        public int? ID_NganhNghe { get; set; }

        public int? ID_ViTri { get; set; }

        [StringLength(100)]
        public string GioiTinh { get; set; }

        public string YeuCauKyNang { get; set; }

        [StringLength(100)]
        public string ThoiGianThuViec { get; set; }

        public int? ID_KinhNghiem { get; set; }

        public int? ID_TrinhDo { get; set; }

        [StringLength(50)]
        public string MucLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        public bool? TrangThai { get; set; }

        public int? ID_CongTy { get; set; }

        public int? SoLuong { get; set; }

        public string YeuCauHoSo { get; set; }

        public virtual CongTy CongTy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKy> DangKies { get; set; }

        public virtual KinhNghiem KinhNghiem { get; set; }

        public virtual NganhNghe NganhNghe { get; set; }

        public virtual TrinhDo TrinhDo { get; set; }

        public virtual ViTriUngTuyen ViTriUngTuyen { get; set; }

        public int ID_CongTy { get; set; }

        [StringLength(255)]
        [Display(Name = "Tên công ty (*)")]
        [Required(ErrorMessage = "Vui lòng nhập tên công ty")]
        public string TenCongTy { get; set; }
        [StringLength(150)]
        public string TenDangNhap { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(250)]
        public string QuyMo { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại liên hệ")]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Website { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập sơ lượng về công ty")]
        public string MoTa { get; set; }

        [StringLength(150)]
        public string NguoiDaiDien { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public int? ID_ThanhPho { get; set; }

        public int? IsTuyenDung { get; set; }

        public virtual ThanhPho ThanhPho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TinViecLam> TinViecLams { get; set; }
    }
}
