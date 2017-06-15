using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
   public class UnitBUS
    {
        public static List<UnitDTO> list()
        {
            return DAO.UnitDao.list();
        }
        public static UnitDTO objectToDTO(object a)
        {
            return DAO.UnitDao.objectToDTO(a);
        }
    }
}
