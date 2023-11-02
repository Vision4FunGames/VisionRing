using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class CaseScroll : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject _prefab;


    private float _speed;
    private bool _isScrolling;
    private List<CaseCell> celss = new List<CaseCell>();
    private bool isButtonActive;

    public void Scroll()
    {
        if (_isScrolling)
            return;

        GetComponent<RectTransform>().localPosition = new Vector3(10800, 0);
        _speed = Random.Range(7, 8);
        _isScrolling = true;

        if (celss.Count == 0)
        {
            for (int i = 0; i < 100; i++)
            {
                celss.Add(Instantiate(_prefab,transform).GetComponentInChildren<CaseCell>());
            }
        }
        
        foreach (var cell in celss)
        {
            cell.Setup();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position + Vector3.left * 100,
            _speed * Time.deltaTime * 520);
        if (_speed > 0)
        {
            _speed -= Time.deltaTime;
        }
        else
        {
           _speed = 0; 
           _isScrolling = false;
           UiManager.instance.CollectButtonOpen();
        }
    }
}
