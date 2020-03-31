using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movement;
    public float speed;
    public int score;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardMovement();
        


        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Banana"))
        {
            score++;
            Destroy(other.gameObject);
        }
    }

    public void KeyboardMovement()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetKey(KeyCode.D))
        {
            movement = 1 ;
            if (transform.position.x <= 5)
            {
                rb.transform.Translate(new Vector3(movement * speed * Time.deltaTime, 0, 0));
                transform.localRotation = Quaternion.Euler(0, 0, -10f);
            }
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement = -1;
            if (transform.position.x >= -5)
            {
                rb.transform.Translate(new Vector3(movement * speed * Time.deltaTime, 0, 0));
                transform.localRotation = Quaternion.Euler(0, 0, 10f);
            }
            
        }



        
    }

   


}
