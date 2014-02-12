using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm_AHP
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        private double value;

        public static Fraction[,] CloneFractionMatrix(Fraction[,] src)
        {
            //拷贝原始矩阵
            int length1 = src.GetLength(0);
            int length2 = src.GetLength(1);

            Fraction[,] dest = new Fraction[length1, length2];
            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length2; j++)
                {
                    dest[i, j] = new Fraction(src[i, j]);
                }
            }
            return dest;
        }

        public Fraction(int _singleInt):this(_singleInt,1)
        {
        }

        public Fraction(string _textValue)
        {
            if (_textValue.Contains('/'))
            {
                int _numerator = Convert.ToInt32( _textValue.Split('/')[0]);
                int _denomiator = Convert.ToInt32(_textValue.Split('/')[1]);
                Init(_numerator, _denomiator);
            }
            else
            {
                Init(Convert.ToInt32(_textValue),1);
            }
        }

        public Fraction(int _numerator, int _denominator)
        {
            Init(_numerator, _denominator);
        }

        public Fraction(double _doubleValue)
        {
            if (_doubleValue<1)
            {
                this.value = _doubleValue;
                int intValue = (int) Math.Truncate( 1/_doubleValue+0.5);
                this.numerator = 1;
                this.denominator = intValue;
            }
            else
            {
                this.value = _doubleValue;
                int intValue = (int)Math.Truncate(_doubleValue + 0.5);
                this.numerator = intValue;
                this.denominator = 1;
            }
        }

        public Fraction(Fraction src)
        {
            this.numerator = src.numerator;
            this.denominator = src.denominator;
            this.value = src.value;
        }

        public Fraction Exchange()
        {
            Init(this.denominator, this.numerator);
            return this;
        }

        private void Init(int _numerator,int _denominator)
        {
            this.numerator = _numerator;
            this.denominator = _denominator;
            this.value = Convert.ToDouble(this.numerator) / Convert.ToDouble(this.denominator);
        }

        public string GetDisplayValue()
        {
            if (this.denominator !=1 )
            {
                return string.Format("{0}/{1}", this.numerator, this.denominator);
            }
            else
            {
                return string.Format("{0}", this.numerator);
            }
           
        }

        public double DoubleValue {
            set {
                if (value < 1)
                {
                    this.value = value;
                    int intValue = (int)Math.Truncate(1 / value + 0.5);
                    this.numerator = 1;
                    this.denominator = intValue;
                }
                else
                {
                    this.value = value;
                    int intValue = (int)Math.Truncate(value + 0.5);
                    this.numerator = intValue;
                    this.denominator = 1;
                }


                this.value = value;
            }
            get {
                return this.value;
            }
        }
    }
}
