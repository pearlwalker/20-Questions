using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Tree
{
	TreeNode rootNode;

	public Tree(string question, string yesGuess, string noGuess)
	{
		rootNode = new TreeNode(question);
		rootNode.setYesNode(new TreeNode(yesGuess));
		rootNode.setNoNode(new TreeNode(noGuess));	
	}

	public void query()
	{
		rootNode.query();
	}
}
