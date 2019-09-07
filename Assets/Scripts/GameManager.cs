using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Idle,Pause,Play,GameOver
}
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState gameState;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        gameState = GameState.Idle;
    }

    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Tags.GamePlay);
        if (UIManager.instance.GameOverPanel.activeInHierarchy)
            UIManager.instance.SetGameObjectStatus(UIManager.instance.GameOverPanel, false);
    }


    IEnumerator Restart_CO(float delay)
    {
        yield return new WaitForSeconds(delay);
        UnityEngine.SceneManagement.SceneManager.LoadScene(Tags.GamePlay);
    }

    public void PlayGame()
    {
        StartCoroutine(Restart_CO(0.2f));
    }
} // class































