using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Renderer _render1;

    private int num = 5;
    private void Start()
    {
        Debug.Log(" ֵΪ" + num);

        //_render1 = GetComponent<Renderer>();
        //if (_render1 == null)
        //    Debug.Log(_render1 + "  ��s");
        //else
        //    Debug.Log(_render1 + "  ����s");

        //GameObject.Destroy(_render1);




    }
    // Update is called once per frame
    void Update()
    {

        if (ReferenceEquals(_render1, null))
            Debug.Log(_render1 + "  ��");
        else
            Debug.Log(_render1 + "  ����");

    }



}
