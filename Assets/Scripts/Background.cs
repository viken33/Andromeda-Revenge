using UnityEngine;

public class Background : MonoBehaviour
{

  public float xSpeed = -5f;
  private float initialX;
  public float offset1, offset2;
  public float size;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialX = transform.position.x;
        // TODO: measure the size properly
        // size = GetComponent<Renderer>().bounds.size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Time.deltaTime * xSpeed , 0 , 0);
      if (transform.position.x <= initialX - (size))
    {
      transform.position = new Vector3(initialX,0,0);
      // initialX = transform.position.x;
    }
    }
}
