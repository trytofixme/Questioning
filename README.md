# Тестовое Задание

**Написать консольное приложение для анкетирования**

При загрузке приложения выводится стартовое сообщение: “Выберите действие:”, нужно ввести команду для продолжения дальнейшей работы.

**Список доступных команд**

● cmd: -new_profile - Заполнить новую анкету

● cmd: -statistics - Показать статистику всех заполненных анкет

● cmd: -save - Сохранить заполненную анкету

● cmd: -goto_question <Номер вопроса> - Вернуться к указанному вопросу (Команда доступна только при заполнении анкеты, вводится вместо ответа на любой вопрос)

● cmd: -goto_prev_question - Вернуться к предыдущему вопросу (Команда доступна только при заполнении анкеты, вводится вместо ответа на любой вопрос)

● cmd: -restart_profile - Заполнить анкету заново (Команда доступна только при заполнении анкеты, вводится вместо ответа на любой вопрос)

● cmd: -find <ФИО> - Найти анкету и показать данные анкеты в консоль

● cmd: -delete <ФИО> - Удалить указанную анкету

● cmd: -list - Показать список ФИО всех сохранённых анкет

● cmd: -list_today - Показать список ФИО всех сохранённых анкет, созданных сегодня

● cmd: -help - Показать список доступных команд с описанием

● cmd: -exit - Выйти из приложения

**Заполнить новую анкету**

В анкете 5 вопросов: 

1. ФИО
2. Дата рождения (Формат ДД.ММ.ГГГГ)
3. Любимый язык программирования (Можно ввести только указанные варианты, иначе ошибка: PHP, JavaScript, C, C++, Java, C#, Python, Ruby)
4. Опыт программирования на указанном языке (Полных лет)
5. Мобильный телефон
 
Вопросы должны идти по очереди, после того как пользователь ввёл ответ, выводить следующий вопрос или ошибку.

Все вопросы обязательны для заполнения.

После заполнения всех вопросов выводится сообщение: “Выберите действие:”, нужно ввести команду для продолжения дальнейшей работы.

**Сохранить заполненную анкету**

Анкета должна сохраняться в SQLite с использованием EF Core 6.

Структура анкеты:

1. Id: Int
2. ФИО: string
3. Дата рождения: DateTime
4. Любимый язык программирования: Int
5. Мобильный телефон: string
 
**Показать статистику всех заполненных анкет**
Нужно вывести в консоль следующие данные: 1. Средний возраст всех опрошенных: <Посчитать средний возраст всех тех, кто заполнял анкеты, целое число> (год, года, лет в зависимости от полученного числа, т.е если средний возраст получился 22, то вывести 22 года, если 25, то 25 лет и т.д.) 2. Самый популярный язык программирования: <Название языка программирования, который большинство пользователей указали как любимый> 3. Самый опытный программист: <ФИО человека, у которого указан самый большой опыт работы>
 
Можно использовать любые подручные средства.
