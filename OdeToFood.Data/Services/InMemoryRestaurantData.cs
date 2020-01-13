using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;
        List<Hotel> hotels;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id=1, Name="Scott's Pizza", Cuisine=CuisineType.Italian },
                new Restaurant { Id=2, Name="Tersiguels", Cuisine=CuisineType.French },
                new Restaurant { Id=3, Name="Mango Grove", Cuisine=CuisineType.Indian },
            };
            hotels = new List<Hotel>()
            {
                new Hotel {Id=1, Name="Zelengora", Cuisine=CuisineType.French, Rate='B'},
                new Hotel {Id=1, Name="Kragujevac", Cuisine=CuisineType.Italian, Rate='A'},
                new Hotel {Id=1, Name="Sumarice", Cuisine=CuisineType.French, Rate='C'},
                new Hotel {Id=1, Name="Ema", Cuisine=CuisineType.Indian, Rate='A'}
            };
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public IEnumerable<Hotel> GetAllHotels()
        {
            return hotels.OrderBy(h => h.Name);
        }
    }
}
