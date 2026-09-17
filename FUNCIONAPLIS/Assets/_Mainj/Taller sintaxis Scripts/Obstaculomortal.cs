using UnityEngine;

public class ObstaculoMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerstats;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (_playerstats != null)
            {
                _playerstats.RestarVida(10);
            }
        }
    }
}