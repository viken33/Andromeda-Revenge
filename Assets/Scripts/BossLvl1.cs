using UnityEngine;
using System;

public class BossLvl1 : Enemy
{

   public EnemyBullet bulletsPrefab;
   public misil misilePrefab;
   public GameObject player;
   public int yBoundary = 6;
   public float ySpeed = -5.0f;
   public Vector3 spawnPos;
   private int life = 20;
   private float initialTimeBullets;
   private float initialTimeMissils;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      spawnPos = transform.position;  
      initialTimeBullets = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
      // shoot bullets in an interval  
     if (Time.time > initialTimeBullets + UnityEngine.Random.Range(1f, 2f))
    {
      shootBullets();
      initialTimeBullets = Time.time;
    }
     // shoot missiles in an interval aimed at the initial position of the player in the frame.
    if (Time.time > initialTimeMissils + UnityEngine.Random.Range(4f, 6f))
    {
      shootMissiles();
      initialTimeMissils = Time.time;
    }

     // if life reaches 0 you boss dies
     if (life == 0)
    {
    // TODO: play a sound
    // TODO: play animation
     Destroy(gameObject);
    }   

    // move up and down
      Move(); 
      
    
    }

    void shootBullets()
  {
    for (int i =1; i < 5; i++)
    {
    EnemyBullet bullet = Instantiate(bulletsPrefab, transform.position, Quaternion.identity);
    bullet.Fire(player.transform);
    }
  }

  void shootMissiles()
  {
    Instantiate(misilePrefab, transform.position + new Vector3(0,2,0), Quaternion.identity);
    Instantiate(misilePrefab, transform.position + new Vector3(0,-2,0), Quaternion.identity);
  }

  protected override void Move()
  {
    transform.Translate(0, Time.deltaTime * ySpeed, 0);
        
      if (transform.position.y > spawnPos.y + yBoundary)
        {
          ySpeed = -Math.Abs(ySpeed);
        }
      if (transform.position.y < spawnPos.y - yBoundary)
        {
          ySpeed = Math.Abs(ySpeed);
        }
  }
// each bullet collision decrements bosses life
  protected new void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("PlayerBullet")){
      life --;
    }
  }
}
