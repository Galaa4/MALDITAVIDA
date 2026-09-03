using UnityEngine;

public class HEAL : MonoBehaviour
{
    [SerializeField] private int _Healamount = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { 
            PlayerStats stats = collision.GetComponent<PlayerStats>(); 

            if (stats != null)
            {
                stats.SumarVida(_Healamount);

                Destroy(gameObject);
            }
        }
    }

}
