using System;

namespace LocationAPI
{
    public class Location
    {
        public string AtmName { get; set; }

        public string CityName { get; set; }

        public string Address { get; set; }

        public static readonly Location Default = new Location()
        {
            AtmName = "G�ZTEPE/�STANBUL",
            CityName = "�STANBUL",
            Address = "G�ZTEPE MAH. T�T�NC� MEHMETEFENDI CAD. D ERYA APT. NO: 107/4 KADIK�Y �STANBUL"
        };
    }
}
