using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int score = 0;
    private float totalTime = 0f;
    public int Score { get => score; set => score = value; }
    public float TotalTime { get => totalTime; set => totalTime = value; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }

    public void AddTime(float amount)
    {
        totalTime += amount;
        Debug.Log("Total Time: " + totalTime);
    }
}
