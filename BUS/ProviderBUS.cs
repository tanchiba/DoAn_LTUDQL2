using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class ProviderBUS
    {
        public static List<ProviderDTO> list()
        { return DAO.ProviderDao.list(); }
        public static ProviderDTO objectToDTO(object a)
        {
            return a as ProviderDTO;
        }
    }
}
