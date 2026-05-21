using UnityEngine;

public class Enemy : MonoBehaviour
{

    protected virtual void  Move(){}

    protected void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      other.GetComponent<PlayerController>().Die();
    }
  }
  
}
