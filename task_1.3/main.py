def sum_of_digits(n):
    return sum(int(digit) for digit in str(n))

number = 123
result = sum_of_digits(number)
print(f"Сумма цифр числа {number} = {result}")
