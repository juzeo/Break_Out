using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoBallItem : MonoBehaviour
{
    public GameObject[] TwoBall;
    public GameObject[] reset;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TwoBall.Initialize();
        TwoBall = GameObject.FindGameObjectsWithTag("Ball");
        if (collision.gameObject.tag == "Stick")
        {
            for (int i = 0; i < TwoBall.Length; i++)
            {
               
                TwoBall[i].GetComponent<BallMove>().TwoBall();
            }
            Destroy(this.gameObject);
        }
        if (collision.gameObject == GameObject.Find("DeadLine"))
        {
            Destroy(this.gameObject);
        }
    }
}
