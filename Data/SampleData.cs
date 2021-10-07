using System.Collections.Generic;
using W5Lab.Models;

namespace W5Lab.Data
{
    public class SampleData
    {
        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>() {
                new Province() {
                    ProvinceCode="BC",
                    ProvinceName="British Columbia"
                },
                new Province() {
                    ProvinceCode="AB",
                    ProvinceName="Alberta"
                },
                new Province() {
                    ProvinceCode="ON",
                    ProvinceName="Ontario"
                }
            };

            return provinces;
        }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>() {
                new City {
                    CityId = 1,
                    CityName = "Victoria",
                    Population = 92000,
                    ProvinceCode = "BC",
                },
                new City {
                    CityId = 2,
                    CityName = "Vancouver",
                    Population = 675000,
                    ProvinceCode = "BC",
                },
                new City {
                    CityId = 3,
                    CityName = "Burnaby",
                    Population = 249000,
                    ProvinceCode = "BC",
                },
                new City {
                    CityId = 4,
                    CityName = "Edmonton",
                    Population = 981000,
                    ProvinceCode = "AB",
                },
                new City {
                    CityId = 5,
                    CityName = "Calgary",
                    Population = 1300000,
                    ProvinceCode = "AB",
                },
                new City {
                    CityId = 6,
                    CityName = "Red Deer",
                    Population = 103000,
                    ProvinceCode = "AB",
                },
                new City {
                    CityId = 7,
                    CityName = "Toronto",
                    Population = 3000000,
                    ProvinceCode = "ON",
                },
                new City {
                    CityId = 8,
                    CityName = "Ottawa",
                    Population = 930000,
                    ProvinceCode = "ON",
                },
                new City {
                    CityId = 9,
                    CityName = "Hamilton",
                    Population = 500000,
                    ProvinceCode = "ON",
                },
            };

            return cities;
        }

    }
}