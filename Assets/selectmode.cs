using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectmode : MonoBehaviour
{
    // Start is called before the first frame update
    public void nightmode()
    {
        SceneManager.LoadScene("NightLevel");
    }

    public void daymode()
    {
        SceneManager.LoadScene("DayLevel");
    }
}
