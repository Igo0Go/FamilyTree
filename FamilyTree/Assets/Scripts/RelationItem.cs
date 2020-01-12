using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RelationItem : MonoBehaviour
{
    public Vector3 Begin
    {
        get => line.GetPosition(0);
        set
        {
            line.SetPosition(0, value);
        }
    }
    public Vector3 End
    {
        get => line.GetPosition(1);
        set
        {
            line.SetPosition(1, value);
        }
    }

    private LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 2;
        transform.position = new Vector3(transform.position.x, transform.position.y, 0.01f);
    }
}
