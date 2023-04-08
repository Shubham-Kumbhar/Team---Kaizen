using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int noOfLives=3; 
    public GameObject[] liveHearts;
    public GameObject destroyShipAnim;

    [SerializeField] private AudioSource aud;
    [SerializeField] private AudioClip clip;
    // Update is called once per frame
    void Update()
    {
        if (noOfLives == 0)
        {
            this.gameObject.SetActive(false);
            Instantiate(destroyShipAnim, this.transform.position, Quaternion.identity);
            aud.PlayOneShot(clip);
            Time.timeScale = 0;
            SceneManager.LoadScene("GameOver");
        } 
       
    }
}

