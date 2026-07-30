using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables

    private float fuerza = 500f

    [SerializeField] private Rigidbody2D _rigidbody2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody2D.AddForce(Vector2.right * fuerza);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 