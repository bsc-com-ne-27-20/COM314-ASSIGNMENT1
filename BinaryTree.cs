using System;

public class BinaryTree
{
    private Node root;

    public void Insert(Person person)
    {
        Node newNode = new Node(person);
        if (root == null)
        {
            root = newNode;
        }
        else
        {
            InsertNode(root, newNode);
        }
    }

    private void InsertNode(Node currentNode, Node newNode)
    {
        if (newNode.Data.Age < currentNode.Data.Age)
        {
            if (currentNode.Left == null)
            {
                currentNode.Left = newNode;
            }
            else
            {
                InsertNode(currentNode.Left, newNode);
            }
        }
        else if (newNode.Data.Age > currentNode.Data.Age)
        {
            if (currentNode.Right == null)
            {
                currentNode.Right = newNode;
            }
            else
            {
                InsertNode(currentNode.Right, newNode);
            }
        }
        else
        {
            int lastNameComparison = newNode.Data.LastName.CompareTo(currentNode.Data.LastName);
            if (lastNameComparison <= 0)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                }
                else
                {
                    InsertNode(currentNode.Left, newNode);
                }
            }
            else
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                }
                else
                {
                    InsertNode(currentNode.Right, newNode);
                }
            }
        }
    }

    public void TraverseInorder()
    {
        InOrderTraversal(root);
    }

    private void InOrderTraversal(Node currentNode)
    {
        if (currentNode != null)
        {
            InOrderTraversal(currentNode.Left);
            Console.WriteLine($"First Name: {currentNode.Data.FirstName}, Last Name: {currentNode.Data.LastName}, Age: {currentNode.Data.Age}, Unique ID: {currentNode.Data.UniqueID}");
            InOrderTraversal(currentNode.Right);
        }
    }

    public void TraversalPostOrder()
    {
        PostOrderTraversal(root);
    }

    private void PostOrderTraversal(Node currentNode)
    {
        if (currentNode != null)
        {
            PostOrderTraversal(currentNode.Left);
            PostOrderTraversal(currentNode.Right);
            Console.WriteLine($"First Name: {currentNode.Data.FirstName}, Last Name: {currentNode.Data.LastName}, Age: {currentNode.Data.Age}, Unique ID: {currentNode.Data.UniqueID}");
        }
    }

    public Person Searching(string uniqueID)
    {
        return SearchNode(root, uniqueID);
    }

    private Person SearchNode(Node currentNode, string uniqueID)
    {
        if (currentNode == null || currentNode.Data.UniqueID == uniqueID)
        {
            return currentNode?.Data;
        }
        else if (uniqueID.CompareTo(currentNode.Data.UniqueID) < 0)
        {
            return SearchNode(currentNode.Left, uniqueID);
        }
        else
        {
            return SearchNode(currentNode.Right, uniqueID);
        }
    }
}