namespace Problem.Euclidian3DSpace
{
    using System;

    struct Point3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        private static readonly Point3D startCoordinate = new Point3D(0, 0, 0);

        public Point3D(float x, float y, float z) : this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3D StartCoordinate { get { return startCoordinate; } }

        public override string ToString()
        {
            return String.Format("{{{0}, {1}, {2}}}", X, Y, Z);
        }
    }
}
