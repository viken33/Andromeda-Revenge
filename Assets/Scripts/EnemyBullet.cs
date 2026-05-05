using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

  float aliveTimer=5.0f;
  private Transform target;
  public float speed = 3.0f;
  Vector3 moveDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      target = GameObject.FindWithTag("Player").transform;
      moveDirection = (target.position - transform.position).normalized;
        
    }

    // Update is called once per frame
    void Update()
  {
      transform.position += moveDirection * speed * Time.deltaTime;
      
    
  }

    public void Fire(Transform newTarget)
  {
        if(target != null)
      {
      target = newTarget;
      Debug.Log("Target not null");
      transform.LookAt(target);
      
      } 
    Destroy(gameObject, aliveTimer);
  }

  void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      Destroy(other.gameObject);
    }
  }
}
