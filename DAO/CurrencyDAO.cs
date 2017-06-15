using DAO.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CurrencyDAO
    {
        DTO.CurrencyDTO db = new DTO.CurrencyDTO();
        public static dynamic DanhSach(String Currency_ID)
        {
            List<CURRENCY> ds = new List<CURRENCY>();
            using (QuanLyBanHangEntities dk = new QuanLyBanHangEntities())
            {
                var query = from u in dk.CURRENCies
                            where u.Currency_ID == Currency_ID
                            select u;

                foreach (var row in query)
                {
                    CURRENCY tygia = new CURRENCY();
                    tygia.Currency_ID = row.Currency_ID;
                    tygia.CurrencyName = row.CurrencyName;
                    tygia.Exchange = row.Exchange;
                    tygia.Active = row.Active;
                    ds.Add(tygia);
                }

                return ds;
            }
        }

        public static dynamic LoadData()
        {
            List<CURRENCY> dstygia = new List<CURRENCY>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from u in db.CURRENCies
                            select u;
                foreach (var row in query)
                {
                    CURRENCY tygia = new CURRENCY();
                    tygia.Currency_ID = row.Currency_ID;
                    tygia.CurrencyName = row.CurrencyName;
                    tygia.Exchange = row.Exchange;
                    tygia.Active = row.Active;
                    dstygia.Add(tygia);
                }

                return dstygia;
            }
        }

        
        public static void Them(string Currency_ID, string CurrencyName, long? Exchange, bool Active)
        {
            QuanLyBanHangEntities dbContext = new QuanLyBanHangEntities();
            var tygia = new CURRENCY();
            tygia.Currency_ID = Currency_ID;
            tygia.CurrencyName = CurrencyName;
            tygia.Exchange = Exchange;
            tygia.Active = (Active == true) ? true : false;
            dbContext.CURRENCies.Add(tygia);
            dbContext.SaveChanges();

        }

        public static void Xoa(string Currency_ID)
        {
            var db = new QuanLyBanHangEntities();
            var delete = db.CURRENCies.Where(k => k.Currency_ID == Currency_ID).First();
            db.CURRENCies.Remove(delete);
            db.SaveChanges();

        }

        public static void Sua(String Currency_ID, string CurrencyName, long? Exchange, bool Active)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            var rs = db.CURRENCies.Where(k => k.Currency_ID == Currency_ID).First();
            rs.CurrencyName = CurrencyName;
            rs.Exchange = Exchange;
            rs.Active = Active;
            db.SaveChanges();

        }

    }
}
