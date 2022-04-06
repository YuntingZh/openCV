using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imagearray : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] foods = new Sprite[7];
    string[] foodstext = new string[] { "Watermelon", "Banana", "Cheese", "Cherry","Hotdog","Olive","Hamburger" };
    public Image foodstimage;
    public int currentimage = 0;
    public Text Text;
    public Button prev;
    public Button next;
    void Start()
    {
        //foodstimage.sprite = foods[0];

        Text.text = foodstext[currentimage];
        foodstimage.sprite = foods[currentimage];
        prev.onClick.AddListener(() => {
            currentimage = currentimage - 1;
            if (currentimage <= -1)
            {
                currentimage = foods.Length - 1;
            }
            foodstimage.sprite = foods[currentimage];
            Text.text = foodstext[currentimage];
        });

        next.onClick.AddListener(() => {
            currentimage = currentimage + 1;
            if (currentimage >= foods.Length)
            {//foods.Length currently is 4
                currentimage = 0;//currentimage = 3; set back to first image
            }
            foodstimage.sprite = foods[currentimage];
            Text.text = foodstext[currentimage];
        });

    }

    // Update is called once per frame
    void Update()
    {

    }
}



