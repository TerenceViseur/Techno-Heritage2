using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimSystem : MonoBehaviour
{
    private Camera m_camera;
    [SerializeField] private LayerMask m_layerMask;
    private bool m_hitting;
    private Collider m_previousHitObject;

    // Start is called before the first frame update
    void Start()
    {
        m_camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var ray = m_camera.ViewportPointToRay(new Vector2(.5f,.5f));
        if(Physics.Raycast(ray,out var hit, 10, m_layerMask))
        {
            m_hitting = true;
            m_previousHitObject = hit.collider;
            hit.collider.gameObject.GetComponent<Interactables>().detect();
        }
        else if (m_previousHitObject!=null)
        {
            m_previousHitObject.GetComponent<Interactables>().reset();
            m_hitting = false;
            m_previousHitObject = null;

        }
    }
    
    
}
