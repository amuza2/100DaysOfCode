from datetime import datetime, timedelta

class Client:

    def __init__(self, name, phone):
        self.name = name
        self.phone = phone
        self.date = datetime.strptime(datetime.now().strftime("%Y %m %d"),"%Y %m %d")


    def update_info(self, name, phone, date):
        self.name = name
        self.phone = phone
        date = date.split()
        self.date = datetime(int(date[0]), int(date[1]), int(date[2]))


class Flat:

    def __init__(self):
        self.fees = 20000
        self.people_in_flat = {}
        self.days_in_month = 30

    def set_attribute(self,key,value):
        self.people_in_flat[key].update({str(value):value})

    def add_person(self, client):
        # set_attribute(client.name, client)
        self.people_in_flat[client.name] = {"name":client.name,"phone":client.phone,"date":client.date}
        self.new_c = client
        print(f"Client {client.name} has been added")

    def bill(self):
        part = self.fees / len(self.people_in_flat.keys())

        for k in self.people_in_flat.keys():
            # days_in_flat = datetime(v["date"].year, v["date"].month+1, 1) - v["date"]
            days_in_flat = datetime(self.people_in_flat[k]["date"].year, self.people_in_flat[k]["date"].month+1, 1) - self.people_in_flat[k]["date"]            
            cost = (part * (days_in_flat.days-1)) // self.days_in_month
            # set_attribute(k,cost)
            self.people_in_flat[k].update({str("cost"):cost})
            print(f"{k} spent {days_in_flat.days-1} days, he has to pay: {cost}")

        # print(self.people_in_flat.__dict__)
