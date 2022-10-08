using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20.0f;

    public float rotSpeed = 40.0f;


    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;

        float rotation = Input.GetAxis("Horizontal") * rotSpeed;

        translation *= Time.deltaTime;

        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);
    }
}
