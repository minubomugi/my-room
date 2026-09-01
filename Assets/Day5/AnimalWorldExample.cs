using UnityEngine;

public class AnimalWorldExample : MonoBehaviour
{
    // 다형성
    // 많은 형태를 지닌다~ Polymophysm?
    // 하나의 객체가 여러 타입(자료형)을 가질 수 있는 형질
    private void Start()
    {
        Animal person1 = new Person(name: "손정휘", age: 26, height: 179f, weight: 50, hasGlasses: false);
        Animal cat1 = new Cat(name: " 삐삐", height: 30, weight: 10);

        Animal person2 = new Person(name: "황유찬", age: 21, height: 179f, weight: 50, hasGlasses: true);
        Animal dog1 = new Dog(name: " 삐삐", height: 30, weight: 10);

        Animal person3 = new Person(name: "하지호", age: 28, height: 179f, weight: 50, hasGlasses: false);
        Animal dog2 = new Dog(name: " 삐삐", height: 30, weight: 10);

        Animal person4 = new Person(name: "민범기", age: 26, height: 163f, weight: 80, hasGlasses: false);
        Animal goldfish = new Goldfish(name: "금이", "주황색");
        
        // 자료형[] 변수명 = new 자료형[크기] {초기값}
        // 클래스도 자료형이고 참조 타입이며, 사용자 정의 자료형이다.
        Animal[] animals = new Animal[] {person1, cat1, person2, dog1, person3, dog2};

        // 동물들을 반복문을 이용해 순회하면서 Introduce 호출 가능
        for (int i = 0; i < animals.Length; i++)
        {
            animals[i].Introduce();

            if (animals[i] is Person)
            {
                Person person = (Person)animals[i]; // 명시적 형변환
                person.Seatdown();
            }
            // 이렇게 하는 거 맞음?
            Person pperson = animals[i] as Person;
            if (pperson != null)
            {
            // 2. as 형변환: 형변환 시도시 성공하면 성공 실패하면, null 반환
                pperson.Seatdown();
            }
        }
        
    }
}