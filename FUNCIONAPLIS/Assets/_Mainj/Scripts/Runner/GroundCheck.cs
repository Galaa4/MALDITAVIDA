using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGround;

    void OnTriggerStay2D(Collider2D collision)
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