using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private StaffListSO _list;
    private int _currentItemId;
    void Start()
    {
        _list = Resources.Load<StaffListSO>(nameof(StaffListSO));
        _currentItemId = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
