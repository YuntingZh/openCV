using UnityEngine;
using System.Collections;

public class appearFruits : MonoBehaviour
{
    public GameObject[] fruits;           //ˮ��Ԥ�ƶ�������            
    //public GameObject clone;
    private static float interval;       //clone time
    private float time;

    public float speed = 5.0f;
    public float lastSpeed;

    void Start()
    {
        interval = 0.9f;
        // InvokeRepeating("Create", interval, interval);         //�ظ���intervalʱ�����һ��ˮ��
        InvokeRepeating("Create", interval, interval);
        //clone = Instantiate(fruits[Random.Range(0, fruits.Length)], transform.position, Quaternion.AngleAxis(Random.Range(-30f, 30f), Vector3.back)) as GameObject;
  
    }
    void Create()
    {
        float y = 5f;
        float x = Random.Range(-6.5f, 6.5f);              //���ˮ�����ֵ�x����
        GameObject fruit = Instantiate(fruits[Random.Range(0, fruits.Length)]) as GameObject;   //ʵ����
        fruit.transform.position = new Vector3(x, y, 0);
        //����x������� ˮ�����е� �������ʼ�ٶȷ�Χ
        float xSpeed = 0f;
        if (x <= -3f)
            xSpeed = Random.Range(2f, 4f);
        else if (x < 3f)
            xSpeed = Random.Range(-1f, 1f);
        else
            xSpeed = Random.Range(-4f, -2f);
        // fruit.GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, 14f);           //ͨ��Rigidbody2D�����ˮ��һ����ʼ�ٶ�

        lastSpeed = speed * 2;
        Vector3 su = new Vector3(0, lastSpeed, 0);
        GetComponent<Rigidbody>().velocity = su;
        Destroy(gameObject, 20f);
    }

    /*
    void Create()
    {
        GameObject obj = Instantiate(fruit[Random.Range(0, fruit.Length)], transform.position, Quaternion.AngleAxis(Random.Range(-30f, 30f), Vector3.back)) as GameObject;
        Rigidbody2D rgd = obj.GetComponent<Rigidbody2D>();               //�õ�������ƻ����rigidbody ������һ���ٶ�
        rgd.velocity = Vector2.left * Random.Range(-10f, 10f);
        Destroy(obj, 2f);
    }
    */
}