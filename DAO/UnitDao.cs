using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;
namespace DAO
{
    public class UnitDao
    {
        public static List<UnitDTO> list()
        {
                List<UnitDTO> dsEmpl = new List<UnitDTO>();
                using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
                {
                    var query = from em in db.UNITs
                                select em;
                    foreach (var row in query)
                    {
                        UnitDTO a = new UnitDTO();
                    a.Active = (Boolean)row.Active;
                    a.Description = row.Description;
                    a.UnitName = row.UnitName;
                    a.Unit_ID = row.Unit_ID;
                    dsEmpl.Add(a);
                    }
                    return dsEmpl;
                }
        }

        public static UnitDTO objectToDTO(object a)
        {
            return a as UnitDTO;
        }

        public static string MaDonVi()
        {
            string MaDonVi;
            var db = new QuanLyBanHangEntities();
            MaDonVi = db.UNITs.OrderByDescending(dv => dv.Unit_ID).FirstOrDefault().Unit_ID;
            if (MaDonVi != null)
            {
                MaDonVi = XuLyChuoi.LayChuoi(MaDonVi);
            }
            return MaDonVi;
        }

        public static void ThemDonVi(string Unit_ID, string UnitName, string Description, bool Active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                UNIT donvi = new UNIT();
                donvi.Unit_ID = Unit_ID;
                donvi.UnitName = UnitName;
                donvi.Description = Description;
                donvi.Active = Active;

                db.UNITs.Add(donvi);
                db.SaveChanges();
            }
        }

        public static void XoaDonVi(string Unit_ID)
        {
            var db = new QuanLyBanHangEntities();
            var rs = db.UNITs.Where(k => k.Unit_ID == Unit_ID).First();
            db.UNITs.Remove(rs);
            db.SaveChanges();
        }

        public static void SuaDonVi(string Unit_ID, string UnitName, string Description, bool Active)
        {
            var db = new QuanLyBanHangEntities();
            var rs = db.UNITs.Where(k => k.Unit_ID == Unit_ID).First();
            rs.UnitName = UnitName;
            rs.Description = Description;
            rs.Active = Active;
            db.SaveChanges();
        }

    }
}
