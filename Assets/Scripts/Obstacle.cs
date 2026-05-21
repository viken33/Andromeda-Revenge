using UnityEngine;

public class Obstacle : MonoBehaviour
{

  public float xSpeed = -5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    transform.Translate(Time.deltaTime * xSpeed , 0 , 0);

    }

  void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      other.GetComponent<PlayerController>().Die();
    }
  }
}


