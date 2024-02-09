// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using Entities.Concrete;

Person person = new Person();
person.FirstName = "UĞUR CAN";
person.LastName = "AKKOÇ";
person.DateOfBirthYear = 1989;
person.NationalIdentity = 11111;

PttManager pttManager = new PttManager(new PersonManager());

pttManager.GiveMask(person);