using System.Linq.Expressions;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

  float aliveTimer = 5.0f;
  private Transform target;
  public float speed = 3.0f;
  Vector3 moveDirection;

  void Start()
  {
    try
    {
      target = GameObject.FindWithTag("Player").transform;
      moveDirection = (target.position - transform.position).normalized;
    }
    catch
    {
      throw new System.Exception("no player found");
    }
  }

  // Update is called once per frame
  void Update()
  {
    transform.position += moveDirection * speed * Time.deltaTime;


  }

  public void Fire(Transform newTarget)
  {
    if (target != null)
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
      other.GetComponent<PlayerController>().Die();
      Destroy(gameObject);
    }
  }
}
