using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIKeyHolder : MonoBehaviour
{
    [SerializeField] private KeyHolder keyHolder;
    
    private Transform container;
    private Transform keyTemplate;

    private void Awake()
    {
        container = transform.Find("container");
        keyTemplate = container.Find("keyTemplate");
        keyTemplate.gameObject.SetActive(false);
    }

    private void UpdateVisual()
    {
        List<Key.KeyType> keyList = keyHolder.GetKeyList();
        for (int i = 0; i < keyList.Count; i++)
        {
            Key.KeyType keyType = keyList[i];
            Transform keyTransform = Instantiate(keyTemplate, container);
            keyTemplate.gameObject.SetActive(true);
            keyTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(50 * i, 0);
            TextAsset keyText = keyTransform.Find("Text").GetComponent<TextAsset>();
            
        }
    }
}
