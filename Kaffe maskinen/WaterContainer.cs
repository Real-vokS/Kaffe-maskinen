using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe_maskinen
{

    // This class control the water in the coffee machine's water container

    internal class WaterContainer : ILiquidContainer
    {

        int maxWaterInMl;

        int currentWaterInMl;

        int cupInMl;


        public WaterContainer(int maxContentInML)
        {
            this.maxWaterInMl = maxContentInML;

            this.currentWaterInMl = 0;

            this.cupInMl = 250;
        }

        // Fills the water container with x amount of cups
        // If the water container has space for x amount of cups it will fill it up
        // If the water container doesnt have enough space. It will fill the container with cups of water till it is full
        // The rest of the cups will not be added in
        public void FillContainer(int cups)
        {
            int cupsInMl = cups * cupInMl;
            if (currentWaterInMl < maxWaterInMl && currentWaterInMl + cupsInMl < maxWaterInMl)
            {
                currentWaterInMl += cupsInMl;

                Console.WriteLine(currentWaterInMl + " is the current water filled in ml");
            }
            else
            {
                int neededWaterTillFull = maxWaterInMl - currentWaterInMl;
                int overFlowWater = cupsInMl - neededWaterTillFull;

                currentWaterInMl += neededWaterTillFull;

                Console.WriteLine((overFlowWater / cupInMl) + " cups of water has not been added. since it exceeded the max amount");
            }
        }


        // Checks if there is water enough to use water need to cups
        // If the container has enough water. It will make use the water equals to the cups
        // If the container doesnt have enough water. It uses the rest of the water to make X amount of cups
        // It wont use 4 cups of water if the container only has enough for 2 cups
        public void UseContent(int cups)
        {
            int cupsInMl = cups * cupInMl;
            if(currentWaterInMl >= cupsInMl)
            {
                currentWaterInMl -= cupsInMl;
            }
            else
            {
                int currentCups = currentWaterInMl / cupInMl;
                int waterLeftForCups = cups - currentCups;
                int cupsNotMade = cups - waterLeftForCups;

                currentWaterInMl -= (waterLeftForCups * cupInMl);


                Console.WriteLine(cupsNotMade + " cups wasnt made. Since there isnt enugh water in the machine");
            }

        }


        // Empties the water container
        public void EmptyContainer()
        {
            currentWaterInMl = 0;

            Console.WriteLine("The coffee machine has been emptied for water");
        }


        public int CurrentContentInMl
        {
            get => currentWaterInMl;
        }

    }
}
