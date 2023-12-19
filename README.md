# MS4SArgLiteHasher
[Console] Even more lite version of MD5 Hasher and comparer with custom settings. Version without UI that can compare and compute chekcsums into .txt file.<br></br>

> Version with UI [<a href="https://github.com/MentallyStable4sure/MD5-Hasher">clickable</a>]: 
<br><a href="https://github.com/MentallyStable4sure/MD5-Hasher"><img width="100" height="150" src="https://private-user-images.githubusercontent.com/62771181/290764558-96df6e22-69d3-4f1b-af09-dd489b99a6d9.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE3MDI5NTc0ODIsIm5iZiI6MTcwMjk1NzE4MiwicGF0aCI6Ii82Mjc3MTE4MS8yOTA3NjQ1NTgtOTZkZjZlMjItNjlkMy00ZjFiLWFmMDktZGQ0ODliOTlhNmQ5LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFJV05KWUFYNENTVkVINTNBJTJGMjAyMzEyMTklMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjMxMjE5VDAzMzk0MlomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPWY3ZjhlOTI0NDFmNDUzZDlkNzYwMDY0YjBjNWUwODkyNDFjMjg3M2VhNmIyOTM2OTNmMWIyODQ3N2EwY2NlMjYmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.-ORAVgs9ITQJKLyD2_Ysh7q7x93YkP-1zMo9yDrOvls"> <img width="100" height="150" src="https://private-user-images.githubusercontent.com/62771181/290766803-a6c45ea1-acf8-452f-a728-0e61c41a5e53.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE3MDI5NTc0ODIsIm5iZiI6MTcwMjk1NzE4MiwicGF0aCI6Ii82Mjc3MTE4MS8yOTA3NjY4MDMtYTZjNDVlYTEtYWNmOC00NTJmLWE3MjgtMGU2MWM0MWE1ZTUzLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFJV05KWUFYNENTVkVINTNBJTJGMjAyMzEyMTklMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjMxMjE5VDAzMzk0MlomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTgzMDZmNjBjYWQxN2YwMTc4YzJmNzU3MGE3ZTI4YzRmODdhMDU3NzEyNDFkMmFkZDg2MjliM2M4N2Q1YTYzM2MmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.3K3PEBxnpJcioUqavB27v6S69PuugQDq2lKon2Xj8HQ"></a></br>

<details>
<summary>[EN] How to use?</summary>
Run a build or Visual Studio project with arguments either '--compute' or '--compare', providing the path, filename and separator (for compare path1, path2)
The result will be either:<br></br>

> .txt document with all hashes named with the filename you passed and registry key with path
<br>--- OR ---</br>
> Registry Key with result TRUE/FALSE for comparer [Registry/HKEY_CURRENT_USER/MS4S in key COMPARE_HASH_ACTION_RESULT]

<br></br>
Examples:

To create file named checksum.txt with separator ':' you call arguments like that:
```
--compute C:\Users\user\Documents\GitHub\MS4SArgLiteHasher checksum :
```
Or to compare already compiled 2 files with different separators ':' and '♡♡♡♡' for example, it would be like that:
```
--compare C:\Users\user\Documents\GitHub\MS4SArgLiteHasher\checksum.txt D:\Apps\examples\checksum.txt : ♡♡♡♡ 
```

</details>

<details>
<summary>[RU] Как пользоваться?</summary>
Запустить билд или приложение в Visual Studio с аргументами '--compute' или '--compare', так же указав путь, имя файла, и разделитель (для --compare нужно 2 пути, первого и второго файла через пробел)
Результат:<br></br>

> .txt текстовый документ со всеми хеш-суммами в файле с названием который вы указали третьим аргументом после пути
<br>--- ИЛИ ЖЕ ---</br>
> Ключ в реестре со значением TRUE/FALSE если используете сравнение [лежит в Редактор Реестра/HKEY_CURRENT_USER/MS4S в ключе который называется COMPARE_HASH_ACTION_RESULT]

<br></br>
Примеры аргументов:

Для создания файла с именем checksum.txt и разделителем ':' можете передать такие аргументы:
```
--compute C:\Users\user\Documents\GitHub\MS4SArgLiteHasher checksum :
```
Или же для сравнения двух уже скомпилированных файлов с хеш-суммами но например разными разьеденителями ':' и '♡♡♡♡' это будет выглядеть вот так:
```
--compare C:\Users\user\Documents\GitHub\MS4SArgLiteHasher\checksum.txt D:\Apps\examples\checksum.txt : ♡♡♡♡ 
```

</details>
<br></br>
<details>
<summary>[EN] i dont get it</summary>
The same app but with User Interface (buttons and images, u tiktok kids) is located here: (its easier)
https://github.com/MentallyStable4sure/MD5-Hasher
</details>
<details>
<summary>[RU] что-то я не понял, дядь</summary>
Точно такое же приложение но с визуальным интерфейсом (букавы сложно) вот тут есть: (оно проще)
https://github.com/MentallyStable4sure/MD5-Hasher
</details>
