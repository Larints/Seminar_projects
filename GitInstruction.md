# Инструкция для работы с Git и удалёнными репозиториями

## _**Что такое Git?**_

_Git_ - это одна из реализаций распределённых систем контроля версий, имеющая как и локальные, так и удалённые репозитории. Является самой популярной реализацией систем контроля версий в мире.git

## _**Подготовка репозитория**_

Для создание репозитория необходимо выполнить команду **git init**  в папке с репозиторием и у Вас создаться репозиторий (появится скрытая папка .git)

## _**Создание коммитов**_

**Git add**

Для добавления измений в коммит используется команда **git add**. Чтобы использовать команду **git add** напишите **git add <имя файла>**

## **_Просмотр состояния репозитория_**
Для того, чтобы посмотреть состояние репозитория используется команда **git status**. Для этого необходимо в папке с репозиторием написать **git status**, и Вы увидите были ли измения в файлах, или их не было.

## **_Создание коммитов_**
Для того, чтобы создать коммит(сохранение) необходимо выполнить команду **git commit**. Выполняется она так: **git commit -m "<сообщение к коммиту>**. Все файлы для коммита должны быть ***ДОБАВЛЕНЫ*** и сообщение к коммиту писать ***ОБЯЗАТЕЛЬНО***.

## **_Перемещение между сохранениями_**
Для того, чтобы перемещаться между коммитами, используется команда **git checkout**. Используется она в папке с пепозиторием следующим образом: **git checkout <номер коммита>**

## **_Журнал изменений_**
Для того, чтобы посмтреть все сделанные изменения в репозитории, используется команда **git log**. Для этого достаточно выполнить команду **git log** в папке с репозиторием

##  **Ветки в Git: **

## **_Создание ветки_**

Для того, чтобы создать ветку, используется команда **git branch**. Делается это следующим образом в папке с репозиторием: **git branch <название новой ветки>**

## **_Слияние веток_**

Для того чтобы дабавить ветку в текущую ветку используется команда  **git merge <name branch>**

## **_Удаление веток_**
Для удаления ветки ввести команду "**git branch -d 'name branch'**"

## **_Работа с репозиториями_**

## **_Git pull_**
Эта команда позволяет скачать все из текущего репозитория и автоматически сделать merge с нашей версией

## **_Git push_**
При первом её использовании нужна авторизация.
Эта команда позволяет отправить нашу версию репозитория на внешний репозиторий. **ТРЕБУЕТ АВТОРИЗАЦИИ** на внешнем репозитории.

_Как настроить совместную работу_

1. Создать аккаунт на GitHub.com
2. Создать локальный репозиторий
3. “Подружить” ваш локальный и удалённый репозитории. 
    
_GitHub при создании нового репозитория подскажет, как это можно сделать_
    
4. Отправить (push) ваш локальный репозиторий в удалённый (на GitHub), при этом, возможно, вам нужно будет авторизоваться на удалённом репозитории
5. Провести изменения “с удаленного репозитория”
6. Выкачать (pull) актуальное состояние из удалённого репозитория

## **_Pull request_**

- команда для предложения изменений 

- запрос на вливание изменений в репозиторий

В больших компаниях один ответственный за проект создает аккаунт. Другие пользователи дают команду **pull request**. Предлагать изменения на GitHub нужно в отдельной ветке. 
Сначала пользователь копирует репозиторий на свой компьютер, делает fork репозитория, затем клонирует версию на своём ПК, создаёт ветку с предлагаемыми изменениями, отправляет изменения командой push в свой аккаунт на GitHub и даёт команду pull request.
    
  ## **_Как сделать pull request (по шагам):_**

- Делаем _**fork**_ (ответвление) репозитория
- Делаем _**git clone СВОЕЙ**_ версии репозитория
- Создаем новую ветку и в _**НЕЕ**_ вносим свои изменения
- Фиксируем изменения (делаем коммиты)
- Отправляем свою версию в свой GitHub
- На сайте GitHub нажимаем кнопку **pull request**