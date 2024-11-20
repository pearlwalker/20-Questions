using System;

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
 * Notes:
 *	When a node has two null references the computer has no more questions and the computer is ready to make a guess.
 *	The following method will check to see if a node is a leaf node and it will be used later when progressing through the binary trees. - https://www.c-sharpcorner.com/UploadFile/4a950c/20-questions-guessing-game-using-binary-trees/
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

}
