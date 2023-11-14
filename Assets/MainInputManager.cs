using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class MainInputManager : MonoBehaviour
{
    [SerializeField] private Player m_player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProcessMoveInput(CallbackContext _value)
    {
        var vector = _value.ReadValue<Vector2>();
        m_player.Move(vector);
    }
}
