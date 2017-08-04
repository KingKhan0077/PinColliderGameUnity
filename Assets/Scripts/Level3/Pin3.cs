using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin3 : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private bool ispin = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!ispin)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);


        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            col.GetComponent<Rotator>().speed *= -1;
            col.GetComponent<Rotator>().speed += (1/2);
            Score.pincount += 1;
            ispin = true;
        }
        else if (col.tag == "pin")
        {
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
