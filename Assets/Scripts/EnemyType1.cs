using System;
using UnityEngine;

public class EnemyType1 : Enemy
{

  
  public float xSpeed = -15.0f;
  public float movementAmplitude = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
      Move();
    }
 

    protected override void Move()
  {
    transform.Translate(xSpeed*Time.deltaTime,0,0);
    transform.Translate(Time.deltaTime * xSpeed, Time.deltaTime * movementAmplitude * ((float)Math.Sin(transform.position.x )),0);
  }
}
