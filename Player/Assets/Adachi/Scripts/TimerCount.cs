using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCount : MonoBehaviour
{
    [SerializeField] float time = 60;   //����
    [SerializeField] GameObject Timer;  //�Q�[���I�u�W�F�N�g�Ƃ��Ă�timer
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
    /// ���Ԃ��v��
    /// </summary>
    void Count()
    {
        time -= Time.deltaTime;
        timer.text = "�c��b";
    }
}
