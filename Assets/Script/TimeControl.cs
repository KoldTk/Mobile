using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    [SerializeField] private Text time;
    public float timeCount;
    private float timePlay;
    public HealtBar player1;
    public HealthBar2 player2;
    // Start is called before the first frame update
    void Start()
    {
        timePlay = 90;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            TimePlay();
        }
        if (player1.isDead || player2.isDead)
        {
            End();
        }
    }

    void TimePlay()
    {
        timePlay -= Time.deltaTime;
        timePlay = Mathf.Clamp(timePlay, 0 , 90);
        time.text = $"{(int)timePlay}";
    }
    void End()
    {
        timeCount += Time.deltaTime;
        if (timeCount > 3)
        {
            Time.timeScale = 0;
        }
    }
}
