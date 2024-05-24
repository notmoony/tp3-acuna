using UnityEngine;
using UnityEngine.SceneManagement;

public class Juego : MonoBehaviour
{
    public string nombreEscena;
    public void Jugar()
    {
        SceneManager.LoadScene(nombreEscena); 
    }
}
