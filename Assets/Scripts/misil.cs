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
    if (player != null)
    {
    
      Vector3 towardsPlayer = (player.transform.position - transform.position).normalized;
      towardsPlayer.z = 0;
      transform.Translate(Time.deltaTime * towardsPlayer * speed, Space.World);
      transform.LookAt(player.transform);
     
    } 
    else
    {
       transform.Translate(Time.deltaTime * (-speed),0,0, Space.World);
    }
    }
}
