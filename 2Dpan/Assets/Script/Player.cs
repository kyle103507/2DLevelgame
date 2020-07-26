using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    #region 欄位區域
    [Header("速度"), Tooltip("角色的移動速度"), Range(0, 500)]
    public float speed = 50;
    [Header("血量")]
    public float hp = 99.9f;
    [Header("跳躍高度")]
    public float jamphight = 500;
    [Header("破關層數"), Tooltip("角色往下幾層")]
    public int LV;
    [Header("碰撞音效")]
    public AudioClip audcol;
    [Header("跳躍音效")]
    public AudioClip audjump;
    [Header("是否死亡")]
    private bool dead;
    [Header("剛體")]
    public Rigidbody2D rig;

    Vector2 movement;
    [Header("動畫控制器")]
    public Animator ani;
    [Header("血條")]
    public Image imgHP;
    [Header("血最大值")]
    private float hpMax;
    [Header("結束畫面")]
    public GameObject final;
    [Header("標題")]
    public Text textTitle;

    #endregion

    #region 方法區域

    /// <summary>
    ///角色的移動方式
    /// </summary>
    private void Move()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    /// <summary>
    /// 角色的跳躍:碰到彈簧跳躍、跳躍的音效、動畫
    /// </summary>
    private void Jump()
    {
        ani.SetBool("跳躍開關",true);
        
    }

    /// <summary>
    /// 腳色短暫停留: 碰到地板翻轉
    /// </summary>
   

    /// <summary>
    /// 回復血量:碰撞地板回復、碰撞音效
    /// </summary>
    private void Reply()
    {
        
    }

    /// <summary>
    /// 角色受傷:碰到陷阱、受傷音效、動畫
    /// </summary>
    private void Hit()
    {
        hp -= 50;                               //血量遞減50
        imgHP.fillAmount = hp / hpMax;          //血條.填滿長度 = 血量 / 血量最大值

        if (hp < 0) Dead();                     //死亡觸發
        
    }

    /// <summary>
    /// 角色死亡:離開畫面、動畫
    /// </summary>
    private void Dead()
    {
        if (dead) return;                           //如果死亡就跳出
        
        speed = 0;
        ani.SetTrigger("死亡觸發");               //觸發死亡動畫
        final.SetActive(true);                      //結束畫面.啟動設定

    }

    /// <summary>
    /// 過關
    /// </summary>
    private void Pass()
    {
        final.SetActive(true);
        textTitle.text = "恭喜你獲勝";
    }

    #endregion

    #region 事件區域


    private void Start()
    {
        hpMax = hp;
    }
    private void Update()
    {
        Move();
      
    }

    private void FixedUpdate()
    {
        if (dead) return;

        rig.MovePosition(rig.position + movement * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "障礙物")
        {
            Hit();
        }

        if (collision.name == "傳送門")
        {
            Pass();
        }
        
    }

    #endregion
}
