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

public abstract class SampleScript : MonoBehaviour
{
    public abstract void Use();
}
