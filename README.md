# KIP_Service_TZ
## Тестовое задание в КИП-Сервис. 
Реализовать асинхронную обработку запросов в ядре .net, типа приложения WebApi.

	1. Метод для запроса пользовательской статистики POST /report/user_statistics.
           В тексте запроса передаем идентификатор пользователя, период с и по.
           Результат выполнения метода Guid запроса.

	2. Метод получения информации о запросе GET /report/info.
	   Параметр Метод Guid запроса.
	   Ответ Json, в котором указан Guid запроса, процент выполнения запроса
	   и результат выполнения, если он есть.

Приложение должно обрабатывать запрос не быстрее, чем за Х миллисекунд.
(вынести конфигурационный файл, по умолчанию установка 60 секунд)
и процент обработки в зависимости от пройденного времени с момента создания запроса.
Если приложение перезагрузить, информация не должна быть потеряна.
