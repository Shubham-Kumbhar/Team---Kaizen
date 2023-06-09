using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public int typeOFWepon;
    [SerializeField] float speedX,yPos;
    public Slider joyStick;
    public bool a= true;
    public float abilitytimer;

    public bool abilityActivte= false;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(joyStick.value*speedX, yPos);
        activateWepons(typeOFWepon);

        if(abilityActivte)
        {

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
        abilityActivte = false;
        yield return new WaitForSeconds(abilitytimer);
        typeOFWepon=0;
    }
}
