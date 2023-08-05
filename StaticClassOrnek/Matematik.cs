using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassOrnek
{
    /// <summary>
    /// Tüm matematiksal işlemler sınıfı
    /// </summary>
    public class Matematik
    {
        #region Toplama İşlemi
        /// <summary>
        /// Kullanıcı tarafından giilen iki int
        /// sayının toplamını döndürür.
        /// </summary>
        /// <param name="x">int birinci sayı</param>
        /// <param name="y">int ikinci sayı</param>
        /// <returns>int sonuc</returns>
        static public int Topla(int x, int y)
        {
            return x + y;
        }
        #endregion




    }
}
