using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCount : MonoBehaviour
{
    [SerializeField] float time = 60;   //����
    [SerializeField] GameObject TimerObject;  //�Q�[���I�u�W�F�N�g
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
    /// �����ݒ�
    /// </summary>
    void StartUp()
    {
        TimerObject = GetComponent<GameObject>();
        timertext = TimerObject.GetComponent<Text>();
    }

    /// <summary>
    /// ���Ԃ��v��
    /// </summary>
    void Count()
    {
        time -= Time.deltaTime;
        timertext.text = "����" + time.ToString("00.00") + "�b";
        
    }
}
