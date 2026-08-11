using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _force = 5f;
    [SerializeField] private float _speed = 5f;

    [SerializeField] private Rigidbody2D _rigitbody2D;
    [SerializeField] private GroundCheck _groundCheck;
    //crear variable de tipo transform

    private void Awake()
    {
        _rigitbody2D = GetComponent<Rigidbody2D>();    
    
    }
    private void FixedUpdate()
    {
        if (_groundCheck.isGround)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _rigitbody2D.AddForce(Vector2.up* _force);
                Debug.Log("tecla presionada");
            }
        }
        _rigitbody2D.linearVelocity = Vector2.right * _speed;
    }
}
 