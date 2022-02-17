# **Задача**

 Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры решения задачи:
* ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
* ["1234", "1567", "-2", "computer science"] -> ["-2"]
* ["Russia", "Denmark", "Kazan"] -> []

# **Описание решения задачи**

Задача решается путем выделения 4-х отдельных методов  внутри программы:

| **Метод** | **Описание метода**
|-----------|--------------------|
|*FillArray* | Метод создает и заполняет исходный массив строк путем ввода строк пользователем  с клавиатуры.
|*FindNewArrayLength*| Метод находит длину нового массива, который будет состоять из тех строк исходного массива, длина которых меньше или равна заданному количеству символов.
|*CreateNewArray* | Метод создает новый массив строк из строк исходного массива, длина которых меньше или равна заданному количеству символов.
|*PrintArray*| Метод преобразует массив строк в строку для вывода массива на экран.
## Ход решения задачи
1.  Задаем длину исходного массива с клавиатуры:
```
Console.Write("Введите длину первоначального массива строк: ");

int arrayLength = int.Parse(Console.ReadLine()??"0");
```
2. Вызываем метод *FillArray*. Аргумент метода - заданная выше длина массива arrayLength. Метод возвращает исходный массив строк stringArray.
```
string[] stringArray = FillArray(arrayLength);
````
3. Вызываем метод *FindNewArrayLength*. Аргументы метода - исходный массив строк stringArray и 3(меньше или равно этому числу количество символов в каждой строке нового массива, дано по условию задачи). Метод возвращает длину нового массива newArrayLength. 
```
int newArrayLength = FindNewArrayLength(stringArray, 3);
```
4. Вызываем метод *CreateNewArray*. Аргументы метода - исходный массив строк stringArray, длина newArrayLength нового создаваемого массива  и 3(меньше или равно этому числу количество символов в каждой строке нового массива, дано по условию задачи). Метод возвращает новый массив строк newArray, состоящий из строк исходного массива, длина которых меньше или равна 3.
```
string[] newArray = CreateNewArray(stringArray, newArrayLength, 3);
```
5. Консольный вывод. Вызываем метод PrintArray дважды в качестве аргументов встроенного метода Console.Write для вывода на экран исходного массива строк stringArray и созданного newArray.
```
Console.Write($"{PrintArray(stringArray)} -> {PrintArray(newArray)}");
```