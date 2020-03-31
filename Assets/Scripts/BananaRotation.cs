using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaRotation : MonoBehaviour
{

    public  float rotation;
   public  float speed;


    void Update()
    {
        rotation += speed * Time.deltaTime;

        transform.localRotation = Quaternion.Euler(0, 0, -rotation);
    }
}
