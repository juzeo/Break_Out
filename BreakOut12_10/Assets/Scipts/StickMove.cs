using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMove : MonoBehaviour {

    public float MoveSpeed = 15f;
    public Vector3 pos;
    public GameObject temp;

	void Update () {
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-MoveSpeed* Time.smoothDeltaTime,0f,0f);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(MoveSpeed * Time.smoothDeltaTime, 0f, 0f);
        }
       
    }
    public void LongStick()
    {
        this.transform.localScale += new Vector3(1, 0,0);
    }
    public void ShortStick()
    {

        this.transform.localScale = new Vector3(transform.localScale.x/1.5f, transform.localScale.y, transform.localScale.z);
    }
    public IEnumerator Razer()
    {
        for (int i = 0; i < 3; i++)
        {
            temp = Instantiate(Resources.Load("Bullet") as GameObject, this.transform.position+new Vector3(0,1), Quaternion.identity);
            temp.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);
            yield return new WaitForSeconds(1);
        }
 
    }
   
    


}
