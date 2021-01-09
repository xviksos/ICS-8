# Краткая информация о паттернах и их схема

### 1. Адаптер (_Adapter_)
##### _Структурный паттерн_

Позволяет объектам с несовместимыми интерфейсами работать вместе.

![Adapter Schema](https://metanit.com/sharp/patterns/pics/adapter.png)

### 2. Абстрактная фабрика (_Abstract Factory_)
##### _Порождающий паттерн_

Позволяет создавать семейства связанных объектов, не привязываясь к конкретным классам создаваемых объектов.

![Abstract Factory Schema](https://metanit.com/sharp/patterns/pics/abstractfactory.png)

### 3. Фабричный метод (_Factory Method_)
##### _Порождающий паттерн_

Определяет общий интерфейс для создания объектов в суперклассе, позволяя подклассам изменять тип создаваемых объектов.

![Factory Method Schema](https://metanit.com/sharp/patterns/pics/factorymethod.png)

### 4. Одиночка (_Singleton_)
##### _Порождающий паттерн_

Гарантирует, что у класса есть только один экземпляр, и предоставляет к нему глобальную точку доступа.

![Singleton Schema](https://refactoring.guru/images/patterns/diagrams/singleton/structure-ru-2x.png)

### 5. Стратегия (_Strategy_)
##### _Паттерн поведения_

Определяет семейство схожих алгоритмов и помещает каждый из них в собственный класс, после чего алгоритмы можно взаимозаменять прямо во время исполнения программы.

![Strategy Schema](https://metanit.com/sharp/patterns/pics/strategy.png)

### 6. Шаблонный метод (_Template Method_)
##### _Паттерн поведения_

Определяет скелет алгоритма, перекладывая ответственность за некоторые его шаги на подклассы. Паттерн позволяет подклассам переопределять шаги алгоритма, не меняя его общей структуры.

![Template Method Schema](https://metanit.com/sharp/patterns/pics/templatemethod.png)

### 7. Фасад (_Facade_)
##### _Структурный паттерн_

Предоставляет простой интерфейс к сложной системе классов, библиотеке или фреймворку.

![Facade Schema](https://metanit.com/sharp/patterns/pics/facade.png)

### 8. Цепочка обязанностей (_Chain of Responsibility_)
##### _Паттерн поведения_

Позволяет передавать запросы последовательно по цепочке обработчиков. Каждый последующий обработчик решает, может ли он обработать запрос сам и стоит ли передавать запрос дальше по цепи.

![Chain of Responsibility Schema](https://metanit.com/sharp/patterns/pics/chainofresponsibility.png)

### 9. Команда (_Command_)
##### _Паттерн поведения_

Превращает запросы в объекты, позволяя передавать их как аргументы при вызове методов, ставить запросы в очередь, логировать их, а также поддерживать отмену операций.

![Command Schema](https://metanit.com/sharp/patterns/pics/command.png)

### 10. Декоратор (_Decorator_)
##### _Структурный паттерн_

Позволяет динамически добавлять объектам новую функциональность, оборачивая их в полезные «обёртки».

![Decorator Schema](https://metanit.com/sharp/patterns/pics/decorator2.png)

 
