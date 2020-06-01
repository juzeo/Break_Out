using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour
{
   
    public GameObject preBall;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {

            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Ball")
        {

            GameObject.Find("LevelSetting").GetComponent<Level>().ballCount--;
            Destroy(collision.gameObject);
            if (GameObject.Find("LevelSetting").GetComponent<Level>().ballCount ==0)
            {

                GameObject.Find("LevelSetting").GetComponent<Level>().regame();
                
            }
        }
    }
}
