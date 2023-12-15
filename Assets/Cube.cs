using System.Collections;
using System.Collections.Generic;
using UnityEngine;

       
public class Cube : Interactables
{
    public override void detect()
    {
        transform.Rotate(new Vector3(180,20,90));
        Debug.Log("Cube");
    }

    public override void reset()
    {
        transform.rotation = Quaternion.identity;
    }
}
