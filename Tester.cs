/*
 * Name: Bobby Carver 
 * Student number : 13170923
 *  Birmingham City University
 *  File: Tester.CS V1.0
 * Created on : 27/01/2015
 * * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_ASD
{
    class Tester
    {
        static void Pause(string s)
        {
            Console.Write(s);
            Console.Read();
        }
        public void Run()
        {
            Sphere S1; // sets the  Sphere to S1
            int choice = 0; // users choice set to 0 
            int flag = 0; // flag for loop set to 0 

            
            string material; // material 
            double radius; // radius 


            // introduction messages.
            string intro = "\n Program to calculate properties of a Sphere of various materials";
            intro += "\n\n Author: Bobby Carver  (c) 2015";
            intro += "\n Student Number 13170923";
            Console.Title = "Sphere of material application";
            Console.Clear(); // clear screen 
            Console.WriteLine(intro); // writes message to screen 

            while (flag == 0) // while the flag is set at 0 run the following code 
            {
                do // second loop within a loop based on users actions
                {
                    //prints user options onto the screen
                    Console.WriteLine("\n Choose from : ");
                    Console.WriteLine("\nt1. Create Sphere of unit dimensions, with specified material");
                    Console.WriteLine("\nt2. Create Sphere of specified dimensions and material");
                    Console.Write("\n 1 or 2 ? => ");
                    choice = int.Parse(Console.ReadLine());

                }
                while ((choice != 1) && (choice != 2));
                // END OF CHOICE WHILE LOOP(2)

                if (choice == 1)
                {
                    Console.Write("\n Enter material type => ");
                    material = Console.ReadLine();
                    material = material.ToUpper();
                    S1 = new Sphere(material); // creates cone using 1 parameter as user selected option 1 
                }
                else
                {
                    Console.Write("\n Enter material type => ");
                    material = Console.ReadLine();
                    material = material.ToUpper();
                    Console.Write("\n Enter a radius => ");
                    radius = double.Parse(Console.ReadLine());

                   if(radius >= 1.0) // CHECKS TO SEE IF THE RADIUS IS VALID BY BEEING GREATER THAN 1 OR = TO 1 
                   {


                    S1 = new Sphere(material, radius); // RUNS FINE IF VALID RADIUS IS ENTERED 
                   }
                   else // IF NO VALID RADIUS MEETS THE CONDITION SETS THE RADIUS TO 1 AS DEFAULT.  
                   {

                       Console.WriteLine("you have entered a radius of 0 or a negative radius, the radius has been set to 1.0 as a default.");
                    radius = 1.0;
                    S1 = new Sphere(material, radius); // CREATES SPHERE AS RADIUS AS DEFAULT 1 
                   }
                } // end of if statement with users choice 





                Console.WriteLine("\n The Sphere details are as follows:");

                Console.WriteLine(S1.ToString()); // calls and writes the two string method

                Console.WriteLine("\n The Surface of the Sphere is " + S1.CalculateSurfaceArea()); // uses method from sphere and prints to screen 
                Console.WriteLine("\n The volume of the Sphere is " + S1.CalculateVolume()); // uses method from sphere and prints to screen 
                Console.WriteLine("\n The weight of the Sphere is  " + S1.CalculateWeight()); // uses method from sphere and prints to screen  
                Console.WriteLine("Would you like to run the program again to test another Sphere? Y/N"); // askes for user input 
                String ans; // new veriable for user answer 
                    ans = Console.ReadLine();
                ans = ans.ToUpper(); // converts to upper 
                if(ans == "Y") // if the answer is Y then keep the flag at 0 and clear the screen so the user can do another spher e
                {
                    flag = 0;
                    Console.Clear();
                }
                else  // if the user says no 
                {
                    flag = 1; // makes the loop exit 
                }

            } // end of while loop 

        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
            Pause("\nPress any key to exit ...");
        }
    }
}
