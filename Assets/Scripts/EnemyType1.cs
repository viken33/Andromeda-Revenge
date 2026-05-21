using System;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyType1 : Enemy
{
  public float xSpeed = -8.0f;
  public float frequency = 0.5f;
  public float movementAmplitude = 3f;

  
    void Update()
    {
      Move();
    }
 
    protected override void Move()
  {
    // This enemy moves in a sinusoidal wave
    float newY = Mathf.Sin(Time.time * frequency) * movementAmplitude;
    transform.Translate(Time.deltaTime * xSpeed, Time.deltaTime * newY,0, Space.World);
  }
}
