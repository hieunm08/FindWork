using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class TaiKhoanDAO
    {
        TimKiemViecLamDbConText db = null;

        public TaiKhoanDAO()
        {
            db = new TimKiemViecLamDbConText();
        }
        public TaiKhoan GetbyUser(string userName)
        {
            return db.TaiKhoans.SingleOrDefault(x => x.TenDangNhap == userName);
        }
       
        public TaiKhoan ViewDetail(int id)
        {
            return db.TaiKhoans.Find(id);
        }
        public long Insert(TaiKhoan entity)
        {
            db.TaiKhoans.Add(entity);
            db.SaveChanges();
            return entity.ID_TaiKhoan;
        }
        public bool Edit(TaiKhoan entity)
        {
            try
            {
                var user = db.TaiKhoans.Find(entity.ID_TaiKhoan);
                user.TenDangNhap = entity.TenDangNhap;
                user.HoTen = entity.HoTen;
                user.ID_Vung = entity.ID_Vung;
                user.SDT = entity.SDT;
                user.Email = entity.Email;
                 db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Delete(int id)
        {
            try
            {
                var user = db.TaiKhoans.Find(id);
                db.TaiKhoans.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Object Login(string userName, string password)
        {
           
            var checkTaiKhoans = db.TaiKhoans.SingleOrDefault(x => x.TenDangNhap == userName);
            var checkUngVien = db.UngViens.SingleOrDefault(x => x.TenDangNhap == userName);
            var checkTuyenDung = db.CongTies.SingleOrDefault(x => x.TenDangNhap == userName);
            if (checkTaiKhoans!=null)
            {
                if (password == (checkTaiKhoans.MatKhau)){
                    return checkTaiKhoans;
                }
            }

            if (checkUngVien != null)
            {
                if (password == (checkTaiKhoans.MatKhau)){
                    return checkUngVien;
                }
            }

            if (checkTuyenDung != null)
            {
                if (password == (checkTaiKhoans.MatKhau)){
                    return checkTuyenDung;
                }
            }
            return null;
        }

      /*  public IEnumerable<TaiKhoan> listAllpage(string seaching, int page, int pageSize, int? idRole)
        {
            IQueryable<I> model = from a in db.Accounts
                                          join b in db.Roles
                                          on a.idRole equals b.Role_id
                                          select new UserLisst()
                                          {
                                              id = a.id,
                                              Email = a.Email,
                                              Address = a.Address,
                                              UserName = a.UserName,
                                              idRole = b.Role_id,
                                              RoleName = b.RoleName,
                                              Name = a.Name,
                                              Phone = a.Phone,
                                              PassWord = a.PassWord,
                                              status = a.status
                                          };
            if (!string.IsNullOrEmpty(seaching))
            {

                model = model.Where(x => x.Name.Contains(seaching) || x.RoleName.Contains(seaching) || x.RoleName.Contains(seaching)).OrderBy(x => x.id);
            }
            return model.OrderBy(x => x.id).ToPagedList(page, pageSize);
        }*/
        public List<LoaiTaiKhoan> list()
        {
            return db.LoaiTaiKhoans.ToList();
        }


    }
}
