using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public GameObject RedBlock;
    public GameObject GreenBlock;
    public GameObject SkyBlueBlock;
    public int first = 10,sec=10,third=10;
    public int NowLevel = 1;
    public GameObject clear;
    public GameObject ScoreView;
    public GameObject Ball;
    public GameObject[] Balls;
    public GameObject[] Blocks;
    public int ballCount = 1;
    public GameObject UpStick;
    public int HeartCount = 3;
    public GameObject[] Heart;
    public GameObject[] reset;
    public GameObject GameOver;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject level6;
    public GameObject level7;
    public GameObject level8;
    public GameObject level9;
    public int die = 0;
    public BlockDestory temp;
    public bool On;
    public GameObject[] OnOffBlock;
    public Text EndingText;

    public int Score = 0;

    public GameObject UpDeadLine;


    private void Awake()
    {
        
        Balls = GameObject.FindGameObjectsWithTag("Ball");
        ScoreView = GameObject.Find("LevelView");
        /*RedBlock = GameObject.Find("Red Block");
       GreenBlock = GameObject.Find("Green Block");
        SkyBlueBlock = GameObject.Find("SkyBlue Block");
        */
        
    }
    // Start is called before the first frame update
    void Start()
    {
       
       LevelMove();
        
       
    }

    // Update is called once per frame
    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            NowLevel=1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            NowLevel = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            NowLevel = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            NowLevel = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            NowLevel = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            NowLevel = 6;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            NowLevel = 7;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            NowLevel = 8;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            NowLevel = 9;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            regame();
        }
        
    }
    */
    
    IEnumerator Level1()
    {

        Instantiate(level1);
        makeItem(2);
        yield return null;

    }

    public void makeItem(int num)
    {
        Blocks = reset;
        Blocks = GameObject.FindGameObjectsWithTag("Block");
        for (int i = 0; i < num; i++)
        {
            temp = Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();

            while (temp.LongStickCheck && temp.SpeedBallBlockCheck && temp.TwoBallBlockCheck&&temp.RazerCheck && temp.ShortStickCheck && temp.BigBallCheck)
            {
                temp = Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            }

            temp.TwoBallBlockCheck = true;
            temp = Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            while (temp.LongStickCheck&& temp.SpeedBallBlockCheck &&temp.TwoBallBlockCheck && temp.RazerCheck && temp.ShortStickCheck && temp.BigBallCheck)
            {
                temp = Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            }
           
           temp.SpeedBallBlockCheck = true;
            temp = Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            while (temp.LongStickCheck && temp.SpeedBallBlockCheck &&temp.TwoBallBlockCheck && temp.RazerCheck && temp.ShortStickCheck && temp.BigBallCheck)
            {
                Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            }

            temp.LongStickCheck = true;
            temp = Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            while (temp.LongStickCheck && temp.SpeedBallBlockCheck && temp.TwoBallBlockCheck && temp.RazerCheck && temp.ShortStickCheck && temp.BigBallCheck)
            {
                Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            }

            temp.ShortStickCheck = true;

            temp = Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            while (temp.LongStickCheck && temp.SpeedBallBlockCheck && temp.TwoBallBlockCheck && temp.RazerCheck && temp.ShortStickCheck && temp.BigBallCheck)
            {
                Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            }
            temp.RazerCheck = true;

            temp = Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            while (temp.LongStickCheck && temp.SpeedBallBlockCheck && temp.TwoBallBlockCheck && temp.RazerCheck && temp.ShortStickCheck&& temp.BigBallCheck)
            {
                Blocks[Random.Range(0, Blocks.Length)].GetComponent<BlockDestory>();
            }
            temp.BigBallCheck = true;

        }
       
    }
    public void CheckBlock()
    {
        
        if (Score == 20&&NowLevel==1)
        {
            StartCoroutine("clearMo");
            NowLevel++;
            LevelMove();
            Score = 0;
        }
        else if (Score == 16 && NowLevel == 2)
        {
            StartCoroutine("clearMo");
            NowLevel++;
            LevelMove();
            Score = 0;
        }
        else if (Score == 33 && NowLevel == 3)
        {
            StartCoroutine("clearMo");
            NowLevel++;
            LevelMove();
            Score = 0;
        }
        else if (Score == 10&& NowLevel == 4)
        {
            StartCoroutine("clearMo");
            NowLevel++;
            LevelMove();
            Score = 0;
        }
        else if (Score == 15 && NowLevel ==5)
        {
            StartCoroutine("clearMo");
            NowLevel++;
            LevelMove();
            Score = 0;

        }
        else if (Score == 40 && NowLevel == 6)
        {
            StartCoroutine("clearMo");
            NowLevel++;
            LevelMove();
            Score = 0;

        }
        else if (Score == 15 && NowLevel == 7)
        {
            StartCoroutine("clearMo");
            NowLevel++;
            LevelMove();
            Score = 0;

        }
        else if (Score ==20  && NowLevel == 8)
        {
            Ending();
            

        }
        

    }
    public void Ending()
    {
        EndingText.text = "THE END\nDIE = " + die+ "\nrestart button P";
        EndingText.gameObject.SetActive(true);
    }
    void LevelMove()
    {
        On = false;
        UpStick.SetActive(false);
        UpDeadLine.SetActive(false);
        Destroy(GameObject.FindWithTag("Level"));
        OnOffBlock = GameObject.FindGameObjectsWithTag("OnOff");
        for (int i = 0; i < OnOffBlock.Length; i++)
        {
            Destroy(OnOffBlock[i]);
        }
        GameObject.Find("Stick").transform.localScale = new Vector3(2, 0.2f, 1);
        HeartCount=3;
        for (int i = 0; i < HeartCount; i++)
        {
            Heart[i].SetActive(true);
        }
        Score = 0;
        ScoreView.GetComponent<Text>().text = "Level = " + NowLevel;
        GameObject.FindWithTag("Ball").GetComponent<BallMove>().stay = true;
        Blocks = reset;
        Blocks = GameObject.FindGameObjectsWithTag("Block");

        ballCount = 1;
        for (int i = 0; i < Balls.Length; i++)
        {
            Destroy(Balls[i]);

        }
        switch (NowLevel)
        {
            case 1:
                StartCoroutine("Level1");
                break;

            case 2:
                StartCoroutine("Level2");
                break;
           case 3:
                StartCoroutine("Level3");
                break;
            case 4:
                StartCoroutine("Level4");
                break;
            case 5:
                StartCoroutine("Level5");
                break;
            case 6:
                StartCoroutine("Level6");
                break;
            case 7:
                StartCoroutine("Level7");
                break;
            case 8:
                StartCoroutine("Level8");
                break;
            case 9:
                StartCoroutine("Level9");
                break;

        }
        ballCount = 1;
        Balls = reset;
        Balls = GameObject.FindGameObjectsWithTag("Ball");
        for (int i = 0; i < Balls.Length; i++)
        {
            Destroy(Balls[i]);

        }
        Instantiate(Ball, this.transform);
        
        ballCount = 1;

    }
    IEnumerator Level2()
    {

        Instantiate(level2);
        makeItem(2);
        yield return null;

    }
    IEnumerator clearMo()
    {
        clear.SetActive(true);
        yield return new WaitForSeconds(2f);
        clear.SetActive(false);
    }
    IEnumerator GameOverMo()
    {
       GameOver.SetActive(true);
        yield return new WaitForSeconds(2f);
        GameOver.SetActive(false);
    }
    public void regamezero()
    {
        StartCoroutine("GameOverMo");
        Balls = reset;
        Balls = GameObject.FindGameObjectsWithTag("Ball");
        Blocks = GameObject.FindGameObjectsWithTag("Block");

        ballCount = 1;
        for (int i = 0; i < Balls.Length; i++)
        {
            Destroy(Balls[i]);

        }
        Instantiate(Ball, this.transform);
        for (int i = 0; i < Blocks.Length; i++)
        {
            Destroy(Blocks[i]);
        }

        ballCount = 1;
        LevelMove();
    }
    public void regame()
    {
        
        HeartCount--;
        Heart[HeartCount].SetActive(false);
        
        if (HeartCount == 0)
        {
            die++;
            GameObject.Find("Die").GetComponent<Text>().text = "Die = " + die;
            regamezero();
        }
        else
        {
            Balls = reset;
            Balls = GameObject.FindGameObjectsWithTag("Ball");
            Instantiate(Ball, this.transform);
            ballCount = 1;
            for (int i = 0; i < Balls.Length; i++)
            {
                Destroy(Balls[i]);

            }
            ballCount = 1;

        }
    }
    IEnumerator Level3()
    {
        Instantiate(level3);
        makeItem(3);
        yield return null;
    }
        IEnumerator Level4()
    {
        
        UpStick.SetActive(true);
        UpDeadLine.SetActive(true);
        Instantiate(level4);
        makeItem(3);
        yield return null;
    }

    public void OnOff()
    {
        if (On==false)
        {
            On = true;

        }
        else
        {
            On =false;
        }
        OnOffBlock = GameObject.FindGameObjectsWithTag("OnOff");
        for (int i = 0; i < OnOffBlock.Length; i++)
        {
            OnOffBlock[i].GetComponent<OnOFF>().ChangeColor();
        }
    }
    IEnumerator Level5()
    {
        Instantiate(level5);
        makeItem(1);
        yield return null;
    }
    IEnumerator Level6()
    {
        Instantiate(level6);
        makeItem(10);
        yield return null;
    }
    IEnumerator Level7()
    {
        Instantiate(level7);
        makeItem(2);
        yield return null;
    }
    IEnumerator Level8()
    {
        Instantiate(level8);
        UpStick.SetActive(true);
        UpDeadLine.SetActive(true);
        makeItem(2);
       
        yield return null;
    }

}
