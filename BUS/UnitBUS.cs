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
        public static string MaDonVi()
        {
            return DAO.UnitDao.MaDonVi();
        }

        public static void ThemDonVi(string Unit_ID, string UnitName, string Description, bool Active)
        {
            DAO.UnitDao.ThemDonVi(Unit_ID, UnitName, Description, Active);
        }

        public static void XoaDonVi(string Unit_ID)
        {
            DAO.UnitDao.XoaDonVi(Unit_ID);
        }

        public static void Sua(string Unit_ID, string UnitName, string Description, bool Active)
        {
            DAO.UnitDao.SuaDonVi(Unit_ID, UnitName, Description, Active);
        }
    }
}
