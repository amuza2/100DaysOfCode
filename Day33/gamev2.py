

class Creator:
    def __init__(self, HP, damage, defence):
        self.HP = HP
        self.max_HP = 100
        self.damage = damage
        self.defence = defence
        self.critical = 1
        self.penetration = 1
        self.exp = 0
        self.level = 1


    def attack(self, user):
        user.HP -= abs(user.defence - self.damage)

class Champion(Creator):

def attack_creature():
    enemies = int(input("how many creatures do you want to attack: "))
    n_enemies = enemies

    while True:
        print("*------------------------------*")
        print("*                              *")
        print("Creature is attacking you")
        print("Champion health:", champion.HP)
        for i in range(enemies):
            creature.attack(champion)
            print("Champion health after Atack:", champion.HP)
            if champion.HP <= 0:
                print("Champion Dead, creatures killed you")
                champion.HP = champion.max_HP
                break

        print("Champion is Attacking creature")
        print("Creature health", creature.HP)
        champion.attack(creature)
        if creature.HP<=0:
            n_enemies -= 1
            if n_enemies > 0:
                print("creature dead")
                creature.HP = 50
            else:
                print("all Creatures are dead, you won the battle")
                creature.HP = 50
                break

        print("Creature health after attack", creature.HP)
        print(f"Summary:\n\tChampion HP: {champion.HP}\n\tcreature HP: {creature.HP}")
        print("*                              *")
        print("*------------------------------*")

def level_up():
    pass 

def attak_boss():
    pass

champion = Creator(100, 20, 10)
creature = Creator(50, 15, 5)


def main():
    print("""
        1- Attack creatures
        2- Attack boss
        3- Exit
        """)
    q = int(input("What do you want to do: "))
    if q == 1:
        attack_creature()
    elif q == 2:
        attak_boss()
    else:
        pass

main()