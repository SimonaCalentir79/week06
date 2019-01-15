using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_Models_Interface
{
    public struct Tree { public Node root; public Node leftValue; public Node rightValue; }
    public class Node
    {

    }

    //public class Node { public int value; public Node leftValue; public Node rightValue; }

    //public class TreeOfNodes
    //{
    //    public Node AddNode(Node root, int val)
    //    {
    //        if (root == null)
    //        {
    //            root = new Node();
    //            root.value = val;
    //        }
    //        else if (val < root.value)
    //        {
    //            root.leftValue = AddNode(root.leftValue, val);
    //        }
    //        else
    //        {
    //            root.rightValue = AddNode(root.rightValue, val);
    //        }
    //        return root;
    //    }


    //}

    //    public void Traverse(Node root)
    //    {
    //        if (root == null)
    //            return;

    //        Traverse(root.leftValue);
    //        Traverse(root.rightValue);
    //    }
    //}
}
