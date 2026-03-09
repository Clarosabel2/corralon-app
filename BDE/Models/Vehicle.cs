using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class Vehicle
    {
        private string _patent;
        private string _brand;
        private string _model;
        private int _year;

        private DateTime _entryDate;


        private int _numberAxles;
        private double _tareWeight;

        private bool _isActive;

        private int _idEmployee;
        public Vehicle(
            string patent, 
            string brand, 
            string model, 
            int year,
            int numberAxles,
            int tareWeight)
        {
            Patent = patent;
            Brand = brand;
            Model = model;
            Year = year;
            EntryDate = DateTime.Now;
            NumberAxles = numberAxles;
            TareWeight = tareWeight;
            IsActive = true;
        }

        public string Patent { get => _patent; set => _patent = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public DateTime EntryDate { get => _entryDate; set => _entryDate = value; }
        public int IdEmployee { get => _idEmployee; set => _idEmployee = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }
        public int NumberAxles { get => _numberAxles; set => _numberAxles = value; }
        public double TareWeight { get => _tareWeight; set => _tareWeight = value; }
    }
}
