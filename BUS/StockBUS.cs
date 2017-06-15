using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class StockBUS
    {
        public static List<StockDTO> list()
        {
            return DAO.StockDAO.list();
        }
        public static StockDTO objectToDTO(object a)
        {
            return DAO.StockDAO.objectToDTO(a);
        }
    }
}
