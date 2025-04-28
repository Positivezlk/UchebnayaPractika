
def login(login, password):
    return 'Доступ открыт' if login == 'admin' and password == 'qwerty' else 'Ошибка'


log, password = input('Введите логин и пароль через пробел: ').split(' ')
print(login(log, password))
