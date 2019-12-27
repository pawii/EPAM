using System;
using System.Text;

namespace GitHubAutomation.Services
{
    class OrderCreater
    {
        public static string WithInvalidPassword() => TestDataReader.GetTestData("Password");

        public static string WithInvalidEmail() => TestDataReader.GetTestData("Email");

        public static string WithInvalidPhoneNumber() => TestDataReader.GetTestData("PhoneNumber");
    }
}
