/**
 * Full homework description can be seen at: 
 * https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/02.%20Defining-Classes-Part-2/homework
 * 
 * 
 */
namespace Problem.Euclidian3DSpace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainEuclid3D
    {
        static void Main()
        {
            Point3D point3D = new Point3D();
            point3D.X = 5.0f;
            point3D.Y = 4.0f;
            point3D.Z = 2.0f;
            
            //Task 2
            Point3D startPoint = Point3D.StartCoordinate;

            Console.WriteLine("The initialized point is:" + point3D.ToString());
            Console.WriteLine("The starting point is " + startPoint.ToString());

            Console.WriteLine("The distance is " + CalculateDistance.CalculateEuclidianDistance(startPoint, point3D));
        }
    }
}
