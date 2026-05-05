using UnityEngine;

public class EnemyType3 : MonoBehaviour
{

  public float speed = 5;
  GameObject player;
  Rigidbody enemyRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      player = GameObject.Find("Player");
      // enemyRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     // Moves towards the player
     if (player != null) {
      Vector3 towardsPlayer = (player.transform.position - transform.position).normalized;
      // enemyRb.AddForce(towardsPlayer * speed * Time.deltaTime)  ;
      transform.Translate(Time.deltaTime * towardsPlayer * speed);
     } else
    {
      // enemyRb.AddForce(Vector3.left);
       transform.Translate(Time.deltaTime * (-speed),0,0);
    }

     // Shoots EnemyBullets at the player   
    }
}
