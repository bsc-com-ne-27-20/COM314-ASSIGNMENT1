using System;

public class BinaryTreeTest
{
    public static void Main()
    {
        BinaryTree binaryTree = new BinaryTree();

        // Insert some sample persons into the binary tree
        Person person1 = new Person("Allino", "Maloya\n", 30, "\nABC123\n");
        Person person2 = new Person("Jane\n", "Halad\n ",25, "\nDEF456\n");
        Person person3 = new Person("Michael\n", "John\n" ,35 , "\nGHI789\n");
        Person person4 = new Person("Emily\n ","Williams\n" , 28, "\nJKL012\n");

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