using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationNodeForwardToChildren : TreeViewElement
{
    [HideInInspector] public RelationNodeParentToForward parentsNode;

    public List<PersonItem> childrens;

    public void Start()
    {
        childrens = new List<PersonItem>();
    }
}
