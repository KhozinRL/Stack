using System;
namespace Stack
{
    public class Integer: ICloneable
    {
        int number;

        public Integer() {
            number = new Random().Next(0, 100);
        }

        public Integer(int number) {
            this.number = number;
        }

        public object Clone()
        {
            return new Integer(number);
        }

        public static implicit operator Integer(int i)
        {
            return new Integer(i);
        }

        override
        public string ToString() {
            return number.ToString();
        }

    }
}
