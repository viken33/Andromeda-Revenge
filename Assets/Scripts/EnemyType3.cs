using UnityEngine;

public class EnemyType3 : Enemy
{

  public float speed = 5;
  GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
     Move();       
     transform.position = new Vector3(transform.position.x, transform.position.y, -4);
     
    }

  protected override void Move()
  {
    // Moves towards the player
     if (player != null) {
    
      Vector3 towardsPlayer = (player.transform.position - transform.position).normalized;
      print(towardsPlayer);
      transform.Translate(Time.deltaTime * towardsPlayer * speed);
      // towardsPlayer.z = 0;
      // Quaternion targetRotation = Quaternion.LookRotation(towardsPlayer);
      // transform.rotation = targetRotation;
      // transform.LookAt(player.transform); // testing
      
     } else
    {
      //  transform.Translate(Time.deltaTime * (-speed),0,0);
      transform.Translate(Time.deltaTime * (-speed),0,0);
    }

  }
}
