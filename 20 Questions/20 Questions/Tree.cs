using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

public class Tree
{
	TreeNode rootNode;
	//dictionary of all the nodes
	static Dictionary<string, TreeNode> nodes;

    public Tree()
	{
		rootNode = null;
		nodes = new Dictionary<string, TreeNode>(); 
        //loads tree on declration of the 
        loadTree(); 
			
	}

	public void query()
	{
		rootNode.query();
	}

	private void loadTree()
	{
		
        // make a stream reader object out of it
        StreamReader sr = new StreamReader(".\tree.txt");
		string line = sr.ReadLine();
		while (line != null) {
		string[] parts = line.Split(",");
		string name= parts[0];
		string message = parts.Length>1 ? parts[1]: null;
		string parent = parts.Length > 2 ? parts[2]: null;
		string edgeType = parts.Length > 3 ? parts[3]: null;
			// if parent node is null set rootnode
			if (rootNode == null)
			{
				rootNode = new TreeNode(message, parent, edgeType,name);
				nodes.Add(name, rootNode);
			}
			else// call add node to set the rest
			{
				addNode(name, message, parent, edgeType);
			}
		line = sr.ReadLine();
		}


		sr.Close();
		// while the first line isnt null do loop
		// assign line to varibles message,paren

	}

	public void addNode(string name, string message, string parent, string edgeType)
	{
		//make new nodes dictionary item and set it as appropiate type of childe node to its parent
        nodes.Add(name, new TreeNode(message, parent, edgeType,name));

		if(edgeType == "no")
		{
			nodes[parent].setNoNode(nodes[name]);
		}
        if (edgeType == "yes")
        {
            nodes[parent].setYesNode(nodes[name]);
        }
        
    }

	public void removeNode(string name)
    {
    }
	public void printTree()
	{
        StreamWriter sw = new StreamWriter(".\tree.txt", true);
        rootNode.printNode(sw);
        sw.Close();
    }
}

