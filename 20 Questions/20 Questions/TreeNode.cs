using System;

public class TreeNode
{
	string data; //holds the question or answer
	TreeNode yesNode; //reference to node if user enters no
	TreeNode noNode; //reference to node user enters yes

	//represents each node in the question tree
	public TreeNode(string newData, TreeNode newYes, TreeNode newNo)
	{
		data = newData;
		yesNode = newYes;
		noNode = newNo;
	}

	public void setData(string nodeData)
	{
		data = nodeData;
	}

	public string getData()
	{
		return data;
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
}
