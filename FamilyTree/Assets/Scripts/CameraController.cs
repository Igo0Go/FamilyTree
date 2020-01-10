using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float camMoveSpeed = 1;
    [SerializeField]
    private bool usePhysics = false;


    private Vector3 moveVector;

    void Start()
    {
        moveVector = Vector3.zero;
    }

    void Update()
    {
        CamMove();
        ScrollCam();
    }

    private void CamMove()
    {
        float h = 0, v = 0;

        if(Input.GetMouseButton(1))
        {
            h += Input.GetAxis("Mouse X");
            v += Input.GetAxis("Mouse Y");
            

            if (h != 0 || v != 0)
            {
                h = Mathf.Clamp(h, -camMoveSpeed, camMoveSpeed);
                v = Mathf.Clamp(v, -camMoveSpeed, camMoveSpeed);

                moveVector += new Vector3(h, v, 0) * Time.deltaTime;
            }
           

        }

        if (Input.GetMouseButtonUp(1))
        {
            moveVector = Vector3.zero;
        }

        transform.position += moveVector;
    }

    private void ScrollCam()
    {
        float forward = 0;
        forward = Input.mouseScrollDelta.y;
        if (forward != 0)
        {
            transform.position += new Vector3(0, 0, forward);
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -100, -2.5f));
        }
        if (Input.GetMouseButtonUp(1))
        {
            moveVector = Vector3.zero;
        }
    }
}
