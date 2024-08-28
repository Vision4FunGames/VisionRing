using System;
using TaskSystem;
using UnityEngine;

public class SaveTheFox : MonoBehaviour
{
    public TaskSystem.TaskManager TaskManager;
    private Player _playerController;
    public bool changeTxt;
    public float distance;
    private void Awake()
    {
        _playerController = FindObjectOfType<Player>();
    }

    private void Update()
    {
        distance = Vector3.Distance(_playerController.transform.position, transform.position);
        if (distance < 25 && !changeTxt)
        {
            var box = TaskPanelController.instance.GetLastMainTask();
            box.infoText.text ="Save the Fox";
            changeTxt = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Solar"))
        {
            GetComponent<Waypoint_Indicator>().enableSprite = true;
        }
    }
}