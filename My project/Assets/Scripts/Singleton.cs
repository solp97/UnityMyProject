using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour // where�� T�� ���� ���� ���� ��, ���׸��� ���������� ��밡��, ���׸��� �Ϲ�ȭ ���α׷��� Ÿ���� ����ó�� �̿밡��
//�ƹ� Ÿ���̵� �� �� �ִ�. � ������Ʈ���� ���� T�� ������� ��� �޾ƾ��Ѵ�.
{
    private static T _instance = null;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                DontDestroyOnLoad(_instance.gameObject);
            }

        return _instance;
        }
    }
    // Start is called before the first frame update
    private void Awake()
    {
        if (_instance != null)
        {
            if(_instance != this) Destroy(gameObject);

            return;
        }

        _instance = GetComponent<T>();
        DontDestroyOnLoad(gameObject);
    }
}
