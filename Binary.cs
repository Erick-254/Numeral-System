using System;
using System.Collections.Generic;
using System.Text;

namespace NumeralSystems
{
    class Binary:INumber
    {
        protected string binary { get; private set; }

        public Binary(string newBinary)
        {
            binary = newBinary;

        }

        public string ToDecimal()
        {
            var convert = new Decimal();
            return convert.AnySystemToDecimal(this.binary, 2);
        }

        public string ToOcta()
        {
            var binaryToDecimal = ToDecimal();
            var convert = new Decimal(binaryToDecimal);
            return convert.ToOcta();
        }

        public string ToBinary()
        {
            return this.binary;
        }

        public string ToHex()
        {
            var binaryToDecimal = ToDecimal();
            var convert = new Decimal(binaryToDecimal);
            return convert.ToHex();
        }

        public void ShowResults()
        {
            throw new NotImplementedException();
        }
    }
}
