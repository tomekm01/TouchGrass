using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scriptong : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public LogicScript logic;

    public int bounce;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Nerdzior";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.up * bounce;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector2.left);
        }

        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector2.right);
        }

        if (transform.position.x > 15)
        {
            rigidbody.velocity = Vector2.left * bounce;
        }

        if (transform.position.x < -15)
        {
            rigidbody.velocity = Vector2.right * bounce;
        }

        if (transform.position.y > 7)
        {
            rigidbody.velocity = Vector2.down * bounce;
        }

        if (transform.position.y < -7)
        {
            rigidbody.velocity = Vector2.up * bounce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.addScore();
    }

}
