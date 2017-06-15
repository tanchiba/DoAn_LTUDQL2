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
    }
}
