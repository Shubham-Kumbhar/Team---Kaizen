using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int noOfLives=3; 
    public GameObject[] liveHearts;
    // Update is called once per frame
    void Update()
    {
        if (noOfLives == 0)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("GameOver");
        } 
       
    }
}

