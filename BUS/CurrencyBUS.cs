using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CurrencyBUS
    {
        public List<DTO.CurrencyDTO> listtygia;
        public static dynamic LoadData()
        {
            return DAO.CurrencyDAO.LoadData();
        }  

        public void Them(string Currency_ID, string CurrencyName, long? Exchange, bool Active)
        {
            DAO.CurrencyDAO.Them(Currency_ID, CurrencyName, Exchange, Active);
        }

        public static void Xoa(string Currency_ID)
        {
            DAO.CurrencyDAO.Xoa(Currency_ID);
        }

        public void Sua(string Currency_ID, string CurrencyName, long? Exchange, bool Active)
        {
            DAO.CurrencyDAO.Sua(Currency_ID, CurrencyName, Exchange, Active);
        }

        public dynamic LoadDataSua(string Currency_ID)
        {
            return DAO.CurrencyDAO.DanhSach(Currency_ID);
        }
    }
}
