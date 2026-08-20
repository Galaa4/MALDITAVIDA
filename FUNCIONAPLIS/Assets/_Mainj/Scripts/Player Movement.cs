using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpforce = 7f;
    [SerializeField] private float _movementspeed = 5f;

    [SerializeField] private Rigidbody2D _rigitbody2D;
    [SerializeField] private GroundCheck _groundCheck;

    [SerializeField] private float _jumpBufferTime = 0.75f;
    private float _jumpBufferCounter;

    private bool _jumpRequested;

    private void Awake()
    {
        if (_rigitbody2D == null)
            _rigitbody2D = GetComponent<Rigidbody2D>();    
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumpBufferCounter = _jumpBufferTime;
        }
        else
        {
            _jumpBufferCounter -= Time.deltaTime;
        }

        if (_jumpBufferCounter > 0f && _groundCheck.isGround)
        {
            _jumpRequested = true;
            _jumpBufferCounter = 0f;
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