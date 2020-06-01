using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongBarItem : MonoBehaviour
{
    public GameObject Stick;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Stick = GameObject.Find("Stick");
        if (collision.gameObject.tag == "Stick")
        {
          
                Stick.GetComponent<StickMove>().LongStick();
            
            Destroy(this.gameObject);
        }
        if (collision.gameObject == GameObject.Find("DeadLine"))
        {
            Destroy(this.gameObject);
        }
    }
}
