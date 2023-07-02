using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace In_Lec
{
    class Parmetric_Model : _3D_Model
    {
        public void Design(float xv, float yv, float zv)
        {
            int R = 20;
            double x, y, Z = 0;
            int iP = 0;
            for (float th = 0; th < 360; th += 1)
            {   
                x = R * Math.Cos(th * Math.PI / 180);
                y = R * Math.Sin(th * Math.PI / 180);

                AddPoint(new _3D_Point((float)x + xv, (float)y + yv, (float)Z + zv));
                if (iP > 0 && th != 0)
                {
                    AddEdge(iP, iP - 1, Color.Red);
                }
                iP++;
            }
        }

    }
}
