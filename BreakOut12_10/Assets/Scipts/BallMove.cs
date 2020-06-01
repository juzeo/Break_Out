using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float startSpeed = 10;
    private GameObject Stick;
    public Boolean stay = false;
    public GameObject ball;
    public AudioClip BlockSound;
    public AudioClip WallSound;
    public AudioClip StickSound;
    private Vector2 vel;
    private Vector3 StartSp;



    // Start is called before the first frame update
    void Start()
    {
        StartSp = new Vector3(UnityEngine.Random.Range(-5.0f, 5.0f), startSpeed, 0);
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(UnityEngine.Random.Range(-5.0f, 5.0f), startSpeed, 0)* Time.smoothDeltaTime;
        Stick = GameObject.Find("Stick");
       
    }
    void BallSetting() {
        this.transform.position=new Vector3(Stick.transform.position.x, Stick.transform.position.y + 0.3f,-3f);
    }
    // Update is called once per frame
    void Update()
    {

        if (stay ==true)
        { BallSetting();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.GetComponent<Rigidbody2D>().velocity= new Vector3(UnityEngine.Random.Range(-5.0f, 5.0f), startSpeed, 0)* Time.smoothDeltaTime;
                stay = false;
            }
        }  
    }
   
    public void SlowBall()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity /= 2;
    }
    public void SpeedBall()
    {
      // Vector2 SpeedPlus = gameObject.GetComponent<Rigidbody2D>().velocity;
        //SpeedPlus *=2;
        
        gameObject.GetComponent<Rigidbody2D>().velocity *= 2 * Time.smoothDeltaTime/ Time.smoothDeltaTime;
    }
    public void TwoBall()
    {
        
        GameObject temp =Instantiate(ball, new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z), Quaternion.identity);



        GameObject.Find("LevelSetting").GetComponent<Level>().ballCount++;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        vel = GetComponent<Rigidbody2D>().velocity;
        if (vel.y == 0)
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, -0.1f);
        }
        if (collision.gameObject.tag == "Stick")
        {
           
            this.GetComponent<AudioSource>().clip = StickSound;
            this.GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject.tag == "Block"|| collision.gameObject.tag=="OnOff" || collision.gameObject.tag == "OnOFFBlock")
        {

            this.GetComponent<AudioSource>().clip = BlockSound;
            this.GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject.tag == "Wall")
        {
            
            this.GetComponent<AudioSource>().clip = WallSound;
            this.GetComponent<AudioSource>().Play();
            
        }
    }
    public void BigBall()
    {
        gameObject.transform.localScale *= 1.5f;
    }



}
