using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_使用字段_方法和屬性
{
    public class MyClass
    {
        public readonly string Name;
        private int intVal;

        public int Val
        {
            get
            {
                return intVal;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    intVal = value;
                }
                else
                {
                    throw new Exception("Val值必須在0~10之間");
                }
            }
        }

        public int MyInt
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public override string ToString()
        {
            return "Name:" + Name + "\nVal:" + Val;
        }

        public double MyMethod(double paramX, double paramY)
        {
            throw new System.NotImplementedException();
        }

        private MyClass()
            : this("Default Name")
        {
 
        }

        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
        }
    }
}
