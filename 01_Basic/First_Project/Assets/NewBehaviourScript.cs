using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public void Start()
    {
        //Vector3 vec = new Vector3(5, 0, 0); // ���� ��
        //transform.Translate(vec);

        //int number = 4; // ��Į�� ��
        
    }

    public void Update()
    {
        // Ű �Է� �޾� �̵�.
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"),
                                  Input.GetAxis("Vertical"),
                                  0);
        transform.Translate(vec);

        //if (Input.anyKeyDown)
        //{
        //    Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        //}

        // ��ư
        //if (Input.GetButton("Horizontal"))
        //{
        //    //Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal")); // Return Float
        //    Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal")); // Return -1, 0, 1
        //    Vector3 vec = new Vector3(Input.GetAxisRaw(("Horizontal")), 0, 0);
        //    transform.Translate(vec);
        //}

        //if (Input.GetButton("Vertical"))
        //{
        //    //Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal")); // Return Float
        //    Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical")); // Return -1, 0, 1
        //    Vector3 vec = new Vector3(0, Input.GetAxisRaw(("Vertical")), 0);
        //    transform.Translate(vec);
        //}

        //if (Input.GetButtonDown("Horizontal"))
        //    Debug.Log("����!");

        //if (Input.GetButton("Horizontal"))
        //    Debug.Log("���� ������ ��...");

        //if (Input.GetButtonUp("Jump"))
        //    Debug.Log("���� ����!!");

        // Ű����
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    Debug.Log("�������� �����Ͽ����ϴ�.");
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Debug.Log("�������� �̵� ��");
        //}

        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    Debug.Log("������ �̵��� ���߾����ϴ�.");
        //}

        // ���콺 ���� 
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("�̻��� �߻�!");
        //}

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("�̻��� ������ ��...");
        //}

        //if (Input.GetMouseButtonUp(0))
        //{
        //    Debug.Log("���� �̻��� �߻�!!");
        //}
    }
}
