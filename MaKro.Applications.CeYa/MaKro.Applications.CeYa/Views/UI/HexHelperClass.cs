using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MaKro.Applications.CeYa.Client.Views.UI
{
    public static class HexHelperClass
    {

        public static System.Windows.Media.Color GetColorFromHexValue(string aiHexValue)
        {
            return (System.Windows.Media.Color)ColorConverter.ConvertFromString(aiHexValue);
        }

    }
}
