using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimMove : MonoBehaviour
{
    public int HP = 30;
    public Vector2 vel;
    public GameObject Damage;
    public Sprite Angry;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity=new Vector3(3, 0, 0);
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D col)
    {
        vel = gameObject.GetComponent<Rigidbody2D>().velocity;
        if (vel.x > 5)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(5, vel.y);
        }
        else if (vel.y > 5)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(vel.x, 5);
        }

        if (col.gameObject.tag == "Ball" || col.gameObject.tag == "Bullet")
        {
            if (GameObject.FindWithTag("Ball").GetComponent<BallMove>().stay == false)
            {
                HP--;
                Instantiate(Damage, new Vector3(transform.position.x + Random.Range(-1, 1), transform.position.y + Random.Range(-1, 1), -1), Quaternion.identity);

            }
            if (col.gameObject.tag == "Bullet")
            {


                Destroy(col.gameObject);
            }

            

            if (HP == 0)
            {
              
                GameObject.Find("LevelSetting").GetComponent<Level>().Score += 1;
                

                if (gameObject.transform.parent.tag == "OnOFFBlock")
                {

                    Destroy(this.gameObject.transform.parent.gameObject);
                }
                Destroy(gameObject);

            }
            if (HP <= 10)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Angry;
            }
            
        }
    }
  
}
