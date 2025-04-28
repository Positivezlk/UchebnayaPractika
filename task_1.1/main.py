
def calculate_current_speed(boat_adrift_kph, boat_against_kph):
    return boat_adrift_kph - boat_against_kph


print(f'СКОРОСТЬ ТЕЧЕНИЯ: {calculate_current_speed(20, 16)} КМ/Ч')
