using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lesson_2_3
{
    internal class vector3D
    {
        private double OX;
        private double OY;
        private double OZ;
        public vector3D(double ox, double oy, double oz)
        {
            OX = ox;
            OY = oy;
            OZ = oz;
        }
        void Read()
        {
            Console.WriteLine("Укажите координату вектора OX:");
            OX = Convert.ToDouble(Console.Read());
            Console.WriteLine("Укажите координату вектора OY:");
            OY = Convert.ToDouble(Console.Read());
            Console.WriteLine("Укажите координату вектора OZ:");
            OZ = Convert.ToDouble(Console.Read());
            Console.WriteLine("");
        }
        void Display()
        {
            Console.WriteLine($"Вектор с координатами {OX}, {OY}, {OZ}, имеет длинну {Length(new vector3D(OX,OY,OZ))}");
        }
        public vector3D Addition(vector3D vector1, vector3D vector2)
        {
            return new vector3D(vector1.OX + vector2.OX, vector1.OY + vector2.OY, vector1.OZ + vector2.OZ);
        }
        public vector3D Subtraction(vector3D vector1, vector3D vector2)
        {
            return new vector3D(vector1.OX - vector2.OX, vector1.OY - vector2.OY, vector1.OZ - vector2.OZ);
        }
        public double ScalarProduct (vector3D vector1, vector3D vector2)
        {
            return Math.Sqrt(Math.Pow(vector1.OX, 2) + Math.Pow(vector1.OY, 2) + Math.Pow(vector1.OZ, 2)) * Math.Sqrt(Math.Pow(vector2.OX, 2) + Math.Pow(vector2.OY, 2) + Math.Pow(vector2.OZ, 2)) * (vector1.OX * vector2.OX + vector1.OY * vector2.OY + vector1.OZ - vector2.OZ) / (Math.Sqrt(Math.Pow(vector1.OX, 2) + Math.Pow(vector1.OY, 2) + Math.Pow(vector1.OZ, 2)) * Math.Sqrt(Math.Pow(vector2.OX, 2) + Math.Pow(vector2.OY, 2) + Math.Pow(vector2.OZ, 2)));
        }
        public vector3D MultiplicationByScalar(vector3D vector, double scalar)
        {
            return new vector3D(vector.OX * scalar, vector.OY * scalar, vector.OZ * scalar);
        }
        public string Comparison (vector3D vector1, vector3D vector2)
        {
            if (vector1.OX == vector2.OX && vector1.OY == vector2.OY && vector1.OZ == vector2.OZ)
                return "Векторы равны";
            else
                if (vector1.OX != vector2.OX || vector1.OY != vector2.OY || vector1.OZ != vector2.OZ)
                    return "Векторы не равны";
                else
                    return "Введены неверные данные";
        }
        public double Length(vector3D vector)
        {
            return Math.Sqrt(Math.Pow(vector.OX, 2) + Math.Pow(vector.OY, 2) + Math.Pow(vector.OZ, 2));
        }
        public string LengthComparison(vector3D vector1, vector3D vector2)
        {
            if (Length(vector1) > Length(vector2))
                return $"Вектор {vector1} больше чем вектор {vector2}";
            else
                if (Length(vector1) < Length(vector2))
                    return $"Вектор {vector1} меньше чем вектор {vector2}";
                else
                    if (Length(vector1) == Length(vector2))
                        return "Векторы равны";
                    else
                        return "Введены неверные данные";
        }
    }
}
