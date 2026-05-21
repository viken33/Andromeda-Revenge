using UnityEngine;

public class EnemyType3 : Enemy // INHERITANCE
{

  public float speed = 5;
  GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      player = GameObject.Find("Player");
    }

    void Update()
    {
     Move();       
     transform.position = new Vector3(transform.position.x, transform.position.y, -4);
     
    }

  protected override void Move() // POLYMORPHISM
  {
    // Moves towards the player
     if (player != null) {
    
      Vector3 towardsPlayer = (player.transform.position - transform.position).normalized;
      transform.Translate(Time.deltaTime * towardsPlayer * speed);
      
     } else
    {
      transform.Translate(Time.deltaTime * (-speed),0,0);
    }

  }
}
