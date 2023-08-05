using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�ۑ肱������
    //�X�R�A�����Z����e�L�X�g
    private int score = 0;

    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;

    //�{�[������������tag���
    private string gameObjectTagName;
    //�ۑ肱���܂�


    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;


    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {

        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameOverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over...";

        }
    }

    //�Փˎ��ɌĂ΂��֐�
    private void OnCollisionEnter(Collision other)
    {
        gameObjectTagName = other.gameObject.tag;

        //�^�[�Q�b�g�ɏՓ˂����ۂɃX�R�A�����Z
        switch (gameObjectTagName)
        {
            case "SmallStarTag":
                score = score + 1;
                break;
            case "LargeStarTag":
                score = score + 10;
                break;
            case "SmallCloudTag":
                score = score + 100;
                break;
            case "LargeCloudTag":
                score = score + 1000;
                break;
        }
        this.scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}
