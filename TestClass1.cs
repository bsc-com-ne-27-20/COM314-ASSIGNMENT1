using System;

public class BinaryTreeTest
{
    public static void Main()
    {
        BinaryTree binaryTree = new BinaryTree();

        // Insert some sample persons into the binary tree
        Person person1 = new Person("Allino", "Maloya", 30, "ABC123");
        Person person2 = new Person("Jane", "Halad", 25, "DEF456");
        Person person3 = new Person("Michael", "John", 35, "GHI789");
        Person person4 = new Person("Emily", "Williams", 28, "JKL012");

        binaryTree.Insert(person1);
        binaryTree.Insert(person2);
        binaryTree.Insert(person3);
        binaryTree.Insert(person4);

        // Perform inorder traversal
        Console.WriteLine("Inorder Traversal:");
        binaryTree.TraverseInorder();

        Console.WriteLine();

        // Perform postorder traversal
        Console.WriteLine("Postorder Traversal:");
        binaryTree.TraversalPostOrder();

        Console.WriteLine();

        // Search for a person by unique ID
        Console.WriteLine("Search for a Person by Unique ID:");
        Console.Write("Enter Unique ID: ");
        string uniqueID = Console.ReadLine();

        Person foundPerson = binaryTree.Searching(uniqueID);
        if (foundPerson != null)
        {
            Console.WriteLine($"Person found: {foundPerson.FirstName} {foundPerson.LastName}");
        }
        else
        {
            Console.WriteLine("Person not found.");
        }
    }
}