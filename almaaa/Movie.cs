using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace almaaa
{
    internal class Movie
    {
        private string title;
        private string diractor;
        private int lengthMin;
        private string type;
        private bool release;


        public Movie(string title, string diractor, int lengthMin, string type, bool release)
        {
            this.title = title;
            this.diractor = diractor;
            this.lengthMin = lengthMin;
            this.type = type;
            this.release = release;
        }

        public Movie(string title, string diractor)
        {
            this.title = title;
            this.diractor = diractor;
            this.lengthMin = 120;
            this.type = "ismeretlen";
            this.release = false;
        }

        public string Title { get => title; set => title = value; }
        public string Diractor { get => diractor; set => diractor = value; }
        public int LengthMin { get => lengthMin; set => lengthMin = value; }
        public string Type { get => type; set => type = value; }
        public bool Release { get => release; set => release = value; }



        public string Play()
        {
            if (release == true)
            {
                return "a film elkezdődött";
            }
            else
            {
                return "a film nem kezdődött el";
            }
        }

        public string TypeChange(string newtype)
        {
           return this.type = newtype;
        }

        public int LengthInc(int increase)
        {
            return this.lengthMin + increase;
        }

        public override string ToString()
        {
            return $"{title} - {diractor} / {lengthMin} / {type} - {release}";
        }

    }
}
