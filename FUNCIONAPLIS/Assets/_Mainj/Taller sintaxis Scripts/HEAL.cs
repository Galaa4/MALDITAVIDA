using UnityEngine;

public class Heal : MonoBehaviour
{

    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            _playerStats.SumarVida(10);
            _uiManager.SumarFillAmount(0.1f);
            Destroy(this.gameObject);

        }


    }

}