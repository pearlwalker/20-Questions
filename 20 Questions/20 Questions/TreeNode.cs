using System;

public class TreeNode
{
	public string data;
	public Boolean yes;
	public Boolean no;

	//represents each node in the question tree
	public TreeNode(string newData, Boolean newYes, Boolean newNo)
	{
		data = newData;
		yes = newYes;
		no = newNo;
	}
}
