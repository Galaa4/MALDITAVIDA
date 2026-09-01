using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image barra;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        barra.color = Color.cyan;
        barra.fillAmount = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
