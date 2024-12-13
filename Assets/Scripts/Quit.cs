using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void Wyjdz(string menu)
    {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }
}
