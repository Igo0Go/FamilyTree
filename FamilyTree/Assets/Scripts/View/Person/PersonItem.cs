using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonItem : TreeViewElement
{
    public int PersonDataId { get; set; }

    [HideInInspector] public RelationItem ParrentsItem;
    [HideInInspector] public RelationItem ChildrenItem;

    public ParentsConnector parentsConnector;
    public ChildrensConnector childrensConnector;
    public MarriedConnector leftMarried, RightMarried;

    public Vector3 GetChildrenConnectorPosition() => childrensConnector.transform.position + Vector3.forward * 0.01f;
    public Vector3 GetParentsConnectorPosition() => parentsConnector.transform.position + Vector3.forward * 0.01f;
}

public abstract class TreeViewElement : MonoBehaviour
{
    public int Id => _id;
    private int _id;

    public void GetNewId()
    {
        _id = TreelDatabace.Counters[1];
        TreelDatabace.Counters[1]++;
    }
}