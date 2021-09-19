using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPop : MonoBehaviour
{
    public GameObject p1, p2, p3, p4, t1, t2, t3, t4;

    // Update is called once per frame
    void Update()
    {
        if (EatItem.score != 0)
        {
            if (EatItem.score == 3)
            {
                TypeWriterEffect.forcheck -= 1;
                p1.gameObject.SetActive(true);

            }
            else if (EatItem.score == 6)
            {
                TypeWriterEffect.forcheck -= 1;
                p2.gameObject.SetActive(true);

            }
            else if (EatItem.score == 9)
            {
                TypeWriterEffect.forcheck -= 1;
                p3.gameObject.SetActive(true);

            }
            else if (EatItem.score == 12)
            {
                TypeWriterEffect.forcheck -= 1;
                p4.gameObject.SetActive(true);


            }

            if (t1.gameObject.activeSelf == false)
                p1.gameObject.SetActive(false);
            if (t2.gameObject.activeSelf == false)
                p2.gameObject.SetActive(false);
            if (t3.gameObject.activeSelf == false)
                p3.gameObject.SetActive(false);
            if (t4.gameObject.activeSelf == false)
                p4.gameObject.SetActive(false);
        }

    }
}