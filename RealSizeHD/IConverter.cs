using System;
using System.Collections.Generic;
using System.Text;

namespace RealSizeHD
{
    interface IConverter
    {
        double getSizeMB();
        double getSizeGB();
        double getSizeTB();
    }
}
