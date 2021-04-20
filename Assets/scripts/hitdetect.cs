using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hitdetect : MonoBehaviour
{
    public Slider healthslider;
    public void OnTriggerEnter(Collider other)
    {
        //healthslider.value -= 20f;
        if(other.CompareTag("weapon"))
        {
            healthslider.value -= 20f;
        }

        //Debug.Log("we hit the weapon");
        if(healthslider.value <= 0)
        {
            SceneManager.LoadScene("GameOver");
            //Debug.Log("player die");

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
