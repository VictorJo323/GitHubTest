using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake() // 시작할 때! 초기화
    {
        Debug.Log("초기화 1");
    }
    
    private void Start()  //Awake 이후! 초기화
    {
        Debug.Log("초기화 2");
    }

    // Update is called once per frame.

    private void FixedUpdate()   // 물리연산 이후 - RigidBody관련일 때는 이쪽이 좋음. 그때만 호출하는 이벤트. 물리연산이 있다면, 먼저 진행 후 Update로 넘어감.
    {

    }

    private void Update()   // 매 프레임 호출. 포지션?
    {
        
    }


    private void LateUpdate()   // 모든 업데이트가 다 끝난 후! - 시간, 계산
    {
        
    }

    private void OnEnable()    
    {
        //해당 오브젝트가 켜졌을 때!
        Debug.Log("켜짐");
    }

    private void OnDisable()
    {
        //해당 오브젝트가 꺼졌을 때!
        Debug.Log("꺼짐");
    }


    float f;  // 선언
    int i = 0; // 선언+할당 (초기화)
    f = 2;  // 클래스 내에서는 '할당만'은 불가!
}
