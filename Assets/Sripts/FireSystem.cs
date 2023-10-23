using UnityEngine;

public class FireSystem : MonoBehaviour
{
    [Header("彈匣的子彈數量"), Range(0, 10)]
    public int magazineCount = 7;
    [Header("子彈總數"), Range(20, 200)]
    public int bulletTotal = 28;
    [Header("目前子彈數量"), Range(0, 10)]
    public int bulletCurrent = 7;
    [Header("子彈預製物")]
    public GameObject prefabBullet;
    [Header("子彈生成點")]
    public Transform pointSpawnBullet;

    //早八不遲到不睡覺 快樂且無情的遊戲引擎人生O_Q
    //public - 可讓它顯示於Unity面板
    //int = 整數
    //header為標題文字 Range在屬性面板中會顯示滑桿

    public bool openDoor = true;
    public bool isDead = false;

    private void Awake()
    {
        //print("<color=green>喚醒事件</color>");
        Instantiate (prefabBullet);
    }

    private void Start()
    {
        //print("<color=yellow>開始事件</color>");
        //當小括號內的布林值為true(勾選)
        //才會執行大括號內的程式

        if (openDoor) 
        {
            print("已經開門");
        }

        if (isDead)
        {
            print("已經死亡");
        }
    }

    private void Update()
    {
        //print("<color=red>更新事件</color>");
        //如果 玩家按下 滑鼠左鍵
        //就生成子彈

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(prefabBullet);
        }
    }
}