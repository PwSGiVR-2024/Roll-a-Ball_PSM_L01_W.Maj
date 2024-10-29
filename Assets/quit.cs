using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
    public void Wyjdz(string menu)
    {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }
}
