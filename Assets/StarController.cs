using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    //��]���x

    private float rotSpeed = 0.5f;

    void Start()
    {
        //��]���J�n����p�x��ݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    void Update()
    {

        //��]
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}
