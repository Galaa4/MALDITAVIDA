using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public float altura = 1.80f;
    public int edad = 2077;
    public string nombre = "Galaa";
    public bool puedeVotar = true; 

    public GameObject gameObject;
    public Rigidbody2D rigitbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;
    public Transform transform;
    //crear variable de tipo transform

    private void Start()
    {
        Debug.Log ("Hola: " + nombre + " tu edad es: " + edad + " tu altura es: " + altura);
        rigitbody2D.simulated = false;
        spriteRenderer.color = Color.red;
        transform.position = new Vector3(10f, 0f, 0f);

        //llamo mi variable de tipo tranform y le asigno un valor en x de 10
    }
    private void Update()
    {
        
    }
}
 