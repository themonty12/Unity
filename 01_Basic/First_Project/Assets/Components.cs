using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{

    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); // Rigidbody 가져오기
        //rigid.velocity = Vector3.right; // 속력 적용
        //rigid.velocity = new Vector3(2, 4, 3);
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse); // AddForce(Vec) : Vec의 방향과 크기로 힘을 줌 FoorceMode : 힘을 주는 방식 (가속, 무게 반영)
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    // RigidBody 관련 코드는 FIxedUpdate에 작성
    void FixedUpdate()
    {
        //rigid.velocity = new Vector3(2, 4, 3);
        //if (Input.GetButtonDown("Jump"))
        //{
        //    rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        //    Debug.Log(rigid.velocity);

        //}

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);

        // 3. 회전력
        // AddTorque(Vec) : Vec 방향을 축으로 회전력이 생김.
        //rigid.AddTorque(Vector3.up);
    }

    // 콜라이더가 계속 충돌하고 있을 때 호출
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
        {
            Debug.Log("경고");
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
            
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
