using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Declare global variables
    public bool gameover = false;
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 25;
    private float topY = 12;
    private float lowerY = -12;
    public float speed = 10f;

    public BulletType1 bulletPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     // set up movement with arrow keys and keys for shooting and powerups   
      horizontalInput = Input.GetAxis("Horizontal");
      verticalInput = Input.GetAxis("Vertical");

      transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);
      transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);

    //Bounds controlls
  {
    if (transform.position.x < -xRange)
    {
      transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }

    if (transform.position.x > xRange)
    {
      transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }

    if (transform.position.y < lowerY)
    {
      transform.position = new Vector3(transform.position.x, lowerY, transform.position.z);
    }

    if (transform.position.y > topY)
    {
      transform.position = new Vector3(transform.position.x,topY,transform.position.z);
    }
  }

      if (Input.GetKeyDown(KeyCode.K) && ! gameover )
    {
      Instantiate(bulletPrefabs, transform.position, bulletPrefabs.transform.rotation);
    }

      if (Input.GetKeyDown(KeyCode.L) && ! gameover )
    {
      // powerup
    }
    }



  // Collision behaviour code with a method
  void OnCollisionEnter(Collision collision)
  {
    
  }


  //
}
