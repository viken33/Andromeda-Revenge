using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class GameManager : MonoBehaviour
{

  public static GameManager Instance;
    
    public bool gameover = false;
    public int currentLevel;
    public int levelOneDuration = 30;
    public float gameTime;
    private void Awake()
  {

    if (Instance != null)
    {
      Destroy(gameObject);
      return;
    }
    Instance = this;
    DontDestroyOnLoad(gameObject);

    gameTime = levelOneDuration;
  }

  private void Update()
  {
    if (currentLevel == 1){
    gameTime -= Time.deltaTime;
    // print(gameTime);
    }
  }  

    public void StartGame()
  {
    SceneManager.LoadScene(1);
    gameover = false;
    currentLevel = 1;
  }

  public void QuitGame()
  {
     #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
  }
}
