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
            AtmName = "GÖZTEPE/ÝSTANBUL",
            CityName = "ÝSTANBUL",
            Address = "GÖZTEPE MAH. TÜTÜNCÜ MEHMETEFENDI CAD. D ERYA APT. NO: 107/4 KADIKÖY ÝSTANBUL"
        };
    }
}
