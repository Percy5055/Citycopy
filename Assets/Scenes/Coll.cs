using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //Text相關的函數都存在UI的命名空間內，所以要添加這個

public class Coll : MonoBehaviour
{
		
    public static int score;
    public static int acc;
    public static int timei=0;
    public static float timef=0f;
                              
    public Text ShowScore;  
   
		//初始化
    void Start() {
        score=0;
    }

		//不斷更新分數
    
    void Update() {
        show();
        timef += Time.deltaTime;
        timei = (int)timef;
        Debug.Log(timei);
    }

    private void show(){
      if(timei == 1)
      {
        score=0;
      }
      acc = score / 2;
      ShowScore.text="accident:"+acc.ToString();
				//  ShowScore抓到的text物件.的text文字 = " ";
				// .ToString()可將int轉為string
    }
}