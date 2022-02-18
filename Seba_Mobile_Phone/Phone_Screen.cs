using System;

namespace Seba_Mobile_Phone
{
    public class Phone_Screen
    {
        public Size Resolution;
        public int Diagonal { get; set; }
        public bool Touchscreen { get; set; }
        public string Touchscreen_Type { get; set; }
        public bool Foldable { get; set; }
        public int Refresh_Rate { get; set; }
        public string Matrix_type { get; set; }
        public int PPI { get; set; }

    }
}
