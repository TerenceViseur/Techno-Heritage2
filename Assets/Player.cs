using UnityEngine;

internal class Player : MonoBehaviour
{
    [SerializeField] private float m_speed;
    private CharacterController m_characterController;
    private Vector3 m_moveVector;
    private Vector2 m_inputVector;

    private void Awake()
    {
        m_characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var rotation = Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up);
        transform.rotation = Quaternion.LookRotation(rotation);

        m_moveVector = transform.forward * m_inputVector.y + transform.right * m_inputVector.x;
        m_moveVector *= m_speed;
        m_characterController.SimpleMove(m_moveVector);
    }
    public void Move(Vector2 _inputVector)
    {
        m_inputVector = _inputVector;
        
    }
}