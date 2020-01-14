using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationNodeParentToForward : TreeViewElement
{
    [HideInInspector] public PersonItem mother, father;
    [HideInInspector] public RelationNodeForwardToChildren childrenNode;
}