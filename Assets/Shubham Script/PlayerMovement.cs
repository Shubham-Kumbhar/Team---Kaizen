using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float speedX,yPos;
    [SerializeField] Slider joyStick;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(joyStick.value*speedX, yPos);
    }

    public void shoot(int j)
    {
        for(int i=0;i<transform.childCount;i++)
        {
            if(i==j)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
