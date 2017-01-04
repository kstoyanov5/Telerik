using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem.Euclidian3DSpace
{
    class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

    }
}
