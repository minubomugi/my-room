using UnityEngine;

public class Goldfish : Animal
{
    private string _color;
    
    public Goldfish(string name,string color)
    {
        _name = name;
        _height = 2;
        _weight = 0.3;
        _color = color;
    }

    public override void Introduce()
    {
        Debug.Log($"뻐끔뻐끔 이름이 {_name}인 나의 색은 {_color}입니다.");
    }
}
