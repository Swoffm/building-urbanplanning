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

        private List<Building> _buildingList;

        public City(string city, string mayor, Building building)
        {
            _cityName = city;
            _mayor = mayor;
            _buildingList.Add(building);
        }



    }







}