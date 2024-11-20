using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class TreeNode
{
	string message; //holds the question or answer
	TreeNode yesNode; //reference to node if user enters no
	TreeNode noNode; //reference to node user enters yes

	//represents each node in the question tree
	public TreeNode(string nodeMessage)
	{
		message = nodeMessage;
		yesNode = null;
		noNode = null;
	}

	//mutator methods
	public void setData(string nodeData)
	{
		message = nodeData;
	}

	public string getData()
	{
		return message;
	}

	public void setNoNode(TreeNode node)
	{
		noNode = node.noNode;
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
		} else
		{
			return true;
		}
	}

	/*
	 * This game requires a user to answer a question. If the user answers yes, it asks the next question contained in the yesNode. To access the next node we are going to use a method called query(). To access the yes node use yesNode.query() and noNode for the no node. This method will also have to reconstruct the tree when the computer does not know the answer. This is done in the updateTree() method. 
	 */
	public void query()
	{
		if (this.isQuestion())
		{
			Console.WriteLine(this.message);
			Console.Write("enter 'y' for yes and 'n' for no: ");
			char input = getYesOrNo();
			if (input == 'y')
			{
				yesNode.query();
			} else
			{
				noNode.query();
			}
		} else
		{
			this.onQueryObject();
		}
	}

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
			this.noNode = new TreeNode(this.message);
			this.yesNode = new TreeNode(userObject);
		} else
		{
			this.yesNode = new TreeNode(this.message);
			this.noNode = new TreeNode(userObject);
		}
	}

}
