using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;
namespace DAO
{
    public class StockDAO
    {
        public static List<StockDTO> list()
        {
            List<StockDTO> dsEmpl = new List<StockDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from em in db.STOCKs
                            select em;
                foreach (var row in query)
                {
                    StockDTO cg = new StockDTO();
                    cg.Active = (Boolean)row.Active;
                    cg.Description = row.Description;
                    cg.Email = row.Email;
                    cg.StockAddress = row.StockAddress;
                    cg.StockName = row.StockName;
                    cg.Stock_ID = row.Stock_ID;
                    cg.Tel = row.Tel;
                    //empl.Active = (row.Active);
                    dsEmpl.Add(cg);
                }
                return dsEmpl;
            }
        }
        public static StockDTO objectToDTO(object a)
        { return a as StockDTO; }


        public static string Stock_ID()
        {
            string Stock_ID;
            var db = new QuanLyBanHangEntities();
            Stock_ID = db.STOCKs.OrderByDescending(k => k.Stock_ID).FirstOrDefault().Stock_ID;
            if (Stock_ID != null)
            {
                Stock_ID = XuLyChuoi.LayChuoi(Stock_ID);

            }

            return Stock_ID;
        }

        public static void Them(string Stock_ID, string StockName, string StockAddress, string Email, string Tel, string Description, string Manager_ID, bool Active)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            var khohang = new STOCK();
            khohang.Stock_ID = Stock_ID;
            khohang.StockName = StockName;
            khohang.StockAddress = StockAddress;
            khohang.Email = Email;
            khohang.Tel = Tel;
            khohang.Description = Description;
            khohang.Manager_ID = Manager_ID;
            khohang.Active = Active;
            db.STOCKs.Add(khohang);
            db.SaveChanges();
        }

        public static void Xoa(string Stock_ID)
        {
            var db = new QuanLyBanHangEntities();
            var rs = db.STOCKs.Where(k => k.Stock_ID == Stock_ID).First();
            db.STOCKs.Remove(rs);
            db.SaveChanges();


        }

        public static void Sua(string Stock_ID, string StockName, string StockAddress, string Email, string Tel, string Description, bool Active, string Manager_ID)
        {
            var db = new QuanLyBanHangEntities();
            var rs = db.STOCKs.Where(k => k.Stock_ID == Stock_ID).First();
            rs.StockName = StockName;
            rs.StockAddress = StockAddress;
            rs.Email = Email;
            rs.Tel = Tel;
            rs.Description = Description;
            rs.Active = Active;
            rs.Manager_ID = Manager_ID;
            db.SaveChanges();

        }

    }
}
