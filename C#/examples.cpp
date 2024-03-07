//https://ru.stackoverflow.com/questions/1207597/Повторить-символы-в-cтроке
/*
Есть символ. Любой. Например: $
Как можно повторить его в строке определенное количество раз
или исходя из определенных условий задачи?
Например, сделать строку из символов больше количество букв слова
на два символа:  стол $$$$$$
*/
s=new String('$', 6);

----

//https://metanit.com/sharp/tutorial/2.8.php
/*функции называются методами*/
void SayHello()
{
    Console.WriteLine("Hello");
}

----

/*
https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/program-structure/top-level-statements
*/
using td.txt;
//не пригодилось

----

/*приглянулось*/

//https://metanit.com/sharp/tutorial/3.58.php
string CheckAge(int age) => age switch
{
    not 33 => "Обычный возраст",   // если age НЕ равен 33
    _ => "Вам 33 года"             // в остальных случаях, то есть если age = 33
};

----

//сложная тема "Передача параметров по ссылке и значению. Выходные параметры"
//https://metanit.com/sharp/tutorial/2.27.php

----

/* //первый гит коммит) *локальную
 исправил подсказки про статическую* функцию (что-то там не может)
 static void PrintALen(uint nonconst)
 и запись строки через ключевое слово без указание типа (строка)
 string constnon = new('$', i);
*/

----

//наконец оформим структуру (как её переопределять? либо расписывать/удалять значения)
//https://metanit.com/sharp/tutorial/2.13.php
/*
struct Person
{
    public string name;
    public int age;
 
    public Person(string name = "Tom", int age = 1)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}
*/