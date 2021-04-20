using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class score : MonoBehaviour
{
    public Text ScoreText;
    private float scoree = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        scoree += Time.deltaTime;
        ScoreText.text = ((int)scoree).ToString();

        if(scoree >= 6000f)
        {
            //Debug.Log("you won");
            SceneManager.LoadScene("win");
        }
        
    }
}
