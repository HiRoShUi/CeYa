using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MaKro.Applications.CeYa.Client.Views.UI
{
    public class Color
    {
        #region Window-Colors
        public System.Windows.Media.Brush Window_Background_Main
        {
            get
            {
                return new SolidColorBrush(HexHelperClass.GetColorFromHexValue("#424242"));
            }
        }

        public System.Windows.Media.Brush Window_Background_Top
        {
            get
            {
                return new SolidColorBrush(HexHelperClass.GetColorFromHexValue("#0091EA"));
            }
        }

        public System.Windows.Media.Brush Window_Background_Bottom
        {
            get
            {
                return new SolidColorBrush(HexHelperClass.GetColorFromHexValue("#0091EA"));
            }
        }
        #endregion

        #region Font-Colors

        public System.Windows.Media.Brush Font_Foreground_Main
        {
            get
            {
                return new SolidColorBrush(HexHelperClass.GetColorFromHexValue("#E0E0E0"));
            }
        }

        public System.Windows.Media.Brush Font_Foreground_Top
        {
            get
            {
                return new SolidColorBrush(HexHelperClass.GetColorFromHexValue("#B3E5FC"));
            }
        }




        #endregion
    }
}
