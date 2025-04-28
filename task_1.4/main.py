class Animal:
    def __init__(self, name, sex, age):
        self.name = name
        self.sex = sex
        self.age = age

    def make_sound(self):
        raise NotImplementedError("Подклассы должны реализовывать этот метод")

class Dog(Animal):
    def __init__(self, name, sex, age):
        super().__init__(name, sex, age)

    def make_sound1(self):
        return "Гав!"
    
    def make_sound2(self):
        return "Тяв!"

class Owner:
    def __init__(self, name, age):
        self.name = name
        self.age = age
        self.pets = []

    def adopt_pet(self, pet: Animal):
        self.pets.append(pet)

    def show_pets(self):
        for pet in self.pets:
            print(f"{pet.name} - {pet.sex}, {pet.age} лет")




my_dog = Dog("Бобик", "Мужской", 7)
owner1 = Owner("Иван", 30)
owner1.adopt_pet(my_dog)
owner1.show_pets()
print(f"Мою собаку зовут: {my_dog.name}, её пол: {my_dog.sex}, её возраст: {my_dog.age}. Она говорит: {my_dog.make_sound1()}, но иногда говорит: {my_dog.make_sound2()}")
