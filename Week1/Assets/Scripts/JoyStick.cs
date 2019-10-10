using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    private playerControl player;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<playerControl>();
    }
    public void OnPointerUp(PointerEventData data)
    {
        player.StopMoving();
    }
    public void OnPointerDown(PointerEventData data)
    {
        if(gameObject.name == "Button_Left")
        {
            player.setMoveLeft(true);
        }
        if (gameObject.name == "Button_Right")
        {
            player.setMoveLeft(false);
        }
    }
  
}
