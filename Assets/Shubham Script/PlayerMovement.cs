using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public int typeOFWepon;
    [SerializeField] float speedX,yPos;
    [SerializeField] Slider joyStick;
    public bool a= true;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(joyStick.value*speedX, yPos);
        activateWepons(typeOFWepon);

    }

    public void shoot(int j)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (i == j)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    public void activateWepons(int j)
    {
        for (int i = 0; i < 4; i++)
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
