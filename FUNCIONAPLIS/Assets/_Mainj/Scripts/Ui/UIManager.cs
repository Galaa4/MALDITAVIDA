using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private GameObject _panelDefeat;
    [SerializeField] private GameObject _panelVictory;

    public void SumarFillAmount(float amount)
    {
        _barra.fillAmount += amount;
    }

    public void RestarFillAmount(float amount)
    {
        _barra.fillAmount -= amount;
    }

    private void Update()
    {
        if (_barra.fillAmount <= 0.0f)
        {
            _panelDefeat.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _gameManager.PausarElJuego();
            _panelVictory.SetActive(true);
        }

    }

}