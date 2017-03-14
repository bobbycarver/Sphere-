/*
 * Name: Bobby Carver 
 * Student number : 13170923
 *  Birmingham City University
 *  File: Sphere.CS V1.0
 * Created on : 27/01/2015
 * * */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_ASD
{
    class Sphere
    {
        private double Radius; // defining radius 
        private string  Material; // defining material 

        // constraints 
        const double PI = 3.14159; // sets PI 
        const double DensityCopper = 8930 ;
        const double DensityNickel = 8900;
        const double DensityGold = 19300;
        const double DensityAluminium = 27100;
        const double DensityBronze = 8500;
        const double DensitySteel = 7930;

            
   

        public Sphere(string mat) // construct for 1 parameter
        {
            this.Material = mat;
  

         

            switch (this.Material) // switch the radius based upon the material specified 
            {
                case "COPPER": // if the material is copper 
                    this.Radius = 1.3;
                    break;
                case "NICKEL": // if the material is NICKEL
                    this.Radius = 1.0;
                    break;
                case "GOLD": // if the material is GOLD
                   this.Radius = 2.4 ;
                    break; // break the case 
                default: // if the string doesnt match run the default 
                   this.Radius = 1.0;
                    break; // break the case 
            }

      
        }// end of con(1)

        public Sphere(string mat, double rad) // construct for 2 parameters
        {
            this.Material = mat;
            this.Radius = rad;
        } // end of con(2)

        public override string ToString() // to string method 
        {
            string message = "\n The material type selcted was " +this.Material + " And the radius selected is " + this.Radius; // to string message


            return message; // returns message 


        } // end of to string 

        public double CalculateSurfaceArea() // calc surface area 
        {
            return (4 * PI) * (this.Radius * this.Radius);
        } // end of surface area

        public double CalculateVolume() // calc volume 
        {
            return (4 * PI) * (this.Radius * this.Radius * this.Radius) / 3;
        } // end of calc volume

        public double GetRadius() // get radius 
        {
            return this.Radius;
        } // end of get radius 

        public string GetMaterial() // get material 
        {
            return this.Material;
        } // end of get material 

        public double CalculateWeight() // calculate weight 
        {
            double weight; // defines weight 
            switch (this.Material) // switch the answer based upon the material 
            {
                case "COPPER": // if the material is copper 
                    weight = this.CalculateVolume() * DensityCopper; // do this calculation
                    break;
                case "NICKEL": // if the material is NICKEL
                    weight = this.CalculateVolume() * DensityNickel; // do this calculation
                    break;
                case "GOLD": // if the material is GOLD
                    weight = this.CalculateVolume() * DensityGold; // do this calculation
                    break;
                case "ALUMINIUM": // if the material is aluminium 
                    weight = this.CalculateVolume() * DensityAluminium;
                    break;
                case "BRONZE": // if the material is bronze 
                     weight = this.CalculateVolume() * DensityBronze;
                     break;
                case "STEEL": // if the material is steel 
                     weight = this.CalculateVolume() * DensitySteel;
                    break; // break the case 
                default: // if the string doesnt match run the default 
                    weight = 0.0; // default weight is 0
                    break; // break the case 

            }
            return weight; // returns weight 

        }

    }
    
}
