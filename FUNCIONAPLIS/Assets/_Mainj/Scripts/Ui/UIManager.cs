using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SumarFillAmount(float amount)
    {
        _barra.fillAmount += amount;
    }

    // Update is called once per frame
    public void RestarFillAmount (float amount)
    {
        _barra.fillAmount = _barra.fillAmount - amount;
    }

    public void ColorBarra(Color color)
    {

    }

}
