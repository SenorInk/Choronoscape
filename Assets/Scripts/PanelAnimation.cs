using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PanelAnimation : MonoBehaviour
{
    RectTransform panel;
    Vector3 upScale = new Vector3(1.2f, 1.2f, 1);

    private void Awake()
    {
        panel = gameObject.GetComponent<RectTransform>();
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Anim);
    }

    void Anim()
    {
        StartCoroutine(AnimatePanel());
    }

    IEnumerator AnimatePanel()
    {
        LeanTween.scale(panel, upScale, 0.1f);
        yield return new WaitForSeconds(0.1f);
        LeanTween.scale(panel, Vector3.one, 0.1f);
    }
}
