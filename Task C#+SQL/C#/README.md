# Часть задания, относящаяся к библиотеке на языке программирования C# 

## Библиотека FigureCalculator
Библиотека разработана на языке C# с использованием .net Core 3.1. Не смотря на то, что это относительно старый выпуск (2019 год), он все еще поддерживается, и он крослатформен.А так же с него можно мигрировать на .Net 5+.

Библиотека написана с использование достаточно простых алгоритмов, однако для использования её в высоконагруженных системах лучше подкорректировать код библиотеки тк в ней используется LINQ, а он в свою очередь создает бóльшую нагрузку на сборщик мусора, чем реализация через обычные циклы. 
- В библиотеке достаточно просто можно как добавлять новые фигуры, так и расширят функционал старых фигур.
- А вот касательно *"Вычисление площади фигуры без знания типа фигуры в compile-time"* есть вопрос. В постановке задания подразумевалось что Метод/Свойство площади фигуры будет реализовано через позднее связывание. Но возникает вопрос: самым явным способом реализации позднего связывания будет наследование от класса(абстрактного), у которого Метод/Свойство вычисления площади обозначено как **virtual**, и после, уже в классе наследнике, Метод/Свойство будет переопределенно **override**. А реализация позднего связывания при помощи Интерфейсов считалась бы? Ведь по сути у интерфейса нет реализации (До C# 8).
- Ну а реализация проверки треугольника на наличие прямого угла вынесена в класс расширение по той причине, что класса Треугольника реализует интерфейс IType, который в свою очередь возвращает Тип треугольника, относительно его уголв. Но по скольку нам необходимо узнать прямоугольный ли треугольник, мы методом расширения узнаем тип треугольника и отвечаем прямоугольный ли треугольник. В принципе этот метод можно было бы и в класс Треугольника поместить, но это был бы избыточный код, перегружавший класс по функционалу и в какой-то степени дублирующий функционал внутри класса.

## Тесты FigureCalculator.Tests
Тесты реализованы в отдельном проекте на основе MSTests так же для .net Core 3.1. Каждый отдельный класс реализует набор тестов для каждой из фигур.
В тестах проверяется как корректность работы формул, так и поведение программы при вводе некорректных значений.
