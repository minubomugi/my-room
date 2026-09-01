using UnityEngine;

//상속이란: 부모(상위/기반/슈퍼) 클래스의 속성과 기능을 자식(하위/파생/ 서브) 클래스가 물려받아 그대로 사용 or 확장/변형
// 장점:
// - 코드 재사용(이미 만들어진 부모 클래스의 속성과 기능을 공유하므로 중복 최소화)
// - 확장 (자식 클래스만의 고유한 속성이나 기능 추가 기능)
// - 재정의: 부모에게 물려 받은 메서드를 상황에 맞게 재정의(오버라이딩)하여 사용 가능
// 여기서 장점은 코드 재사용 및 재정의 사용

public class Dog : Animal
{
    public Dog(string name, float height, float weight)
    {
        _name = name;
        _height = height;
        _weight = weight;
    }
    
    // 현재 문법은 재정의가 아니라 메서드 쉐도잉하고 있는 것
    // 재정의 문법은 override를 써야함
    // 재정의를 하면 가리키는 타ㅣㅂ과 상관없이 실제 탕딥의 메서드를 호출
    // 메서드 재정의를 위해선 보이드 앞에 오버라이드 넣어

    public override void Introduce()
    {
        Debug.Log($"멍멍 내 이름은 {_name}이다 멍~");
    }
}