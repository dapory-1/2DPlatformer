using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.tag == "Player")
        {
            GameManager.Instance.Die();
        }
   }
}
