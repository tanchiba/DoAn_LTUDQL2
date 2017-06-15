using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class VaiTroObject1BUS
    {
        public static List<VaiTroObject1DTO> getVaiTroObject()
        {
            return DAO.VaiTroObject1DAO.getVaiTroObject();
        }
        public static List<VaiTroObject1DTO> getNguoiDungByStr(String str)
        {
            return DAO.VaiTroObject1DAO.getNguoiDungByStr(str);
        }
    }
}
