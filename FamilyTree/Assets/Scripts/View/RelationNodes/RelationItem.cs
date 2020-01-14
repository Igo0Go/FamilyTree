using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RelationItem : TreeViewElement
{
    private LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 2;
        transform.position = new Vector3(transform.position.x, transform.position.y, 0.01f);
    }

    public void SetPositions(Vector3 start, Vector3 end)
    {
        if(start.x == end.x)
        {
            line.positionCount = 2;
            line.SetPosition(0, start);
            line.SetPosition(1, end);
        }
        else
        {
            line.positionCount = 3;
            line.SetPosition(0, start);
            line.SetPosition(1, new Vector3(end.x, start.y, 0.01f));
            line.SetPosition(2, end);
        }
    }
}
