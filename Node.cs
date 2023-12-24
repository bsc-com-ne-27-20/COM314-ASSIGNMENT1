using System;
using System.Dynamic;

public class Node{
    public Person Data {get; set;}
    public Node Left{get; set;}
    public Node Right{get; set;}
    
    public Node(Person person){
        Data = person;
        Left = null;
        Right = null;
    }
}