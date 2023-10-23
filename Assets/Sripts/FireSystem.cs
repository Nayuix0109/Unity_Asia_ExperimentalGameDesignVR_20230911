using UnityEngine;

public class FireSystem : MonoBehaviour
{
    [Header("�u�X���l�u�ƶq"), Range(0, 10)]
    public int magazineCount = 7;
    [Header("�l�u�`��"), Range(20, 200)]
    public int bulletTotal = 28;
    [Header("�ثe�l�u�ƶq"), Range(0, 10)]
    public int bulletCurrent = 7;
    [Header("�l�u�w�s��")]
    public GameObject prefabBullet;
    [Header("�l�u�ͦ��I")]
    public Transform pointSpawnBullet;

    //���K����줣��ı �ּ֥B�L�����C�������H��O_Q
    //public - �i������ܩ�Unity���O
    //int = ���
    //header�����D��r Range�b�ݩʭ��O���|��ܷƱ�

    public bool openDoor = true;
    public bool isDead = false;

    private void Awake()
    {
        //print("<color=green>����ƥ�</color>");
        Instantiate (prefabBullet);
    }

    private void Start()
    {
        //print("<color=yellow>�}�l�ƥ�</color>");
        //��p�A���������L�Ȭ�true(�Ŀ�)
        //�~�|����j�A�������{��

        if (openDoor) 
        {
            print("�w�g�}��");
        }

        if (isDead)
        {
            print("�w�g���`");
        }
    }

    private void Update()
    {
        //print("<color=red>��s�ƥ�</color>");
        //�p�G ���a���U �ƹ�����
        //�N�ͦ��l�u

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(prefabBullet);
        }
    }
}