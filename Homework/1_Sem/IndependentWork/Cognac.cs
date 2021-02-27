using System;
using System.Collections.Generic;
using System.Text;
namespace IndependentWork
{
    public class Cognac
    {
        private double price;
        private byte endurance;
        private string countryProducer;
        private double volume;

        public double Price => price;
        public byte Endurance => endurance;
        public string CountryProducer => countryProducer;
        public double Volume => volume;

        public Cognac(double price, byte endurance, string countryProducer, double volume)
        {
            this.price = price;
            this.endurance = endurance;
            this.countryProducer = countryProducer;
            this.volume = volume;
        }

        public override string ToString()
        {
            return $"Price: {price}, Endurance: {endurance}, CreatedBy: {countryProducer}, Volume: {volume}";
        }
    }
}