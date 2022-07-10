﻿using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to Address Book System ");
            Addressbook studentBook = new Addressbook();


            //Address book created  for student
            studentBook.AddDetails("Student", "Shivaraj", " Gowda ", " Basaveshwar nagar ", "Bangalore", "Karnataka", 560079, 8618199771, " 4shivaraj.gowda.com ");
            studentBook.AddDetails("Student", "Deepak", " Kumar ", " Kamala Nagar ", "Bangalore", "Karnataka", 560079, 880664052, " Dkumar@gmail.com ");
            studentBook.AddDetails("Student", "Priya", " Deshmukh ", " Kamakya ", "Hyderabad", "Telangana", 560056, 88060214103, " deshmukh@gmail.com ");
            studentBook.AddDetails("Student", "Sachin", " HG ", " Sagar ", "Shimoga", "Karnataka", 400517, 8875811103, " sachinhg@gmail.com ");
            studentBook.AddDetails("Student", "Sheetal", " Patel ", " Gandhi nagar ", "Ahmdabad", "Gujrat", 400017, 8806154783, " pawar@gmail.com ");

            Console.WriteLine(" Enter  stored Book name : ");
            string addressBook = Console.ReadLine();
            if (addressBook == "Student")
            {
                studentBook.AddressBook(addressBook);


                //Giving option to perform
                Console.WriteLine("1:Search person by city or state");
                Console.WriteLine("2: Count of the person in  city");
                Console.WriteLine("3: Display the details");
                Console.WriteLine("4: Display by sorted first name");
                Console.WriteLine("5: Display by sorted City or zip ");
                Console.WriteLine("6: Read address book from file");
                Console.WriteLine("7: Write address book from file");
                Console.WriteLine("8: Read  and write address book from csv file");


                Console.WriteLine("Enter the choice want to perform the function");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        studentBook.Search();
                        break;
                    case 2:
                        studentBook.Count();
                        break;
                    case 3:
                        studentBook.ComputeDetails();
                        break;
                    case 4:
                        studentBook.SortByFirstName();
                        break;
                    case 5:
                        studentBook.SortByCityOrStateOrZip();
                        break;
                    case 6:
                        studentBook.ReadAFile();
                        break;
                    case 7:
                        studentBook.SortByFirstName();
                        studentBook.WriteAFile();
                        break;
                    case 8:
                        studentBook.SerializationCSV();
                        break;
                    case 9:
                        studentBook.DeSerializationCSV();
                        break;
                }
            }
        }
    }
}

/*
UC 14
Ability to Read/Write the Address Book with Persons Contact as CSV File
- Use OpenCSV Library


Welcome to Address Book System
 Enter  stored Book name :
Student
1:Search person by city or state
2: Count of the person in  city
3: Display the details
4: Display by sorted first name
5: Display by sorted City or zip
6: Read address book from file
7: Write address book from file
8: Read and write address book from csv file
Enter the choice want to perform the function
8
 Sort the contacts alphabetically
Address Book: Student
 Details of Deepak  Kumar  are:  Address: Kamala Nagar   City: Bangalore
                                State: Karnataka Zip: 560079
                                PhoneNumber: 880664052
                                Email: Dkumar @gmail.com
Address Book: Student
 Details of Priya  Deshmukh  are:  Address: Kamakya City: Hyderabad
                                State: Telangana Zip: 560056
                                PhoneNumber: 88060214103
                                Email: deshmukh @gmail.com
Address Book: Student
 Details of Sachin  HG  are:  Address: Sagar City: Shimoga
                                State: Karnataka Zip: 400517
                                PhoneNumber: 8875811103
                                Email: sachinhg @gmail.com
Address Book: Student
 Details of Sheetal  Patel  are:  Address: Gandhi nagar   City: Ahmdabad
                                State: Gujrat Zip: 400017
                                PhoneNumber: 8806154783
                                Email: pawar @gmail.com
Address Book: Student
 Details of Shivaraj  Gowda  are:  Address: Basaveshwar nagar   City: Bangalore
                                State: Karnataka Zip: 560079
                                PhoneNumber: 8618199771
                                Email: 4shivaraj.gowda.com
Read data successfully from MultipleAddressBook.csv, here are codes
        Deepak
        Priya
        Sachin
        Sheetal
        Shivaraj
*/
