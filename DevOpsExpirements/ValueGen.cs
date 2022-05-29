using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsExpirements
{
    internal class ValueGen : ICalc
    {
        Random rnd = new Random();
        int x, y, result;

        //ctor
        public ValueGen()
        {
            InitValues();
        }

        //Init value
        private void InitValues()
        {
            this.x = rnd.Next();
            this.y = rnd.Next();
        }

        public string Add(int x, int y)
        {
            result = x + y;
            return $"{x} + {y} = {result}";
        }

        public string Div(int x, int y)
        {
            result = x / y;
            return $"{x} / {y} = {result}";
        }

        public string Mult(int x, int y)
        {
            result = x * y;
            return $"{x} x {y} = {result}";
        }

        public string Sub(int x, int y)
        {
            result = x - y;
            return $"{x} - {y} = {result}";
        }



        
    }
}
