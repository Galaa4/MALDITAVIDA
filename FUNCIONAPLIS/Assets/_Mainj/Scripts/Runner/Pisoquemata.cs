using UnityEngine;

public class PisoqueMata : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _playerStats.RestarVida(200);
            _uiManager.RestarFillAmount(1f);
        }


    }
}