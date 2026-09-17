using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void CargarScena(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
