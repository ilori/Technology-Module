using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Parking_Validation
{
    class Program
    {
        static void Main()
        {
            var registrationNameAndPlate = new Dictionary<string, string>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var command = input[0];
                var customerName = input[1];

                if (command == "register")
                {
                    var customerLicense = input[2];
                    if (registrationNameAndPlate.ContainsKey(customerName))
                    {
                        Console.WriteLine(
                            $"ERROR: already registered with plate number {registrationNameAndPlate[customerName]}");
                    }
                    else if (registrationNameAndPlate.ContainsValue(customerLicense))
                    {
                        Console.WriteLine($"ERROR: license plate {customerLicense} is busy");
                    }
                    else
                    {
                        var isValid = ValidationCheck(customerLicense);
                        if (isValid)
                        {
                            registrationNameAndPlate[customerName] = customerLicense;
                            Console.WriteLine($"{customerName} registered {customerLicense} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: invalid license plate {customerLicense}");
                        }
                    }
                }
                else if (command == "unregister")
                {
                    if (!registrationNameAndPlate.ContainsKey(customerName))
                    {
                        Console.WriteLine($"ERROR: user {customerName} not found");
                    }
                    else
                    {
                        registrationNameAndPlate.Remove(customerName);
                        Console.WriteLine($"user {customerName} unregistered successfully");
                    }
                }
            }
            foreach (var person in registrationNameAndPlate)
            {
                Console.WriteLine($"{person.Key} => {person.Value}");
            }
        }

        private static bool ValidationCheck(string customerLicense)
        {
            if (customerLicense.Length != 8)
            {
                return false;
            }
            foreach (var charecter in customerLicense.Take(2))
            {
                if (!char.IsLetter(charecter))
                {
                    return false;
                }
                if (!char.IsUpper(charecter))
                {
                    return false;
                }
            }
            foreach (var charecter in customerLicense.Reverse().Take(2))
            {
                if (!char.IsLetter(charecter))
                {
                    return false;
                }
                if (!char.IsUpper(charecter))
                {
                    return false;
                }
            }
            foreach (var number in customerLicense.Skip(2).Take(4))
            {
                if (!char.IsDigit(number))
                {
                    return false;
                }
            }
            return true;
        }
    }
}