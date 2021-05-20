using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{

    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); // Rigidbody ��������
        //rigid.velocity = Vector3.right; // �ӷ� ����
        //rigid.velocity = new Vector3(2, 4, 3);
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse); // AddForce(Vec) : Vec�� ����� ũ��� ���� �� FoorceMode : ���� �ִ� ��� (����, ���� �ݿ�)
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    // RigidBody ���� �ڵ�� FIxedUpdate�� �ۼ�
    void FixedUpdate()
    {
        //rigid.velocity = new Vector3(2, 4, 3);
        //if (Input.GetButtonDown("Jump"))
        //{
        //    rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        //    Debug.Log(rigid.velocity);

        //}

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * 5, 0, Input.GetAxisRaw("Vertical") * 5);

        rigid.AddForce(vec, ForceMode.Impulse);

        // 3. ȸ����
        // AddTorque(Vec) : Vec ������ ������ ȸ������ ����.
        //rigid.AddTorque(Vector3.up);
    }
}
