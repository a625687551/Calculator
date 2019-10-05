using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Oper
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumnberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0d;
            return result;
        }
    }

    // 加法
    public class OperAdd : Oper
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumnberB;
            return result;
        }
    }

    public class OPerSub : Oper
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumnberB;
            return result;
        }
    }
    public class OPerMul : Oper
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumnberB;
            return result;
        }
    }
    public class OperDiv : Oper
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumnberB == 0)
            {
                throw new Exception("除数不能为0");
            }
            result = NumberA * 1.0 / NumnberB;
            return result;
        }
    }
    


}
