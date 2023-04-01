using System;
using System.Collections.Generic;
using System.Text;

namespace Pz_5_Interface
{
    class Sotrudnik : ICloneable, IComparable<Sotrudnik>
    {
        private string name;
        private int age;
        private Otdel_name otdel = new Otdel_name();

        public string Name { get { return name;} set { name = value;} }
        public int Age { get { return age; } set { age = value; } }
        public Otdel_name Otdel { get {  return otdel;} set { otdel = value;} }

        public Sotrudnik(string name, int age, Otdel_name otdel)
        {
            Name = name;
            Age = age;
            Otdel = otdel;
        }

        public object Clone() => new Sotrudnik(Name, Age, Otdel);
        public int CompareTo(Sotrudnik? other)
        {
            if (other is Sotrudnik sotudnik) return Name.CompareTo(sotudnik.Name);
            else throw new ArgumentException("Некорректное значение параметра"); throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{name}, {age} лет, отдел: {otdel}";
        }

    }
}
