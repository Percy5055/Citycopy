using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarCollision : MonoBehaviour
{
	   //初始化
     void Start() {
				//建立碰撞器(變數的概念)
        BoxCollider bx; 
				//將這個腳本的物體碰撞器設給變數
        bx = gameObject.AddComponent<BoxCollider>() as BoxCollider;
     }

		//碰撞事件，只要this產生碰撞，就會引起這個事件
     void OnCollisionEnter(Collision co) //傳入碰撞對象，取名coll(可自訂)
    {
				//觸發條件
        if (co.gameObject.tag == "car") 
        {
            Coll.score++;       //Canvas這個class.的score全域變數
        }
        else if (co.gameObject.tag == "people") 
        {
            Destroy(co.gameObject); //碰壞此物件
            Coll.score++;       	           
        }

    }
}