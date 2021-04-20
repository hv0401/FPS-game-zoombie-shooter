using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartS : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        SceneManager.LoadScene("NightLevel");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
