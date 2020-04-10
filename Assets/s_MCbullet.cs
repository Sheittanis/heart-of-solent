using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_MCbullet : MonoBehaviour {

    public float timer;
    public bool exists;

    // Use this for initialization
    void Start()
    {
        timer = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            //autodestruct
            destruction();
        }
    }

    public void destruction()
    {
        Destroy(gameObject); //destroy this shit
    }

    public void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.gameObject.tag == "Player" || Col.gameObject.tag == "Boundary") //destroyed if it touches the boundaries
        {
            Destroy(gameObject);
            Col.gameObject.GetComponent<s_heart>().Death(); //rip
        }
        else
        {
            Destroy(gameObject);
        }

    }
}

