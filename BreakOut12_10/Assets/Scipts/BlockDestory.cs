using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestory : MonoBehaviour
{
    public int HP = 1;
    public Material SetColor;
    public Color SkyBlue;
    public bool TwoBallBlockCheck;
    public GameObject TwoBallBlock;
    public bool SpeedBallBlockCheck;
    public GameObject SpeedBall;
    public bool SlowBallBlockCheck;
    public GameObject SlowBall;
    public bool LongStickCheck;
    public GameObject LongStick;
    public bool ShortStickCheck;
    public GameObject ShortStick;
    public bool RazerCheck;
    public GameObject Razer;
    public bool BigBallCheck;
    public GameObject BigBall;

    // Start is called before the first frame update
    private void Awake()
    {
        GameObject.Find("LevelSetting").GetComponent<Level>().CheckBlock();
        SetColor = gameObject.GetComponent<MeshRenderer>().material;
        TwoBallBlock = Resources.Load("Item/TwoBallItemBlock") as GameObject;
        SpeedBall = Resources.Load("Item/SpeedBallBlock") as GameObject;
        SlowBall = Resources.Load("Item/SlowBallBlock") as GameObject;
        LongStick = Resources.Load("Item/LongBarItemBlock") as GameObject;
        ShortStick= Resources.Load("Item/ShortBarItemBlock") as GameObject;
        Razer = Resources.Load("Item/RazerItemBlock") as GameObject;
        BigBall = Resources.Load("Item/BigBallBlock") as GameObject;


    }
    void Start()
    {
        CheckColor();
    }

    void CheckColor()
    {
        if (HP == 4)
        {
            SetColor.color = Color.blue;
        }
        else if (HP == 3)
        {
            SetColor.color = Color.red;
        }
        else if (HP == 2)
        {
            SetColor.color = Color.green;
        }
       else if (HP == 1)
        {
            SetColor.color = Color.cyan;
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Ball"||col.gameObject.tag=="Bullet")
        {
            
            HP--;
            CheckColor();
            if (col.gameObject.tag == "Bullet")
            {


                Destroy(col.gameObject);
            }
            if (HP == 0)
            {
                if (TwoBallBlockCheck == true)
                {
                    Instantiate(TwoBallBlock, this.transform.position, Quaternion.identity);
                }
               else if (SpeedBallBlockCheck == true)
                {
                    Instantiate(SpeedBall, this.transform.position, Quaternion.identity);
                }
               else if (SlowBallBlockCheck == true)
                {
                    Instantiate(SlowBall, this.transform.position, Quaternion.identity);
                }
               else if (LongStickCheck == true)
                {
                    Instantiate(LongStick, this.transform.position, Quaternion.identity);
                }
                else if (ShortStickCheck == true)
                {
                    Instantiate(ShortStick, this.transform.position, Quaternion.identity);
                }
                else if (RazerCheck == true)
                {
                    Instantiate(Razer, this.transform.position, Quaternion.identity);
                }
                else if (BigBallCheck == true)
                {
                    Instantiate(BigBall, this.transform.position, Quaternion.identity);
                }
                GameObject.Find("LevelSetting").GetComponent<Level>().Score+=1;
                GameObject.Find("LevelSetting").GetComponent<Level>().CheckBlock();
               
                if (gameObject.transform.parent.tag == "OnOFFBlock")
                {

                    Destroy(this.gameObject.transform.parent.gameObject);
                }
                Destroy(gameObject);
                
            }
        }
    }
  
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Ball" || col.gameObject.tag == "Bullet")
        {

            HP--;
            Destroy(col.gameObject);
            CheckColor();
            if (HP == 0)
            {
                if (TwoBallBlockCheck == true)
                {
                    Instantiate(TwoBallBlock, this.transform.position, Quaternion.identity);
                }
               else if (SpeedBallBlockCheck == true)
                {
                    Instantiate(SpeedBall, this.transform.position, Quaternion.identity);
                }
                else if (SlowBallBlockCheck == true)
                {
                    Instantiate(SlowBall, this.transform.position, Quaternion.identity);
                }
               else  if (LongStickCheck == true)
                {
                    Instantiate(LongStick, this.transform.position, Quaternion.identity);
                }
               else  if (ShortStickCheck == true)
                {
                    Instantiate(ShortStick, this.transform.position, Quaternion.identity);
                }
                else if (RazerCheck == true)
                {
                    Instantiate(Razer, this.transform.position, Quaternion.identity);
                }
                else if (BigBallCheck == true)
                {
                    Instantiate(BigBall, this.transform.position, Quaternion.identity);
                }
                GameObject.Find("LevelSetting").GetComponent<Level>().Score += 1;
                GameObject.Find("LevelSetting").GetComponent<Level>().CheckBlock();
                
                
                Destroy(gameObject);

            }
        }
    }

    
}
