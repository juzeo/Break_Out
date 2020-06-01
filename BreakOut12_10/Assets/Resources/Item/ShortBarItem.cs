using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortBarItem : MonoBehaviour
{
    public GameObject Stick;

    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Stick = GameObject.Find("Stick");
        if (collision.gameObject.tag == "Stick")
        {

            Stick.GetComponent<StickMove>().ShortStick();

            Destroy(this.gameObject);
        }
        if (collision.gameObject == GameObject.Find("DeadLine"))
        {
            Destroy(this.gameObject);
        }
    }
}
