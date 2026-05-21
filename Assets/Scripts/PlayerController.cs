using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Declare global variables
    // public bool gameover = false;
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 25;
    private float topY = 12;
    private float lowerY = -12;
    public float speed = 10f;
    public ParticleSystem explosionPrefab;
    private AudioSource audioS;
    // public AudioSource bulletSound;
    public AudioSource deathSound;
    public AudioClip bulletSound;
    private Vector3 movementVector;
    public BulletType1 bulletPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioS = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
     // set up movement with arrow keys and keys for shooting and powerups   
      horizontalInput = Input.GetAxis("Horizontal");
      verticalInput = Input.GetAxis("Vertical");
      movementVector = new Vector3(horizontalInput, verticalInput, 0).normalized;

      transform.Translate(movementVector * Time.deltaTime * speed, Space.World);
      

    //Boundaries controls
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

      if (Input.GetKeyDown(KeyCode.K) && ! GameManager.Instance.gameover )
    {
      Instantiate(bulletPrefabs, transform.position, bulletPrefabs.transform.rotation);
      audioS.PlayOneShot(bulletSound);
    }
      if (Input.GetButtonDown("Fire1") && ! GameManager.Instance.gameover )
    {
      Instantiate(bulletPrefabs, transform.position, bulletPrefabs.transform.rotation);
      audioS.PlayOneShot(bulletSound);
    }

      if (Input.GetKeyDown(KeyCode.L) && ! GameManager.Instance.gameover )
    {
      // powerup
    }
    }



  // Collision behaviour code with a method
  void OnCollisionEnter(Collision collision)
  {
    
  }

  public void Die()
  {
    Instantiate(explosionPrefab, transform.position, transform.rotation);
    Instantiate(deathSound);
    Destroy(gameObject);
    GameManager.Instance.gameover = true;
  }

  //
}
