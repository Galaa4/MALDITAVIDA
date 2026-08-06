using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _force = 5f;
    [SerializeField] private float _speed = 5f;

    [SerializeField] private Rigidbody2D _rigitbody2D;
    //crear variable de tipo transform

    private void Start()
    {
        _rigitbody2D = GetComponent<Rigidbody2D>();

        //llamo mi variable de tipo tranform y le asigno un valor en x de 10
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigitbody2D.AddForce(Vector2.up* _force);
            //se ejecuta si se cumple la condicion
        }
        _rigitbody2D.linearVelocity = Vector2.right * _speed;
    }
}
 