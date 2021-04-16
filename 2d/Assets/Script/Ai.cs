using UnityEngine;
public class Ai : MonoBehaviour
{
    [Header("追蹤範圍"), Range(0, 8)]
    public float rangeTrack = 2;
    [Header("攻擊範圍"), Range(0, 5)]
    public float rangeAtt = 1;
    private Transform player;
    public float speed = 5;
    private void Start()
    {
        //搜尋玩家座標並取得物件(物件名稱).變形
        player = GameObject.Find("主角").transform;
    }
    
    //繪製圖示事件:輔助開發
    private void OnDrawGizmos()
    {   
        //繪製顏色
        Gizmos.color = new Color(0, 0, 3, 0.35f);
        //繪製形狀(中心點,半徑)
        Gizmos.DrawSphere(transform.position, rangeTrack);
        //繪製顏色
        Gizmos.color = new Color(1, 0, 0, 0.35f);
        //繪製形狀(中心點,半徑)
        Gizmos.DrawSphere(transform.position, rangeAtt);
    }
    private void Update()
    {
        Track();
    }
    /// <summary>
    /// 追蹤玩家
    /// </summary>
    private void Track()
    {
                    //距離=三維向量的距離(a,b)
        float tra = Vector3.Distance(transform.position, player.position);
        //如果(距離小於等於追蹤範圍)才開始追蹤
        if(tra <= rangeTrack)
        {
            //物件座標 更新為 三維向量 的往前移動 (物件座標,目標座標,速度*一禎的時間)
            transform.position=Vector3.MoveTowards(transform.position,player.position, speed*Time.deltaTime);
        }
    }
}
