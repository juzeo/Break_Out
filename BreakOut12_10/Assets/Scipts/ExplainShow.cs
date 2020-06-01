using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplainShow : MonoBehaviour
{
    public GameObject explain;
  
   public void OnMouseEnter()
    {
       
        explain.SetActive(true);
    }
  
    public void OnMouseExit()
    {
        explain.SetActive(false);
    }
}
