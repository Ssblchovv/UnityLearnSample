/*
������� ������ SampleScript(��� ��� ��������), � ������� ����� �������� ����������� ����� Use().
����� ������� ������, ������� ������ ������ ���� SampleScript � ������� ������ ������ ����� ��������� Use() � �������.
������� ������-��������� SampleScript ��� ����������� �������: 
������ ����������� �� ������, ������� �������� ����������� � �����, ���� ������ ������ �������������. 
����� ����������� ���������� ��������������� ��������� ������� Use(). 
���������: ��� ������ ��������� � ����� (0,0,0) ������� ����� (3,0,0). 
���� ���� ��� ������� ����� Use(), �� ��� ������ �� 3 ������� 
(��� �������� �������� ����������� = 1 ����� � �������) ������ �������� �� ������� �����.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleManager : MonoBehaviour
{
    private SampleScript[] objects;
    
    private void Start()
    {
        objects = FindObjectsOfType<SampleScript>();
    }

    [ContextMenu("Poll")]
    public void Poll()
    {
        foreach (var obj in objects)
        {
            obj.Use();
        }
    }
}
