using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BIrds : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject target;
    private float speed = 1.3f;
    public float backspeed = 1.5f;
    public float attack1Range = 1f;
    public int attack1Damage = 1;
    public float timeBetweenAttacks;
   // private float min;
   // private float max;
  
    void Start()
    {
       // min = transform.position.x;
       // max = transform.position.x + 3;
        target = GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {

        //transform.Translate(Vector3.up * Time.deltaTime * 0.3f);
        MoveToPlayer();
    }
     

    public void MoveToPlayer()
    {
        //rotate to look at player
        transform.LookAt(target.transform.position);
        //transform.Rotate(0, -90, 0);

        //move towards player
        //if (Vector3.Distance(transform.position, target.position) > attack1Range)
        //{
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        //transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * 2, max - min) + min);

        // }
    }

    public void Rest()
    {

    }

}
