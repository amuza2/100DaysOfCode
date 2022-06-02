class Client:
    
    def __init__(self, name, identity_card, promo_code):
        self.name = name
        self.identity = identity_card
        self.promo_code = promo_code


    def update_client_info(self, new_name,new_identity,new_promo_code):
        self.name = new_name
        self.identity = new_identity
        self.promo_code = new_promo_code


    def customer_details(self):
        print(f"name: {self.name}")
        print(f"identity card: {self.identity}")
        print(f"promo code: {self.promo_code}")


class Hotel:
    
    def __init__(self, arooms, ageusts):
        self.arooms = arooms
        self.ageusts = ageusts
        self.people_in_hotel = {}


    def add_reservation(self, client, nroom, ngeust, ndays):
        client.nroom = nroom
        client.ngeust = ngeust
        client.ndays = ndays


        if client.name not in self.people_in_hotel:
            if nroom<self.arooms or ngeust<self.ageusts:
                self.people_in_hotel[client.name] = [client.name,client.identity,client.promo_code]
                self.arooms -= nroom
                self.ageusts -= ngeust
                print(f"{client.name} now has a reservation.")
        else:
            print(f"{client.name} geust already has a reservation.")




    def capacity(self):
        print(f"There are {self.arooms} rooms left and {self.ageusts} guests left")


    def bill(self,client, rate):
        if client.promo_code == 10:
            cost = (rate * client.ndays * client.ngeust)*0.9
        elif client.promo_code == 20:
            cost = (rate * client.ndays * client.ngeust)*0.8
        else:
            cost = rate * client.ndays * client.ngeust    
        print("Cost to pay: "+ str(cost))



hotel = Hotel(50, 150)
joe = Client("med", "12344", 10)
hotel.add_reservation(joe, 2, 4, 2)
joe.update_client_info("mid","987",20)
joe.customer_details()
# hotel.bill(joe, 10000)
# customer_2 = Client("zer", "4567", 20)
# hotel.add_reservation(customer_2, 10, 20)