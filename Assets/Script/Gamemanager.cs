using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Gamemanager : MonoBehaviour
{
    public Text timeTxt;
    public GameObject card;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        int[] Afifteen = { 0, 0, 1, 1, 2, 2, 3, 3 };
        Afifteen = Afifteen.OrderBy(item => Random.Range(-1.0f, 1.0f)).ToArray();
        for (int i = 0; i < 8; i++)
        {
            GameObject newCard = Instantiate(card);
            newCard.transform.parent = GameObject.Find("cards").transform;
            float x = (i / 4) * 1.4f - 0.7f;
            float y = (i % 4) * 1.4f - 3.0f;
            newCard.transform.position = new Vector3(x, y, 0);
            string AfifteenName = "Afifteen" + Afifteen[i].ToString();
            Debug.Log(AfifteenName);
            newCard.transform.Find("front").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(AfifteenName);
        }
    }


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N2");

    }
}