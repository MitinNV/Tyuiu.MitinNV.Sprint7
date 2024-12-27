namespace Tyuiu.MitinNV.Sprint7.Lib
{
    using System;
    using System.Collections.Generic;

    public class DataService
    {
        // Хранилище данных - для примера используется список
        private List<Apartment> apartments = new List<Apartment>();

        // Метод для добавления новой квартиры
        public void AddApartment(Apartment apartment)
        {
            apartments.Add(apartment);
        }

        // Метод для получения всех квартир
        public List<Apartment> GetApartments()
        {
            return new List<Apartment>(apartments);
        }

        // Метод для поиска квартиры по номеру подъезда и номера квартиры
        public Apartment FindApartment(int buildingNumber, int apartmentNumber)
        {
            return apartments.Find(a => a.BuildingNumber == buildingNumber && a.ApartmentNumber == apartmentNumber);
        }

        // Метод для удаления квартиры
        public void RemoveApartment(int buildingNumber, int apartmentNumber)
        {
            var apartment = FindApartment(buildingNumber, apartmentNumber);
            if (apartment != null)
            {
                apartments.Remove(apartment);
            }
        }
    }

    // Класс для хранения информации о квартире
    public class Apartment
    {
        public int BuildingNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public double TotalArea { get; set; }
        public double UsefulArea { get; set; }
        public int NumberOfRooms { get; set; }
        public string TenantName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int FamilyMembersCount { get; set; }
        public int ChildrenCount { get; set; }
        public bool HasDebt { get; set; }
        public string Notes { get; set; }

        // Constructor for initialization
        public Apartment(int buildingNumber, int apartmentNumber, double totalArea, double usefulArea, int numberOfRooms,
                          string tenantName, DateTime registrationDate, int familyMembersCount, int childrenCount, bool hasDebt, string notes)
        {
            BuildingNumber = buildingNumber;
            ApartmentNumber = apartmentNumber;
            TotalArea = totalArea;
            UsefulArea = usefulArea;
            NumberOfRooms = numberOfRooms;
            TenantName = tenantName;
            RegistrationDate = registrationDate;
            FamilyMembersCount = familyMembersCount;
            ChildrenCount = childrenCount;
            HasDebt = hasDebt;
            Notes = notes;
        }
    }
}
