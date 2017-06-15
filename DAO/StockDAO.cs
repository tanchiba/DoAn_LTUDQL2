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
    }
}
