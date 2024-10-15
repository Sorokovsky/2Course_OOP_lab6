namespace Task_1
{
    public class Fraction
    {
        private int _sign;
        private int _intPart;
        private int _numerator;
        private int _denominator;

        public Fraction(int numerator, int denominator, int intPart = 0, int sign = 1)
        {
            _denominator = denominator;
            _numerator = numerator;
            _sign = sign;
            _intPart = intPart;
            GetMixedView();
        }

        public Fraction() : this(0, 1, 0, 1)
        {
            
        }

        public void GetMixedView()
        {
            GetIntPart();
            Cancellation();
        }

        public void GetIntPart()
        {
            if(_numerator >= _denominator)
            {
                _intPart += (_numerator / _denominator);
                _numerator %= _denominator;
            }
        }
        
        public void Cancellation()
        {
            if(_numerator != 0)
            {
                int m = _denominator, n = _numerator, ost = m % n;
                while(ost != 0)
                {
                    m = n;
                    n = ost;
                    ost = m % n;
                }

                int nod = n;
                if(nod != 1)
                {
                    _numerator /= nod;
                    _denominator /= nod;
                }
            }
        }

        public static explicit operator double(Fraction fraction)
        {
            double res = (double)fraction._sign *
                (fraction._intPart * fraction._denominator + fraction._numerator) /
                fraction._denominator;
            return res;
        }

        public static bool operator > (Fraction fraction1, Fraction fraction2)
        {
            if ((double)fraction1 <= (double)fraction2) return false;
            else return true;
        }

        public static bool operator <(Fraction fraction1, Fraction fraction2)
        {
            if ((double)fraction1 >= (double)fraction2) return false;
            else return true;
        }

        public static bool operator >= (Fraction fraction1, Fraction fraction2)
        {
            if((double)fraction1 < (double)fraction2) return false;
            return true;
        }

        public static bool operator <=(Fraction fraction1, Fraction fraction2)
        {
            if ((double)fraction1 > (double)fraction2) return false;
            return true;
        }

        public static bool operator >(Fraction fraction1, double fraction2)
        {
            if ((double)fraction1 <= fraction2) return false;
            else return true;
        }

        public static bool operator <(Fraction fraction1, double fraction2)
        {
            if ((double)fraction1 >= fraction2) return false;
            else return true;
        }

        public static bool operator >=(Fraction fraction1, double fraction2)
        {
            if ((double)fraction1 < fraction2) return false;
            return true;
        }

        public static bool operator <=(Fraction fraction1, double fraction2)
        {
            if ((double)fraction1 > fraction2) return false;
            return true;
        }

        public static bool operator >(double fraction1, Fraction fraction2)
        {
            if (fraction1 <= (double)fraction2) return false;
            else return true;
        }

        public static bool operator <(double fraction1, Fraction fraction2)
        {
            if (fraction1 >= (double)fraction2) return false;
            else return true;
        }

        public static bool operator >=(double fraction1, Fraction fraction2)
        {
            if (fraction1 < (double)fraction2) return false;
            return true;
        }

        public static bool operator <=(double fraction1, Fraction fraction2)
        {
            if (fraction1 > (double)fraction2) return false;
            return true;
        }
    }
}
