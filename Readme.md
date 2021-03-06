<h3>Задание 1</h3>
   <em>Вычисление площади фигуры без знания типа фигуры в compile-time</em> - не очень понятная формулировка. Я понял это как вынесение фигуры в отдельную абстракцию Shape, чтобы в итоге можно было написать:
   
  ``` csharp
  Shape circle = new Circle(radius);
  double area = circle.GetArea():
  ```
   
   Небольшое пояснение по методу Validate(). 

   Идеальным место для его вызова могли бы быть сеттеры для свойств в классах. Однако, есть одно исключение - проверка, что треугольник
   с заданными сторонами может существовать. Такая проверка не может быть вынесена в сеттер, т.к. она должна выполняться только тогда, когда все стороны заданы.
   
   Разносить логику валидации по разным местам (отдельно в сеттеры и отдельно одну проверку для треугольника) неправильно. 
   Хороший вариант - вызывать Validate() в конструкторе, но это тоже не идеально. Поэтому я его там закомментировал с мыслью, что Validate() должен быть вызван из клиентского кода. 
   Тесты также писались из расчета, что Validate() не вызывается в конструкторе.

<h3>Задание 2</h3>

Так как схемы данных в задании не было, при выполнении задания использовал следующую схему данных:

**Таблица "Products"**
| Field          |     Type     |
| -------------- | :----------: |
| ProductId (PK) |     int      |
| ProductName    | varchar(100) |

**Таблица "Categories"**
| Field           |     Type     |
| --------------- | :----------: |
| CategoryId (PK) |     int      |
| CategoryName    | varchar(100) |

**Таблица "ProductCategories"**
| Field           | Type  |
| --------------- | :---: |
| ProductId (FK)  |  int  |
| CategoryId (FK) |  int  |
