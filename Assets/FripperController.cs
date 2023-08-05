using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{

    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    //�����̌X��
    private float defaultAngle = 20.0f;

    //�e�������̌X��
    private float flickAngle = -20.0f;


    // Start is called before the first frame update
    void Start()
    {
        //HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {

        //�`�L�[�܂��͍����L�[�������������t���b�p�[�𓮂���
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //�c�L�[�܂��͉E���L�[�����������E�t���b�p�[�𓮂���
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //�r�L�[�܂��͉����L�[�����������ɗ����̃t���b�p�[�𓮂����B
        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)))
        {
            SetAngle(this.flickAngle);
        }

        //��L�L�[�𗣂������t���b�p�[�����ɖ߂�
        if ((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow)) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if ((Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow)) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if ((Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow)))
        {
            SetAngle(this.defaultAngle);
        }

    }

    //�t���b�p�[�̌X����ݒ�
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }

}
