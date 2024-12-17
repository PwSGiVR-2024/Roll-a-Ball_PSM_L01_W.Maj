using UnityEngine;
using UnityEngine.SceneManagement;

public class WinText : MonoBehaviour
{
    void Update()
    {
        NextLevel();
    }
    private void NextLevel()
    {
        if (Input.GetKey(KeyCode.Space))
        { SceneManager.LoadScene(4); }
    }
}
