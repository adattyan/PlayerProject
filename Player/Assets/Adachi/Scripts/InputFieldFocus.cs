using UnityEngine;
using UnityEngine.UI;

public class InputFieldFocus : MonoBehaviour
{
    void Start()
    {
        InputField i = this.GetComponent<InputField>();
        i.ActivateInputField(); //InputField�Ƀt�H�[�J�X����������
        i.onEndEdit.AddListener(
            delegate (string text) {
                if (!string.IsNullOrEmpty(text))
                {
                    Debug.Log(text);    //text�̑����
                    i.text = "";
                }
                i.ActivateInputField(); //InputField�Ƀt�H�[�J�X����������
            }
        );
        //4.6x�ł͂��̏������Ȃ���Enter����������AInputField�ɉ��s�������Ă��܂�(Single Line�ݒ�ł�)
        //5.2x�ł͗v��Ȃ��̂ŃR�����g�A�E�g
        //		i.onValidateInput += delegate(string _1, int _2, char c) { return c == '\n' ? '\0' : c; };
    }
}
