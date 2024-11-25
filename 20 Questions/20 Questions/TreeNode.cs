using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;

//Declare Tree
[Serializable] class TreeNode
{
	string message; //holds the question or answer
	TreeNode yesNode; //reference to node if user enters no
	TreeNode noNode; //reference to node user enters yes
	string parentName;
	string edgeType;
	string name;
	//represents each node in the question tree
	public TreeNode(string nodeMessage, string parent, string edge, string nodeName)
	{
		edgeType = edge;
		message = nodeMessage;
		parentName = parent;
		yesNode = null;
		noNode = null;
		name = nodeName;
	}	

	//mutator methods
	public void setMessage(string nodeMessage)
	{
		message = nodeMessage;
	}

	public string getMessage()
	{
		return message;
	}

	public void setNoNode(TreeNode node)
	{
		noNode = node;
	}

	public TreeNode getNoNode()
	{
		return noNode;
	}

	public void setYesNode(TreeNode node)
	{
		yesNode = node;
	}

	public TreeNode getYesNode()
	{
		return yesNode;
	}

    /*
     * When a node has two null references the computer has no more questions and the computer is ready to make a guess.
     * The following method will check to see if a node is a leaf node and it will be used later when progressing through the binary trees. - https://www.c-sharpcorner.com/UploadFile/4a950c/20-questions-guessing-game-using-binary-trees/
	*/
	public bool isQuestion()
	{
		if (noNode == null && yesNode == null)
		{
			return false;
		} 
		else
		{
			return true;
		}
	}

	//asks a user for yes or no
	private char getYesOrNo()
	{
		char inputCharacter = ' ';
		while (inputCharacter != 'y' && inputCharacter != 'n')
		{
			inputCharacter = Console.ReadLine().ElementAt(0);
			inputCharacter = Char.ToLower(inputCharacter);
            //Console.Write("Enter 'y' for yes and 'n' for no: ");
        }
		return inputCharacter;
	}

	/*
	 * This game requires a user to answer a question. If the user answers yes, it asks the next question contained in the yesNode. To access the next node we are going to use a method called query(). To access the yes node use yesNode.query() and noNode for the no node. This method will also have to reconstruct the tree when the computer does not know the answer. This is done in the updateTree() method. 
	 */
	public void query()
	{
		if (this.isQuestion())
		{//Ask a question and prompt for user input.
			Console.WriteLine(message);
			Console.Write("Enter 'y' for yes and 'n' for no: ");
			char input = getYesOrNo();
			if (input == 'y')
			{//Prompt yes node
                this.yesNode.query();
			} else
			{//Prompt no node
                this.noNode.query();
			}
		} else
		{//Guess the answer
			this.onQueryObject();
		}
	}

	/*Ask the user if this is the country they were thinking of.
	 * If yes,Computer wins.If not,Prompt the user to update the tree.*/
	public void onQueryObject()
	{
		Console.WriteLine("Are you thinking of a(n) " + this.message + "?");
		Console.Write("Enter 'y' for yes and 'n' for no: ");
        char input = getYesOrNo();
        if (input == 'y')
		{
			Console.WriteLine("The Computer Wins\n");
		} else
		{
			updateTree();
		}
	}
	/*If user wins, prompt them To enter the country they were thinking of.
	 * Add question And Add it to the tree note.*/
	private void updateTree()
	{
		Console.Write("You win! What were you thinking of?");
		string userObject = Console.ReadLine();
		Console.Write("Please enter a question to distinguish a(n) " + this.message + " from " + userObject + ": ");
		string userQuestion = Console.ReadLine();
		Console.Write("If you were thinking of a(n) " + userObject + ", what would the answer to that question be?");
        char input = getYesOrNo();
        if (input == 'y')
		{
			this.noNode = new TreeNode(this.message,this.name,"no",this.name+"no");
			this.yesNode = new TreeNode(userObject, this.name, "yes", this.name + "yes");
			
		} else
		{
			this.yesNode = new TreeNode(this.message,this.name, "yes", this.name + "yes");
			this.noNode = new TreeNode(userObject, this.name, "no", this.name + "no");
		};
		Console.WriteLine("Thank you my knowledge has been increased");
		setMessage(userQuestion);
		
	}
	/// <summary>
	/// Recursivly print outs all of the nodes in the tree starting with the root node then yes nodes to no nodes
	/// </summary>
	/// <param name="sw"> Is a string writer object</param>
	public void printNode(StreamWriter sw)
	{
        sw.WriteLine($"{this.message},{this.name},{this.parentName},{this.edgeType}");
		if (yesNode != null)
		{
			yesNode.printNode(sw);
		}

		if (this.noNode != null)
		{
			noNode.printNode(sw);
		}
	}

}
