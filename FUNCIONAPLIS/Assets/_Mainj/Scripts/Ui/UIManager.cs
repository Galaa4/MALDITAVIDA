using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;

    public void ActualizarFillAmount(float porcentaje)
    {
        _barra.fillAmount = porcentaje;
    }

    public void ColorBarra(Color nuevoColor)
    {
        _barra.color = nuevoColor;
    }
}