using UnityEngine;

public class HW : MonoBehaviour
{
[Header("速度") , Range(1f,1000f) , Tooltip("速度快慢") ]
 public float speed = 1f;
 [Header("跳躍高度") , Range(0,10000) , Tooltip("跳多高") ]
 public float Jump= 100;
 [Header("對話內容") , Tooltip("聊天內容") ]
 public string Talk =("咕咕咕~~");
 [Header("是否取得雞蛋") , Tooltip("判斷是否取得雞蛋") ]
 public bool Egg;


 private void Start()
    {
        print("遊戲開始");
    }


    private void Update()
    {
        print("咕咕咕~~");
    }
}
