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
    [SerializeField] int abilityTimer= 10;
    // Update is called once per frame
    public bool acilityActivated= false;
    void Update()
    {
        transform.position = new Vector2(joyStick.value*speedX, yPos);
        activateWepons(typeOFWepon);
        if(acilityActivated)
        {
            StartCoroutine(resetAbility());
        }

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
    IEnumerator resetAbility()
    {
        acilityActivated = false;
        yield return new WaitForSeconds(abilityTimer);
        activateWepons(0);
    }
}
