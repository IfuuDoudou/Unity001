
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public int count;
    public Text textcount;
    public GameObject final;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送門惹");
        if (collision.name =="傳送門")
        {
         final.SetActive(true);
        }

        if (collision.tag == "cherry")
        {
            Destroy(collision.gameObject);
            count++;
            textcount.text = "櫻桃數量:" + count;

        }
    }
}
 