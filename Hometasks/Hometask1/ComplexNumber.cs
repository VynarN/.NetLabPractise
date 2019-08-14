using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
        #region Operators overloading
        public static ComplexNumber operator +(ComplexNumber ob1, ComplexNumber ob2)
        {
            return new ComplexNumber(ob1.Real + ob2.Real, ob1.Imaginary + ob2.Imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber ob1, ComplexNumber ob2)
        {
            return new ComplexNumber(ob1.Real - ob2.Real, ob1.Imaginary - ob2.Imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber ob1, ComplexNumber ob2)
        {
            return new ComplexNumber(
                real: ob1.Real * ob2.Real - ob1.Imaginary * ob2.Imaginary,
                imaginary: ob1.Real * ob2.Imaginary + ob2.Real * ob1.Imaginary
                );
        }
        public static ComplexNumber operator /(ComplexNumber ob1, ComplexNumber ob2)
        {
            return new ComplexNumber(
                real: (ob1.Real * ob2.Real + ob1.Imaginary * ob2.Imaginary) / (ob2.Real * ob2.Real + ob2.Imaginary * ob2.Imaginary),
                imaginary: (ob1.Real * ob2.Imaginary + ob2.Real * ob1.Imaginary) / (ob2.Real * ob2.Real + ob2.Imaginary * ob2.Imaginary)
                );
        }
        #endregion
    }
}
