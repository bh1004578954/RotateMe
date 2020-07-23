
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InitPanelLayout();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void InitPanelLayout()
    {
        RectTransform rectTransform = transform.GetComponent<RectTransform>();
        rectTransform.anchorMin = new Vector2(1, 1);
        rectTransform.anchorMax = new Vector2(1, 1);
        rectTransform.pivot = new Vector2(0, 1);
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 400);
        rectTransform.anchoredPosition = new Vector2(-300, -35);

        GameObject title = new GameObject("title");
        title.transform.SetParent(transform);
        title.AddComponent<Image>().color=Color.yellow;
        RectTransform titleRec = title.GetComponent<RectTransform>();
        titleRec.anchorMin = new Vector2(0, 1);
        titleRec.anchorMax = new Vector2(1, 1);
        titleRec.pivot = new Vector2(0, 1);
        titleRec.offsetMax = new Vector2(0, 0);
        titleRec.offsetMin = new Vector2(0, -15);

        GameObject content = new GameObject("content");
        content.transform.SetParent(transform);
        content.AddComponent<Image>().color = Color.blue;
        RectTransform contentRec = content.GetComponent<RectTransform>();
        contentRec.anchorMin = new Vector2(0, 1);
        contentRec.anchorMax = new Vector2(0, 1);
        contentRec.pivot = new Vector2(0, 1);
        contentRec.anchoredPosition = new Vector2(0,-30);
        VerticalLayoutGroup vl = content.AddComponent<VerticalLayoutGroup>();
        vl.padding.bottom = 5;
        vl.childControlHeight = true;
        vl.childControlWidth = true;
        ContentSizeFitter cf = content.AddComponent<ContentSizeFitter>();
        cf.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        cf.verticalFit= ContentSizeFitter.FitMode.PreferredSize;
    }
}
