using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoRide 
{
    public class Model
    {
        string Name, UserID, Password, Gender, Address, CarNumber, CarModel,PickUp, Drop;
        int Age, Phone, Fare, NumberOfSeats;

        public string User_Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string User_UserID
        {
            get { return UserID; }
            set { UserID = value; }
        }

        public int User_Age
        {
            get { return Age; }
            set { Age = value; }
        }

        public string User_Gender
        {
            get { return Gender; }
            set { Gender = value; }
        }

        public string User_Password
        {
            get { return Password; }
            set { Password = value; }
        }

        public int User_Phone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public string User_Address
        {
            get { return Address; }
            set { Address = value; }
        }

        public string CarDetails_CarNumber
        {
            get { return CarNumber; }
            set { CarNumber = value; }
        }
        public string CarDetails_CarModel
        {
            get { return CarModel; }
            set { CarModel = value; }
        }
        public string CarDetails_PickUp
        {
            get { return PickUp; }
            set { PickUp = value; }
        }
        public string CarDetails_Drop
        {
            get { return Drop; }
            set { Drop = value; }
        }
        public int CarDetails_Fare
        {
            get { return Fare; }
            set { Fare = value; }
        }
        public int CarDetails_NumberOfSeats
        {
            get { return NumberOfSeats; }
            set { NumberOfSeats = value; }
        }
    }
}


