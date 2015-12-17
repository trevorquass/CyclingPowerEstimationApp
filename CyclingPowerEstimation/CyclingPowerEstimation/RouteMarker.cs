using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace CyclingPowerEstimation
{
    public class RouteMarker : GMapMarker
    {
        public Pen pen;

        public RouteMarker(PointLatLng point) : base(point)
        {
            pen = new Pen(Brushes.Red, 2);
            Size = new Size(2, 2);
        }
        public override void OnRender(Graphics g)
        {
            g.DrawEllipse(pen, new System.Drawing.Rectangle(LocalPosition.X - Size.Width / 2, LocalPosition.Y - Size.Height / 2, Size.Width, Size.Height));
        }
    }
}
