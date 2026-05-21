using System;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyType1 : Enemy
{

  
  public float xSpeed = -8.0f;
  public float frequency = 0.5f;
  public float movementAmplitude = 3f;
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
    // transform.Translate(xSpeed*Time.deltaTime,0,0);
    float newY = Mathf.Sin(Time.time * frequency) * movementAmplitude;
    // transform.position = new Vector3(xSpeed, newY, 0)*Time.deltaTime;
    
    transform.Translate(Time.deltaTime * xSpeed, Time.deltaTime * newY,0, Space.World);
  }
}
