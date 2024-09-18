using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour

{
    private bool isLuna = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("血瓶被" + collision + "吃掉了");
        LunaController lunacontroller = collision.GetComponent<LunaController>();
        if (isLuna)
        {
            if(lunacontroller.PublicCurrentHealth < lunacontroller.PublicMaxHealth)
            {
                lunacontroller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
       
    }
    //private void OnTriggerEnter(Collider2D collision)
    //{
        
    //}
}
