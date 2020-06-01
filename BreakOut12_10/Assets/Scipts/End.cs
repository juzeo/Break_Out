using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject.Find("LevelSetting").GetComponent<Level>().NowLevel = 1;
            GameObject.Find("LevelSetting").GetComponent<Level>().die = 0;
            GameObject.Find("LevelSetting").GetComponent<Level>().regamezero();
            gameObject.SetActive(false);
            GameObject.Find("Die").GetComponent<Text>().text = "Die = 0";
        }
    }
}
