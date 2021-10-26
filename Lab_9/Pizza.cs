using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Pizza
    {
        private string size;
        private int pep, ham, cheese;

        // Constructors
        public Pizza()
        {
            this.size = "small";
            this.pep = 0;
            this.ham = 0;
            this.cheese = 0;
        }

        public Pizza(string size)
        {
            this.size = size;
            this.pep = 0;
            this.ham = 0;
            this.cheese = 0;
        }

        public Pizza(int pep, int ham, int cheese)
        {
            size = "small";
            this.pep = pep;
            this.ham = ham;
            this.cheese = cheese;
        }

        public Pizza(string size, int pep, int ham, int cheese)
        {
            this.size = size;
            this.pep = pep;
            this.ham = ham;
            this.cheese = cheese;
        }

        // Getters
        public string getSize() { return size; }
        public int getPep() { return pep; }
        public int getHam() { return ham; }
        public int getCheese() { return cheese; }

        // Setters
        public void setSize(string size) { this.size = size; }
        public void setPep(int pep) { this.pep = pep; }
        public void setHam(int ham) { this.ham = ham; }
        public void setCheese(int cheese) { this.cheese = cheese; }

        public double CalculateCost(string s)
        {
            double cost = 0.0;

            // checks the size of the pizza and sets the cost equal to it;
            if(s == "small")
            {
                cost = 10.00;
            }
            else if(s == "medium")
            {
                cost = 12.00;
            }
            else if(s == "large")
            {
                cost = 14.00;
            }

            // adds the price of each topping to the total cost
            cost += 2.0 * (getHam() + getCheese() + getPep());

            return cost;
        }

        // returns a string that shows the size and cost of the pizza
        public override string ToString()
        {
            return "Your pizza is size " + getSize() + " and will cost " + CalculateCost(getSize()) + " dollars with " + 
                    (getPep() + getHam() + getCheese()) + " toppings";
        }

    }
}
