using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace NewListBox
{
    public class SolarSystemObject
    {
        // Название планеты
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Орбита, в астрономических единицах (а. е)
        private double orbit;
        public double Orbit
        {
            get { return orbit; }
            set { orbit = value; }
        }
        // Средний диаметр, в км
        private double diameter;
        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        // Относительная ссылка на изображение
        private Uri image;
        public Uri Image
        {
            get { return image; }
            set { image = value; }
        }
        // Описание
        private string details;
        public string Details
        {
            get { return details; }
            set { details = value; }
        }
        // Метод для работы с коллекцией элементов
        public SolarSystemObject(string name, double orbit, double diameter, Uri
        image, string details)
        {
            this.name = name;
            this.orbit = orbit;
            this.diameter = diameter;
            this.image = image;
            this.details = details;
        }
        // Вместо new использован virtual-override
        public override string ToString()
        {
            return this.name;
        }
    }
}