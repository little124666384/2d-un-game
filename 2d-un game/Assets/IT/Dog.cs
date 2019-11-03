using UnityEngine;

public class Dog : MonoBehaviour
{
    #region 欄位區塊
    ///欄位field (變數)
    ///欄位類型 欄位名稱 值(指定 值)無的話為0 結束打;
    ///修飾詞 類型 欄位名稱 值(指定 值) 結束
    ///private私人(不顯示)public公開(顯示)
    [Header("跳躍次數")][Range( 1, 10)]
    public int jumpCount = 2;                                ///int 整數類別
    [Header("跳躍高度")][Range( 1, 100)]
    public int jump = 100;
    [Header("移動速度")][Range( 0.01f, 10)]
    public float speed = 10.5f;                              ///float 浮點類別
    [Header("是否在地板上")][Tooltip("用來判斷角色是否在地板上")]
    public bool isGround;                                    ///bool  布林類別 值為開關true/flase
    [Header("角色名稱")]                                    ///public Transform dog, cam; 
    public string characterName = "Little";                 ///public Transform dog; 狗
    public Transform dog, cam;                              ///public Transform cam; 攝影機
                                                            ///這兩段的精寫

    /// 初始事件遊戲開始執行一次
   
    private void Start()                           
    {
        print("壓哈");
    }
    ///更新事件每桢執行一次
    private void Update()
    {
        print("哇哇");
        MoveDog();
        MoveCamear();
    }
    ///狗移動方法
    private void MoveDog()
    {                                                                               ///Translate()為移動控制指令
        dog.Translate(speed * Time.deltaTime, 0, 0);
    }
    ///Camear移動方法   
    private void MoveCamear()
    {
        cam.Translate(speed * Time.deltaTime, 0, 0);                                
    
    }

    /// 跳躍方法

    public void Jump()
    {
        print("跳躍");
    }
    ///滑行方法
    public void Slide()
    {
        print("滑行");

    }
    #endregion
}
