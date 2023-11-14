using UnityEngine;
using UnityEngine.Rendering;

public class FireSystem : MonoBehaviour
{
    #region ���
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
    [Header("�}�j�ʵe�Ѽ�")]
    public string parFire = "Ĳ�o�}�j";
    [Header("�ʵe���")]
    public Animator ani;
    [Header("���Ĩӷ�")]
    public AudioSource aud;
    [Header("�}�j����")]
    public AudioClip soundFire;
    #endregion


    //���K����줣��ı �ּ֥B�L�����C�������H��O_Q
    //public - �i������ܩ�Unity���O
    //int = ���
    //header�����D��r Range�b�ݩʭ��O���|��ܷƱ�

    /*public bool openDoor = true;
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
    */

    private void Update()
    {
        //print("<color=red>��s�ƥ�</color>");
        //�p�G ���a���U �ƹ�����
        //�N�ͦ��l�u

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger(parFire);
            //Ĳ�o�ʵe����uĲ�o�}�j�v�Ѽ�
            Instantiate(prefabBullet,pointSpawnBullet.position, pointSpawnBullet.rotation);
            //�ͦ��l�u�b �l�u�ͦ��I��m �H�Υͦ��I����

            float volume = Random.Range(0.8f, 3.2f);
            aud.PlayOneShot(soundFire, volume);
            //�H����

        }
    }
}