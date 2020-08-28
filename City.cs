using System;
using System.Collections.Generic;

namespace Planner

{

    public class City
    {

        // Fields
        private string _cityName;
        private string _mayor;

        private DateTime _yearEstablished;

        // properties 
        public string CityName { get; set; }
        public string Mayor { get; set; }

        public List<Building> BuildingList { get; set; }

        public City(string city, string mayor)
        {
            _cityName = city;
            _mayor = mayor;

        }



    }







}