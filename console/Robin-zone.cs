// See https://aka.ms/new-console-template for more information
//
// Console.WriteLine("Hello world");

/*сейчас константы но должны быть начальные данные игры 0-9*/
const uint mounth = 30;
const uint base_hppmeal = 3;
const uint base_clothes = mounth;
const uint base_housing = mounth;

/*==предзагрузка данных==
1) реализовать чтение из файла/импорт+экспорт
2) (геймплей) некоторые параметры (тек.день) могут быть != 0
*/
uint currday = 0;
uint hppmeal = 0; uint base_hppmeal_penalty = 1;
uint clothes = 0; uint base_clothes_penalty = 3;
uint housing = 0; uint base_housing_penalty = 4;

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
void PrintALen(uint nonconst)
{// не знаю, в чем разница в преобразованиях + (int) into notes
    int i = (int)nonconst;
    string constnon = new String('$', i);
    Console.WriteLine($"{constnon}");
}

/* Вывод информации об игре: текущий день */
Console.WriteLine($"Robin-zone: Day, {currday}");
//Вывод числа ресурсов в достатке у персонажа td:red
PrintALen(hppmeal);
PrintALen(clothes);
PrintALen(housing);


