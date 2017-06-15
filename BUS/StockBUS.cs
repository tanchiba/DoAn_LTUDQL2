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

        public static string Stock_ID()
        {
            return DAO.StockDAO.Stock_ID();
        }

        public void Them(string Stock_ID, string StockName, string StockAddress, string Email, string Tel, string Description, bool Active, string Manager_ID)
        {
            DAO.StockDAO.Them(Stock_ID, StockName, StockAddress, Email, Tel, Description, Manager_ID, Active);
        }


        public static void Xoa(string Stock_ID)
        {
            DAO.StockDAO.Xoa(Stock_ID);
        }

        public static void Sua(string Stock_ID, string StockName, string StockAddress, string Email, string Tel, string Description, bool Active, string Manager_ID)
        {
            DAO.StockDAO.Sua(Stock_ID, StockName, StockAddress, Email, Tel, Description, Active, Manager_ID);
        }
    }
}
