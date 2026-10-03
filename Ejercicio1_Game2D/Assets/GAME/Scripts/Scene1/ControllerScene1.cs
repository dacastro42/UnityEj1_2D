using UnityEngine;
using TMPro;
public class ControllerScene1 : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Timer timerScene1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + GameManager.Instance.Score;
        sendTime();
    }
    public void sendTime()
    {
        if(GameManager.Instance.Score >= 100)
        {
            timerScene1.TimerStop();
            float time = timerScene1.StopTime;
            GameManager.Instance.AddTime(time);
        }
    }
}
