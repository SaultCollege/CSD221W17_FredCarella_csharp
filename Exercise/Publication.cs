﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Publication
    {
        private String title;
        private Double price;
        private int copies;

        public String Title {
            set { title = value; }
            get { return title; }
        }

        public String getTitle() { return title; }
        public void setTitle(String title) { this.title = title; }
        public int getCopies() { return copies; }
        public void setCopies(int copies) { this.copies = copies; }
        public Double getPrice() { return price; }
        public void setPrice(Double price) { this.price = price; }


        public Publication() {
            this.copies = 0;
            this.price = 0.0d;
            this.title = "No Title";
        }
        override public string ToString() {
            return title + " $" + price + " " + copies;
        }

        public void sellCopy() {
            Console.WriteLine("Sell Copy");
        }
    }
}
