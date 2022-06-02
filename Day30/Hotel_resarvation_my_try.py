"""
create a tool that deals with customer reservation in a hotel
where we give rooms depends on how many we have
rooms are paid or counter per night
we offer promotion cards that we reduce from the fees
create a history of customers

"""

from datetime import datetime
from pprint import pprint

class Resarvation:
    people_counter = 0
    rooms = {}
    room_situation = {}
    number_of_available_rooms = 0
    people_in_room = {}
    history = {}
    for i in range(1, 4):
        room_situation[str(i)] = "available"

    def __init__(self):
        pass

    def add_customer(self, name, identity_card, room_num):
        date = datetime(2022,5,28).strftime("%A %Y-%m-%d")
        self.people_counter += 1
        full_name = [name, identity_card, date]
        self.room_situation[str(room_num)] = "bussy"
        self.set_room(room_num,full_name)


    def set_room(self,num, full_name):
        if str(num) in self.rooms.keys():
            self.people_in_room[str(num)] += 1
            self.rooms[str(num)] += [{'full name':full_name[0],"identity_card":full_name[1],"entry date":full_name[2]}]

        else:
            self.people_in_room[str(num)] = 1
            self.rooms[str(num)] = [{'full name':full_name[0],"identity_card":full_name[1],"entry date":full_name[2]}]


    def show_room_details(self, num):
        print(f"Room number: {num}\n")
        for i in self.rooms[str(num)]:
            for k,v in i.items():
                print(f"\t\t{k}: {v}")  
        if self.rooms[str(num)] == []:
            print("Empty room")


    def room_avialability(self):
        for k,v in self.room_situation.items():
            print(f"room number: {k}, Situation: {v}")

        for room in self.room_situation.values():
            if room == "available":
                self.number_of_available_rooms += 1

        if self.number_of_available_rooms == 0:
            print("No available rooms")  


    def all_customer_in_hotel(self):
        print(f"There are {self.people_counter} people in the hotel")      


    def leavers(self,num, name):
        self.room_situation[str(num)] = "available"
        self.people_in_room[str(num)] -= 1
        
        # find index of the name 
        c = 0
        index_of_customer = None
        for i in self.rooms[str(num)]:
            for j in i.values():
                if j == name:
                    index_of_customer = c
                    break
            c += 1
        # calculate and show payment
        self.payment(num,name,index_of_customer)
        # add customer to history - archived
        full_name = self.rooms[str(num)][index_of_customer]["full name"]
        identity_card = self.rooms[str(num)][index_of_customer]["identity_card"]
        entry_date = self.rooms[str(num)][index_of_customer]["entry date"]
        leave_date = datetime.today().strftime("%A %Y-%m-%d")
        item = [{"full name":full_name,"identity card":identity_card,"entry date":entry_date,"leave date":leave_date}]
        if str(num) not in self.history.keys(): 
            self.history[str(num)] = item 
        else:
            self.history[str(num)] += item

        # remove leaver customer from rooms list
        del self.rooms[str(num)][index_of_customer]



    def payment(self,num,name,index):
        night_fee = 1000
        for i in self.rooms[str(num)]:
            if i["full name"] == name:
                entry = i["entry date"]
        new_entry = datetime.strptime(entry, "%A %Y-%m-%d")
        a = datetime(new_entry.year, new_entry.month, new_entry.day)
        leaving = datetime.today().strftime("%A %Y-%m-%d")
        new_entry = datetime.strptime(leaving, "%A %Y-%m-%d")
        b = datetime(new_entry.year, new_entry.month, new_entry.day)
        days_stayed = b - a
        if days_stayed.days == 0:
            days_stayed = 1
        days_stayed = days_stayed.days
        fees_to_pay = days_stayed * night_fee
        print(f"fees to pay: {fees_to_pay} DZ") 


customer = Resarvation()
customer.add_customer("med", "1234", 1)
customer.add_customer("zim", "5678", 1)
customer.add_customer("ari", "4321", 2)
customer.add_customer("galaxy", "9876", 3)
customer.leavers(1, "med")
customer.show_room_details(1)
# print(customer.history)