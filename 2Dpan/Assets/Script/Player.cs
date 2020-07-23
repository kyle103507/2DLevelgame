using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位區域
    [Header("速度"),Tooltip("角色的移動速度"),Range(10,500)]
    public float speed;
    [Header("血量")]
    public float hp;
    [Header("跳躍高度")]
    public float jamphight;
    [Header("破關層數"),Tooltip("角色往下幾層")]
    public int LV;
    [Header("碰撞音效")]
    public AudioClip audcol;
    [Header("跳躍音效")]
    public AudioClip audjump;
    [Header("是否死亡")]
    private bool dead;
    #endregion

    #region 方法區域
    
    /// <summary>
    ///角色的移動方式
    /// </summary>
    private void Move()
    {

    }
    
    /// <summary>
    /// 角色的跳躍:碰到彈簧跳躍、跳躍的音效、動畫
    /// </summary>
    private void Jump()
    {

    }

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

    }

    /// <summary>
    /// 角色死亡:離開畫面、動畫
    /// </summary>
    private void Dead()
    {

    }

    #endregion


}
