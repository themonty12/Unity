using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public void Start()
    {
        //Vector3 vec = new Vector3(5, 0, 0); // 벡터 값
        //transform.Translate(vec);

        //int number = 4; // 스칼라 값
        
    }

    public void Update()
    {
        // 키 입력 받아 이동.
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"),
                                  Input.GetAxis("Vertical"),
                                  0);
        transform.Translate(vec);

        //if (Input.anyKeyDown)
        //{
        //    Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        //}

        // 버튼
        //if (Input.GetButton("Horizontal"))
        //{
        //    //Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal")); // Return Float
        //    Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal")); // Return -1, 0, 1
        //    Vector3 vec = new Vector3(Input.GetAxisRaw(("Horizontal")), 0, 0);
        //    transform.Translate(vec);
        //}

        //if (Input.GetButton("Vertical"))
        //{
        //    //Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal")); // Return Float
        //    Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical")); // Return -1, 0, 1
        //    Vector3 vec = new Vector3(0, Input.GetAxisRaw(("Vertical")), 0);
        //    transform.Translate(vec);
        //}

        //if (Input.GetButtonDown("Horizontal"))
        //    Debug.Log("점프!");

        //if (Input.GetButton("Horizontal"))
        //    Debug.Log("점프 모으는 중...");

        //if (Input.GetButtonUp("Jump"))
        //    Debug.Log("슈퍼 점프!!");

        // 키보드
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    Debug.Log("아이템을 구입하였습니다.");
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Debug.Log("왼쪽으로 이동 중");
        //}

        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    Debug.Log("오른쪽 이동을 멈추었습니다.");
        //}

        // 마우스 관련 
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("미사일 발사!");
        //}

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("미사일 모으는 중...");
        //}

        //if (Input.GetMouseButtonUp(0))
        //{
        //    Debug.Log("슈퍼 미사일 발사!!");
        //}
    }
}
