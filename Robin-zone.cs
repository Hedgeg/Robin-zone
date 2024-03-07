// See https://aka.ms/new-console-template for more information
//
// Console.WriteLine("Hello world");

/*сейчас константы но должны быть начальные данные игры 0-9*/
using System.Text;

const uint mounth = 30; //+-1-2
const uint base_hppmeal = 3; //2-5
const uint base_clothes = mounth; //22-34
const uint base_housing = mounth; //18-30 -+/1.2-3.0

/*==предзагрузка данных==
1) реализовать чтение из файла/импорт+экспорт
2) (геймплей) некоторые параметры (тек.день) могут быть != 0
*/
uint currday = 0;
uint hppmeal; uint base_hppmeal_penalty = 1;
uint clothes; uint base_clothes_penalty = 3;
uint housing; uint base_housing_penalty = 4;

/*==инициализация данных && первый цикл игры
"первый" день игры
!! также первый день не обязан начинаться с получения еды
<- реализовать выбор игрока или по необх.потребностям ->
*/
if (true){
    currday += 1;
    hppmeal = base_hppmeal - base_hppmeal_penalty;
    clothes = base_clothes - base_clothes_penalty;
    housing = base_housing - base_housing_penalty;
}/*??унифицировать в единую функцию над 4 байтами??*/


/* функция вывода числа ресурсов
 через строку нужной длинны (без разметки)
*/
static void PrintALen(uint nonconst)
{// не знаю, в чем разница в преобразованиях + (int) into notes
    int i = (int)nonconst;
    string constnon = new('$', i);
    Console.WriteLine($"{constnon}");
}

/* Вывод информации об игре: текущий день */
Console.WriteLine($"Robin-zone: Day, {currday}");
//Вывод числа ресурсов в достатке у персонажа td:red
PrintALen(hppmeal);
PrintALen(clothes);
PrintALen(housing);



/* td
1) проработать разделение на файлы
2) продумать возможные/базовые действия и их код
3) vica versa
*/

//здесь (0)пишем структуру игры
struct Game // class #ifdef
{
    public uint Goal;
    public uint food;
    public uint shelter;
    public uint survivals;
    public int Choose; //массив
    public uint day;
 
    public void Iter(uint Goal, uint food, uint shelter, uint survivals)
    {
        day += 1;
    }
    public void Status(uint Goal) => {
{// не знаю, в чем разница в преобразованиях + (int) into notes

#ifdef false
 int i = (int)nonconst;
#endif
/*
    if N > 10 then N - 10 and print small strung
    while N > 0 < 10
    string constnon = new('$', i);
  */
#ifdef false
    Console.Write($"{constnon}");
    Console.Write($"Имя: {name}  Возраст: {age}");
#endif
}
    }
}