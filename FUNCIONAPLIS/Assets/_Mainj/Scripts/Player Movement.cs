using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpforce = 7f;
    [SerializeField] private float _movementspeed = 5f;

    [SerializeField] private Rigidbody2D _rigitbody2D;
    [SerializeField] private GroundCheck _groundCheck;

    private bool _jumpRequested;

    private void Awake()
    {
        if (_rigitbody2D == null)
            _rigitbody2D = GetComponent<Rigidbody2D>();    
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck.isGround)
        {
            _jumpRequested = true;
        }
    }

    private void FixedUpdate()
    {
        if (_jumpRequested)
        {
            _rigitbody2D.AddForce(Vector2.up * _jumpforce, ForceMode2D.Impulse);
            _jumpRequested = false;
            Debug.Log("Salto ejecutado :D");
        }

        _rigitbody2D.linearVelocity = new Vector2(_movementspeed, _rigitbody2D.linearVelocity.y);
    }
}