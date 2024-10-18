using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCount : MonoBehaviour
{
    [SerializeField] float time = 60;   //時間
    [SerializeField] GameObject Timer;  //ゲームオブジェクトとしてのtimer
    Text timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Count();
    }

    /// <summary>
    /// 時間を計測
    /// </summary>
    void Count()
    {
        time -= Time.deltaTime;
        timer.text = "残り秒";
    }
}
