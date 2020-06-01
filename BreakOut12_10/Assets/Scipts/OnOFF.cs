using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOFF : MonoBehaviour
{
    public bool On;
    public GameObject[] OnOffBlock;
    public GameObject[] reset;
    private void Awake()
    {
        OnOffBlock = GameObject.FindGameObjectsWithTag("OnOFFBlock");
    }
  

    private void OnCollisionEnter2D(Collision2D col)
    {
        OnOffBlock = reset;
        OnOffBlock = GameObject.FindGameObjectsWithTag("OnOFFBlock");
        if (col.gameObject.tag == "Ball" || col.gameObject.tag == "Bullet"||col.gameObject.tag=="Boss")
        {
            GameObject.Find("LevelSetting").GetComponent<Level>().OnOff();
           if(col.gameObject.tag == "Bullet")
            {
                Destroy(col.gameObject);
            }
            
        }
       
    }
    public void ChangeColor()
    {
        OnOffBlock = reset;
        OnOffBlock = GameObject.FindGameObjectsWithTag("OnOFFBlock");
        On = GameObject.Find("LevelSetting").GetComponent<Level>().On;
        if (On==false)
        {
            
            gameObject.GetComponent<TextMesh>().text = "OFF";
            gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.blue;
           
                for (int i = 0; i < OnOffBlock.Length; i++)
                {
                    OnOffBlock[i].transform.GetChild(0).gameObject.SetActive(false);
                }
          
           
        }
        else
        {
            
            gameObject.GetComponent<TextMesh>().text = "ON";
            gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.red;

            for (int i = 0; i < OnOffBlock.Length; i++)
            {
                OnOffBlock[i].transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}
