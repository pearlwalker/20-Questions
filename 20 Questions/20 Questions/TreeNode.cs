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

	//
}
