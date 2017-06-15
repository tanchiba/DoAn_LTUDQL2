using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class CUSTOMER_GROUPBUS
    {
        public static List<CUSTOMER_GROUPDTO> list()
        {
            return DAO.CUSTOMER_GROUPDAO.list();
        }

        public static string MaKhuVuc()
        {
            return DAO.CUSTOMER_GROUPDAO.MaKhuVuc();
        }

        public static void deleteID(string id)
        {
            DAO.CUSTOMER_GROUPDAO.deleteID(id);
        }
        public static void add(string groupid, string groupname, string description, bool active)
        {
            DAO.CUSTOMER_GROUPDAO.add(groupid, groupname, description, active);
        }
        public static void EditByID(string ID, string groupname, string desciption, bool active)
        {
            DAO.CUSTOMER_GROUPDAO.EditByID(ID, groupname, desciption, active);
        }
        public static CUSTOMER_GROUPDTO objectToDTO(object a)
        {
            return DAO.CUSTOMER_GROUPDAO.objectToDTO(a);
        }
    }
}
