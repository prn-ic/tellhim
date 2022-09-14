# TellHim
_Простое приложение-чат, написанный на C#. Из чего состоит приложение?_
Приложение состоит из:
- /TellHim.Backend - Веб-приложение на ASP.NET Core, создано для работы с SignalR
- /TellHim.Domain - Библиотека классов, содержащая в себе модели
- /TellHim.EntityFramework - Библиотека классов, содержащая в себе работу с БД
- /TellHim.WPF - Приложение на WPF
## Начало работы
Для того, чтобы использовать приложение, вам нужно клонировать данный репозиторий (git clone ...), и следовать НЕОБХОДИМЫМ УСЛОВИЯМ
### Необходимые условия
Для работы приложения, изначально нужно создать базу данных (в моем случае она локальная, то есть все что требуется, это Visual Studio)
Чтобы создать базу данных, вам нужно:
- (если хотите настроить соединение с базой данных, то класс называется TellHimDbContextFactory)
- Перейти в консоль разработчика
- Перейти в папку /TellHim.EntityFramework
- И далее вводим команды _dotnet-ef migrations add Initial_ и _dotnet-ef database update_
На этом вся настройка закончена
### Пример работы программы
- Начальное окно без каких-либо данных:
![alt text](https://sun9-50.userapi.com/impg/7hM3VoE-BmdUozXJsf-_DPQ3slrbzactKvO11A/kCNhvty38FQ.jpg?
