using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void UruchomGre(string SampleScene)
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }


    public void PokazOpcje(string options)
    {
        SceneManager.LoadScene("options", LoadSceneMode.Single);
    }

    void OnApplicationQuit()
    {
        Application.Quit();
        Debug.Log("Application ending after " + Time.time + " seconds");
    }
    public void WyjdzZGry()
    {
        OnApplicationQuit();
    }
}
