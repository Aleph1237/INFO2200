using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _2200_WoodsC_Assignment02
{
    public class Food
    {      
        public Food() // no-arg (parameterless) constructor
        {
            
        }

        // constructor for receiving a string array
        public Food(string[] foodArray ) // parameterized constructor
        {
            // call to properties to assign values from the foodArray

            //you will need to fix and complete this part for the full data file. The comments below show where they would go for the full data file.

            FoodName = foodArray[0];
            Calcium = double.Parse(foodArray[1]);
            ServingSize = foodArray[2];
            Weight = double.Parse(foodArray[3]);
            PercentWater = double.Parse(foodArray[4]);
            Energy = double.Parse(foodArray[5]);
            Protein = double.Parse(foodArray[6]);
            Carbohydrate = double.Parse(foodArray[7]);
            Fiber = double.Parse(foodArray[8]);
            Cholesterol = double.Parse(foodArray[9]); // double.Parse(foodArray[9]);
            TotalFat = double.Parse(foodArray[10]);
            SaturateFat = double.Parse(foodArray[11]);
            MonosatFat = double.Parse(foodArray[12]);
            PolyunsatFat = double.Parse(foodArray[13]);
            Iron = double.Parse(foodArray[14]);
            Magnesium = double.Parse(foodArray[15]);
            Sodium = double.Parse(foodArray[16]);
            Phosphorous = double.Parse(foodArray[17]);
            CaPRation = double.Parse(foodArray[18]);
            Potassium = double.Parse(foodArray[19]);
            Zinc = double.Parse(foodArray[20]); // double.Parse(foodArray[20]);
            Niacin = double.Parse(foodArray[21]);
            Thiamin = double.Parse(foodArray[22]);
            Riboflavin = double.Parse(foodArray[23]);
            VitA = double.Parse(foodArray[24]);
            VitB6 = double.Parse(foodArray[25]);
            VitC = double.Parse(foodArray[26]);
            FoodType = foodArray[27]; // foodArray[27];
        }
        
        // properties // this part is complete, but check it against the assignment in canvas
        public string FoodName { get; set; }
        public double Calcium { get; set;}
        public string ServingSize { get; set;}
        public double Weight {  get; set;}
        public double PercentWater { get; set;}
        public double Energy { get; set;}
        public double Protein { get; set;}
        public double Carbohydrate { get; set;}
        public double Fiber { get; set;}
        public double Cholesterol { get; set;}
        public double TotalFat { get; set;}
        public double SaturateFat { get; set;}
        public double MonosatFat { get; set;}
        public double PolyunsatFat { get; set;}
        public double Iron { get; set;}
        public double Magnesium { get; set;}
        public double Sodium { get; set;}
        public double Phosphorous { get; set;}
        public double CaPRation { get; set;}
        public double Potassium { get; set;}
        public double Zinc { get; set;}
        public double Niacin { get; set;}
        public double Thiamin { get; set;}
        public double Riboflavin { get; set;}
        public double VitA { get; set;}
        public double VitB6 { get; set;}
        public double VitC { get; set;}
        public string FoodType { get; set;}
    }
}
