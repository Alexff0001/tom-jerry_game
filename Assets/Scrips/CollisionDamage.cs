using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 1;
    public string collisionTag;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        //���� ��� ������� ��������� �������� ���������� � ����������� ������ ������� - Player
        if (coll.gameObject.tag == collisionTag)
        {
            //���� � ����� ������� ��������� Health (������ ������� �� �� �����)
            Health health = coll.gameObject.GetComponent<Health>();
            //� �������� ������� ��������� �����, � ��������� ���������� �����
            health.TakeHit(collisionDamage);
        }
    }
}
