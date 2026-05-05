using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{

  public float xLimit = 35.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.x < -xLimit)
    {
      Destroy(gameObject);
    }  
    }
}
