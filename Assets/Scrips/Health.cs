using UnityEngine;

public class Health : MonoBehaviour
{
    //�������� ��������
    public int health;
    //������������ �������� ��������
    public int maxHealth;

    //������� ��������� �����
    public void TakeHit(int damage)
    {
        health -= damage;

        //���� �������� ������ 0 - ���������� ������ �� ������� ����� ���� ������
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
