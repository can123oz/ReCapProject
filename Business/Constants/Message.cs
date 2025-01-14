﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Message
    {
        public static string SuccessMessage = "Succesfuly Returned";
        public static string DataSuccessMessage = "Succesfuly Data Returned";
        public static string ErrorMessage = "Error Returned";
        public static string DataErrorMessage = "Data Error Returned";
        public static string NameTakenError = "Name is Taken pick another name";
        public static string GeneralErrorMessage = "An Error Occured in Business Rules";
        public static string ImageAdded = "Image Added";
        public static string ImageNotFound = "Image Not Found";
        public static string ImageError = "Image Error";
        public static string ImageUpdated = "Image Updated";
        public static string UserNotFound = "User Not Found";
        public static string UserExist = "User Exist";
        public static string WrongPassword = "Wrong Password";
        public static string SuccessLogin = "Successfuly logged in";
        public static string RentNotFound = "Car not found";
        public static string CarIsReadyToRent = "Car is ready to rent.";
        public static string CarNotReturnYet = "Car is still with a customer.";
        public static string RentCreated = "Rent is Created Please return the car clean and full.";
        public static string AuthorizationDenied = "Not Authorized For this action";
        public static string SuccessUpdate = "Successfuly Updated";
    }
}
