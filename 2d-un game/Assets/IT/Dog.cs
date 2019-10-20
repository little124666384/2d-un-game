using UnityEngine;

public class Dog : MonoBehaviour
{
    #region 欄位區塊
    //欄位field (變數)
    //欄位類型 欄位名稱 值(指定 值)無的話為0 結束打;
    //修飾詞 類型 欄位名稱 值(指定 值) 結束
    //private私人(不顯示)public公開(顯示)
    [Header("跳躍次數")][Range( 1, 10)]
    public int jumbCount = 2;  //int 整數類別
    [Header("跳躍高度")][Range( 1, 100)]
    public int jumb = 100;
    [Header("移動速度")][Range( 0.01f, 10)]
    public float speed = 10.5f;//float 浮點類別
    [Header("是否在地板上")][Tooltip("用來判斷角色是否在地板上")]
    public bool isGround;      //bool  布林類別 值為開關true/flase
    [Header("角色名稱")]
    public string characterName = "Little";
    public Transform dog, cam; //public Transform dog; 狗

    //public Transform cam; 攝影機
    //這兩段的精寫
    private void Start()
    {
        print("壓哈");
    }
    private void Update()
    {
        print("哇哇");
    }
    #endregion
}
