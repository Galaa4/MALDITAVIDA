using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    [SerializeField] private int _vidaMaxima = 100;
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
        _puntosVida -= daño;
    }
    public void SumarVida(int cantidad)
    {
        _puntosVida += cantidad;

        if (_puntosVida > _vidaMaxima)
        {
            _puntosVida = _vidaMaxima;
        }

        Debug.Log("Vida actual: " + _puntosVida);
    }
}