﻿namespace RestaurantNMV.Models
{
    public class Dish
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Description { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set }

    }
}
