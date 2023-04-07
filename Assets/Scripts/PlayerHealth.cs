using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int noOfLives=3; 
    public GameObject[] liveHearts;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(noOfLives==0)
        SceneManager.LoadScene("GameOver");
        
        
    }
    }

