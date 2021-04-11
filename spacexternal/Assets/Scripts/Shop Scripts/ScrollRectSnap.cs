using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRectSnap : MonoBehaviour
{

    public RectTransform panel;
    public Image[] items;
    public RectTransform center;

    private float[] distance;
    private bool dragging = false;
    private int itemsDistance;
    private int minItemNum;

    void Start()
    {
        int itemsLength = items.Length;
        distance = new float[itemsLength];

        itemsDistance = (int)Mathf.Abs(items[1].GetComponent<RectTransform>().anchoredPosition.x - items[0].GetComponent<RectTransform>().anchoredPosition.x);

    }

    void Update()
    {
        for (int i = 0; i < items.Length; i++)
        {
            distance[i] = Mathf.Abs(center.transform.position.x - items[i].transform.position.x);
        }

        float minDistance = Mathf.Min(distance);

        for(int a = 0; a < items.Length; a++)
        {
            if(minDistance == distance[a])
            {
                minItemNum = a;
            }
        }

        if (!dragging)
        {
            LerpToItem(minItemNum * -itemsDistance);
        }
    }

    void LerpToItem(int position)
    {
        float newX = Mathf.Lerp(panel.anchoredPosition.x, position, Time.deltaTime * 10f);
        Vector2 newPosition = new Vector2(newX, panel.anchoredPosition.y);

        panel.anchoredPosition = newPosition;
    }

    public void StartDrag()
    {
        dragging = true;
    }

    public void EndDrag()
    {
        dragging = false;
    }
}
