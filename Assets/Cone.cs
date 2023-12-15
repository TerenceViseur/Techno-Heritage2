using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cone : Interactables
{
    private Color m_lastColor;
    private void Start()
    {
        m_lastColor = GetComponent<MeshRenderer>().material.color;
    }
    public override void detect()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), (Random.Range(0f, 1f)), (Random.Range(0f, 1f)));
        Debug.Log("Cone");
    }
    public override void reset()
    {
        GetComponent<MeshRenderer>().material.color = m_lastColor;
    }
}
