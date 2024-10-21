using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCount : MonoBehaviour
{
    [SerializeField] float time = 60;   //時間
    [SerializeField] GameObject TimerObject;  //ゲームオブジェクト
    Text timertext;
    // Start is called before the first frame update
    void Start()
    {
        StartUp();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(TimerObject);
        Debug.Log(timertext);
        Count();
    }

    /// <summary>
    /// 初期設定
    /// </summary>
    void StartUp()
    {
        TimerObject = GetComponent<GameObject>();
        timertext = TimerObject.GetComponent<Text>();
    }

    /// <summary>
    /// 時間を計測
    /// </summary>
    void Count()
    {
        time -= Time.deltaTime;
        timertext.text = "あと" + time.ToString("00.00") + "秒";
        
    }
}
