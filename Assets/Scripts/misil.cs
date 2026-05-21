using UnityEngine;

public class misil : Enemy
{
  public float speed = 10;
  GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) {
    
      Vector3 towardsPlayer = (player.transform.position - transform.position).normalized;
      print(towardsPlayer);
      towardsPlayer.z = 0;
      transform.Translate(Time.deltaTime * towardsPlayer * speed, Space.World);
      // transform.position = new Vector3(transform.position.x, transform.position.y, -4);

      transform.LookAt(player.transform);
      // towardsPlayer.z = 0;
      // Quaternion targetRotation = Quaternion.LookRotation(towardsPlayer);
      // transform.rotation = targetRotation;
      // transform.LookAt(player.transform); // testing
      
     } else
    {
       transform.Translate(Time.deltaTime * (-speed),0,0, Space.World);
    }
    }
}
