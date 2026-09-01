using UnityEngine;

//상속이란: 부모(상위/기반/슈퍼) 클래스의 속성과 기능을 자식(하위/파생/ 서브) 클래스가 물려받아 그대로 사용 or 확장/변형
// 장점:
// - 코드 재사용(이미 만들어진 부모 클래스의 속성과 기능을 공유하므로 중복 최소화)
// - 확장 (자식 클래스만의 고유한 속성이나 기능 추가 기능)
// - 재정의: 부모에게 물려 받은 메서드를 상황에 맞게 재정의(오버라이딩)하여 사용 가능
// 여기서 장점은 코드 재사용


public class Person : Animal
{
    private int _age = 0;
    public bool _hasGlasses = false;
    
    public Person(string name, int age, float height, float weight, bool hasGlasses)
    {
        _name = name;
        _height = height;
        _weight = weight;
        _age = age;
        _hasGlasses = hasGlasses;
    }

    public override void Introduce()
    {
        Debug.Log($"안녕하세요 저는 {_name}입니다. 반가워요");
    }
}