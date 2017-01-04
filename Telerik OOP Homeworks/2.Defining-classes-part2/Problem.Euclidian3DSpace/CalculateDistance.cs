namespace Problem.Euclidian3DSpace
{
    using System;

    static class CalculateDistance
    {
        public static float CalculateEuclidianDistance(Point3D point1, Point3D point2)
        {
            float deltaX = point2.X - point1.X;
            float deltaY = point2.Y - point1.Y;
            float deltaZ = point2.Z - point1.Z;

            float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance;
        }
    }
}
