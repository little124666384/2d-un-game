using UnityEngine;

public class Dog : MonoBehaviour
{
    #region 欄位區塊
    ///欄位field (變數)
    ///欄位類型 欄位名稱 值(指定 值)無的話為0 結束打;
    ///修飾詞 類型 欄位名稱 值(指定 值) 結束
    ///private私人(不顯示)public公開(顯示)
    [Header("跳躍次數")] [Range(1, 10)]
    public int jumpCount = 2;                                ///int 整數類別
    [Header("跳躍高度")] [Range(1, 1000)]
    public int jump = 500;
    [Header("移動速度")] [Range(0.01f, 10)]
    public float speed = 6.5f;                              ///float 浮點類別
    [Header("是否在地板上")] [Tooltip("用來判斷角色是否在地板上")]
    public bool isGround;                                    ///bool  布林類別 值為開關true/flase
    [Header("角色名稱")]                                    ///public Transform dog, cam; 
    public string characterName = "Little";                 ///public Transform dog; 狗
    public AudioClip soundjump, soundSlide;

    private Transform cam;                              ///public Transform cam; 攝影機///這兩段的精寫
    private Animator Anim;                                   ///動畫控制器                    
    private CapsuleCollider2D CC2D;
    private Rigidbody2D r2d;                                //跳耀控制代碼001
    private AudioSource Aud;
                               //圖片渲染
    #endregion

    #region 事件

    /// 初始事件:遊戲開始執行一次
    private void Start()
    {
        // print("開始");
        //GetComponent<T>泛型方法<T>
        Anim = GetComponent<Animator>();
        CC2D = GetComponent<CapsuleCollider2D>();
        r2d = GetComponent<Rigidbody2D>();
        cam = GameObject.Find("Main Camera").transform;
        Aud = GetComponent<AudioSource>();


    }
    ///更新事件:每桢執行一次
    private void Update()
    {
        print("持續開始");
        MoveDog();
        MoveCamear();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //小刮弧的布林值為true事會執行{}內的描述
        if (collision.gameObject.name == "地板")
        {
            isGround = true;

        }
    }
    /// <summary>
    /// 碰撞事件:當物見碰撞開始實執行一次
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        if (collision.name == "障礙物")
        {
            Damamg();
        }
        
    }
    
    #endregion

    #region 方法
    /// <summary>
    /// 角色受傷
    /// </summary>
    private void Damamg()
    {
        Debug.Log("受傷");
        
    }



    /// <summary>
    /// 狗移動方法
    /// </summary>
    private void MoveDog()
    {                                                                               ///Translate()為移動控制指令
        //dog.Translate(speed * Time.deltaTime, 0, 0);
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    /// <summary>
    /// Camear移動方法
    /// </summary>
    private void MoveCamear()
    {
        cam.Translate(speed * Time.deltaTime, 0, 0);                                
    
    }
    /// <summary>
    /// 跳躍方法
    /// </summary>
    public void Jump()
    {
        //如果在地板上布林值=勾選
        if (isGround==true)
        {
          print("跳要");
          Anim.SetBool("跳要開關", true);
          r2d.AddForce(new Vector2(0,jump));           //跳耀控制代碼001
            isGround = false;                          //地板布林值=地板
            Aud.PlayOneShot(soundjump);
        }
    }
    /// <summary>
    /// 滑行方法,縮小設定碰撞器
    /// </summary>
    public void Slide()
    {
        print("滑行");
        Anim.SetBool("滑行開關", true);
        CC2D.offset=new Vector2(-0.1f, -1.044564f);
        CC2D.size = new Vector2(0.95f, 1.84102f);
        Aud.PlayOneShot(soundSlide,10);
    }
    /// <summary>
    /// 重設定跳耀與滑行布林值,從新設定碰撞器
    /// </summary>
    public void ReseatAnimator()
    {
        Anim.SetBool("跳要開關", false);
        Anim.SetBool("滑行開關", false);
        CC2D.offset = new Vector2(0, -1.044564f);
        CC2D.size = new Vector2(1.395193f, 1.84102f);

    }
    #endregion
}
 