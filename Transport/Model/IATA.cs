using System;

namespace Transport.ly.App.Model
{
    public class IATA : IEquatable<IATA>
    {
        public string Code { get; private set; }

        private IATA() {}

        public IATA(string code)
        {
            Code = code;
        }

        public override string ToString()
        {
            return Code;
        }

        public override bool Equals(object obj)
        {
            return obj is IATA iATA && Equals(iATA);
        }

        public bool Equals(IATA other)
        {
            return Code == other.Code;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Code);
        }

        public static bool operator ==(IATA left, IATA right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IATA left, IATA right)
        {
            return !(left == right);
        }
    }
}
