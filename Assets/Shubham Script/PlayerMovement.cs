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
}
