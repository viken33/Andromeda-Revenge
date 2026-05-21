using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public float spawnInterval;
    private float initialTime;
    public float spawnRange = 12.0f;
    public GameObject[] enemyPrefabs;
    public GameObject[] obstaclePrefabs;
    public GameObject boss;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
      if (GameManager.Instance.gameTime > 0) {
        spawnInterval = Random.Range(2f, 4f);
     if (Time.time > initialTime + spawnInterval)
    {
      SpawnEnemy();
      SpawnObstacle();
      initialTime = Time.time;
    }
    }
    // we reach the end of the level, setting the level boss active
    if (boss != null && GameManager.Instance.gameTime < -10){ boss.SetActive(true); }
   
    
    }
    void SpawnObstacle()
  {
      //random scale
      float randomScale = Random.Range(0.2f,0.6f);
      int randomObstacle = Random.Range(0, obstaclePrefabs.Length);
     
      GameObject obs = Instantiate(obstaclePrefabs[randomObstacle], RandomSpawnLocation(), obstaclePrefabs[randomObstacle].transform.rotation);
      obs.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
      obs.transform.localEulerAngles = new Vector3(Random.Range(0,360),0,0);
  }
    void SpawnEnemy()
  {
      int randomEnemy = Random.Range(0, enemyPrefabs.Length);
      Instantiate(enemyPrefabs[randomEnemy], RandomSpawnLocation(), enemyPrefabs[randomEnemy].transform.rotation);
    
  }

    Vector3 RandomSpawnLocation()
  {
      float spawnPosY = Random.Range(-spawnRange, spawnRange);
      Vector3 randomPos = new Vector3(25, spawnPosY, -4);
      return randomPos;
  }
}
