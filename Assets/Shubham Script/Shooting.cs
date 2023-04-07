using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private PlayerMovement player;
    private void Start()
    {
        player = GameObject.Find("player").GetComponent<PlayerMovement>();
    }
    private void OnMouseDown()
    {
        player.shoot(0);
    }
    private void OnMouseUp()
    {
        for(int i=0; i < player.gameObject.transform.childCount;i++)
        {
            player.gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
      
    }
    public void shhhhhooot()
    {
        player.shoot(0);
    }    
}
