using UnityEngine;

public abstract class Animal // 추상 클래스 : new 연산자를 이용해서 객체를 못만듦...
{
    // protected: 외부에서는 접근 불가이지만, 내부 혹은 자식 클래스는 접근 가능
    protected string _name = string.Empty;
    protected float _height = 0f;
    protected double _weight = 0f;

    // virtual은 오버라이드가 가능하다고 알려주는 표시 그걸 자식 클래스에서 override써서 재정의 가능
    public abstract void Introduce(); // 추상 메서드 - 구현이 없는 메소드 이므로
                                    // 자식 하위 클래스에서 무조건 구현을 해야함
                                    
    public void Seatdown()
    {
        Debug.Log("Seat down");
    }

    public void Run()
    {
        Debug.Log($"[{_name} 뛰는 중!] 속도 : {100-(_height / _weight)}");
    }
}