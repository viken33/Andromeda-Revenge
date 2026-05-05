using System;
using UnityEngine;

public class EnemyType1 : MonoBehaviour
{

  public float ySpeed = -5.0f;
  public float xSpeed = -5.0f;
  public float movementAmplitud = 15.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * xSpeed, Time.deltaTime * movementAmplitud * ((float)Math.Sin(transform.position.x )),0);

    }
 
}
