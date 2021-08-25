using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamModeHandler : MonoBehaviour
{   
    // 모드1 = 뷰모드, 모드2= 클릭모드
    private int mode = 1;

    // ctrl키로 모드 변경

    void change_Mode(){
        if(Input.GetKeyDown(KeyCode.LeftControl)){
            Debug.Log("Ctrl key was pressed");

            switch(mode){
                
                case 1:
                mode = 2;
                Debug.Log("Mode changed : click mode!(mode = " + mode + ")");
                break;

                case 2:
                mode = 1;
                Debug.Log("Mode changed : view mode!(mode = " + mode + ")");
                break;

                default:
                // 모드 강제변환
                //mode = 1;
                Debug.Log("Mode error!");
                break;
            }
        }
    }

    public int check_Mode(){
        return mode;
    }

    void Start()
    {
        // 뷰모드로 시작(초기화)
        mode = 1;
    }

    // Update is called once per frame
    void Update()
    {
        change_Mode();
        if(mode == 1){

        }
    }
}
