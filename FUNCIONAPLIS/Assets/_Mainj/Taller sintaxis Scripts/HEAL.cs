using UnityEngine;

public class HEAL : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerStats.SumarVida(10);
            _uiManager.SumarFillAmount(0.1f);
            Destroy(this.gameObject);
        }
    }

}
