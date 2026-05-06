
using UnityEngine;
using System;

public class EnemyType2 : Enemy
{

  public float ySpeed = -5.0f;
  public float xSpeed = -5.0f;
  public float movementAmplitude = 3.0f;
  public EnemyBullet bulletsPrefab;
  public GameObject player;
  private Vector3 spawnPos;
  private float initialTime;
  private float shootInterval = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPos = transform.position;
        player = GameObject.FindWithTag("Player");
        initialTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       
      Move();


       shootInterval = UnityEngine.Random.Range(2f, 4f);
     if (player && (Time.time > initialTime + shootInterval))
    {
      ShootPlayer();
      initialTime = Time.time;
    }
      
    }
  protected override void Move()
  {
     transform.Translate(Time.deltaTime * xSpeed , 0 , 0);
     transform.Translate(Time.deltaTime * xSpeed , Time.deltaTime * ySpeed, 0);
        // Movement
      if (transform.position.y > spawnPos.y + movementAmplitude)
        {
          ySpeed = -Math.Abs(ySpeed);
        }
      if (transform.position.y < spawnPos.y - movementAmplitude)
        {
          ySpeed = Math.Abs(ySpeed);
        }
  }
    void ShootPlayer()
  {
    EnemyBullet bullet = Instantiate(bulletsPrefab, transform.position, Quaternion.identity);
    bullet.Fire(player.transform);
  }
}