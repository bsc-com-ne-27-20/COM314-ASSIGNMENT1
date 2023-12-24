using System;

public class Person{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Age {get; set;}
    public string UniqueID{get;set;}

    public Person (string firstName, string lastName, int age, string uniqueID){
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        UniqueID = uniqueID;
    }

}