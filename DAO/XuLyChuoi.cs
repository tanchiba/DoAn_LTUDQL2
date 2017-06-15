using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class XuLyChuoi
    {
        public static string LayChuoi(string Ma)
        {
            String kq = "";
            String KyHieu;
            int SoMoi;
            String temp;
            int vitri = Ma.Length - 6;
            KyHieu = Ma.Substring(0, Ma.Length - 5);
            temp = Ma.Substring(vitri + 1, 5);
            int.TryParse(temp, out SoMoi);
            SoMoi = SoMoi + 1;
            if (SoMoi < 10)
            {
                kq = KyHieu + "0000" + SoMoi;

            }
            if (SoMoi >= 10 && SoMoi < 100)
            {
                kq = KyHieu + "000" + SoMoi;
            }

            if (SoMoi >= 100 && SoMoi < 1000)
            {
                kq = KyHieu + "00" + SoMoi;

            }
            if (SoMoi >= 1000 && SoMoi < 9999)
            {
                kq = KyHieu + "0" + SoMoi;

            }

            if (SoMoi >= 10000 && SoMoi < 99999)
            {
                kq = KyHieu + SoMoi;
            }

            return kq;
        }
    }
}
