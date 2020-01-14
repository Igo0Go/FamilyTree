using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentsConnector : TreeViewElement
{
    public RelationNodeForwardToChildren ParentNode { get; set; }
    public RelationItem Relation { get; set; }
}
