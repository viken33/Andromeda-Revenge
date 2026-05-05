using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public float spawnInterval;
    private float initialTime;
    public float spawnRange = 12.0f;
    public GameObject[] enemyPrefabs;
    public GameObject[] obstaclePrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
      spawnInterval = Random.Range(2f, 4f);
     if (Time.time > initialTime + spawnInterval)
    {
      SpawnEnemy();
      SpawnObstacle();
      initialTime = Time.time;
    }
    }
    void SpawnObstacle()
  {
      //random scale
      float randomScale = Random.Range(0.4f,1f);
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
      // float spawnPosZ = Random.Range(-spawnRange, spawnRange);
      Vector3 randomPos = new Vector3(25, spawnPosY, -4);
      return randomPos;
  }
}
