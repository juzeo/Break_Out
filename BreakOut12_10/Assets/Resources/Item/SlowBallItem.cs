using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowBallItem : MonoBehaviour
{
    public GameObject[] Ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ball.Initialize();
        Ball = GameObject.FindGameObjectsWithTag("Ball");
        if (collision.gameObject.tag == "Stick")
        {
            for (int i = 0; i < Ball.Length; i++)
            {

                Ball[i].GetComponent<BallMove>().SlowBall();
            }
            Destroy(this.gameObject);
        }
        if (collision.gameObject == GameObject.Find("DeadLine"))
        {
            Destroy(this.gameObject);
        }
    }
}
