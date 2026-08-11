using System.Runtime.CompilerServices;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGround;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGround = true;
        Debug.Log("Me tocaron");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGround = false;
        Debug.Log("Ya no me tocan");
    }

}