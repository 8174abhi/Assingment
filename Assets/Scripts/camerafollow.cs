using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform playertransform;
    Vector3 Offset;
    private void Start()
    {
        Offset = transform.position - playertransform.position;
    }
    private void Update()
    {
        Vector3 newpos = new Vector3( Offset.x+playertransform.position.x,Offset.y+playertransform.position.y, Offset.z + playertransform.position.z);
        transform.position = newpos;
    }
}
