using UnityEngine;

public class BulletType1 : MonoBehaviour
{

  public float bulletSpeed = 8.0f;
  
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector3.down*bulletSpeed);  


      if (transform.position.x > 30){Destroy(gameObject);}
    }

  void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Enemy"))
    {
      Destroy(other.gameObject);
      Destroy(gameObject);
    }
  }
}
