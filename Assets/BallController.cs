using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //課題ここから
    //スコアを加算するテキスト
    private int score = 0;

    //スコアを表示するテキスト
    private GameObject scoreText;

    //ボールがあたったtag情報
    private string gameObjectTagName;
    //課題ここまで


    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;


    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {

        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameOverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over...";

        }
    }

    //衝突時に呼ばれる関数
    private void OnCollisionEnter(Collision other)
    {
        gameObjectTagName = other.gameObject.tag;

        //ターゲットに衝突した際にスコアを加算
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
