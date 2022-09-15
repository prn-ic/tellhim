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
![alt text](https://sun9-79.userapi.com/impg/GCKpRTOrYlJS5l8lDLJH46gLwMG7_yjoEH5r8w/q3HeaLhpKbs.jpg?size=350x500&quality=96&sign=b6ae521b80bde605bf88460f619d0ddf&type=album)
- Непосредственно работа программы
![hippo](https://psv4.userapi.com/c235131/u299329049/docs/d50/d40de0f6078b/devenv_HbtRPqElle.gif?extra=wtoAFQqF98MnME18Ctrlrm6pN-cDtu-HVZJUjby6BicwHecCvmS5fOOrilxPumyhFwMtCErDXaL8CF-cBogaZ9Z4CtSudkBrWM9OYacHJoS0C3YR2xg3EhfyyfJ-5566dj261bzKQlSlJN0_CFXvEcPPPw)

## Авторы
* **Paranoic** - *Initial work* - [zmqp](https://github.com/prn-ic)
