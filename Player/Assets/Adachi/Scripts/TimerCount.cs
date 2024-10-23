using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCount : MonoBehaviour
{
    [SerializeField] float time = 60;   //タイマー
    [SerializeField] GameObject TimerObject;  //タイマーオブジェクト
    Text timertext;
    // Start is called before the first frame update
    void Start()
    {
        StartUp();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Count();
    }

    /// <summary>
    /// 初期設定
    /// </summary>
    void StartUp()
    {
        timertext = TimerObject.GetComponent<Text>();
    }

    /// <summary>
    /// 時間を計測
    /// </summary>
    void Count()
    {
        if(time <= 60)
        {
            time -= Time.deltaTime;
            timertext.text = "残り" + time.ToString("00.00") + "秒";
        }
        if(time < 0)
        {
            time = 0;
            timertext.text = "終了！";
        }
    }
}
