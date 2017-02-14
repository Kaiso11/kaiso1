using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

    //ゲームのメタ要素を管理する

    public Text start;//画面遷移時に表示。ゲーム開始で消去
    public Button menu;//メニューへの遷移で使用。
    public GameObject posemenu;//ポーズ中のメニューウィンドウ
    public Text playtime;
    
     
    private float time1 = 0;//ゲーム開始時からの時間を測る。ポーズ中は停止
    private bool playing = false;//ゲーム中かどうかを判定

    public void StartGame()
    {
        playing = true;
        posemenu.SetActive(false);
        menu.enabled = true;//メニューボタンを使用可能に
    }

    public void PoseGame() {//ポーズ&メニュー表示
        playing = false;
        menu.enabled = false;//メニューボタンの二重クリックを防ぐ
        posemenu.SetActive(true);
    }





    // Use this for initialization
    void Start()
    {
        start.text = "左クリックでゲーム開始";
    }


    // Update is called once per frame
    void Update () {
        playtime.text = "経過時間:" + time1;//ゲーム内での経過時間 
        if (Input.GetMouseButton(0)&&!start.text.Equals(""))
        {
            StartGame();//ゲーム開始
            start.text = "";
        }

        if (playing)
        {
            time1 += Time.deltaTime;//ゲーム内でのタイムを計る
        }
	}
}
