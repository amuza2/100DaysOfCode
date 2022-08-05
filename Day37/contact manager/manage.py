from mongoengine import connect
from models import User, Contact
import bcrypt, asyncio, shutil
from faker import Faker
from tool import *


def create_user(username, password, email):
	user = User()
	user.username =  username
	user.password = bcrypt.hashpw(password.encode(), bcrypt.gensalt())
	user.email = email
	user.save()


def login_user(username, password):
	user = User.objects(username=username).first()
	if user:
		if bcrypt.checkpw(password.encode("utf-8"), user.password):
			return True
	return False


def query_user(username):
	user = User.objects(username=username).first()
	return user


def list_users():
	users = User.objects()
	return users


def delete_user(username):
	user = query_user(username)
	user.delete()


def contact_list():
	contact = Contact.objects()
	return contact

def create_contact(first_name,last_name,address,phone,mobile,email,gender,occupation,age,photo):
	contact = Contact()
	contact.first_name = first_name  
	contact.last_name = last_name  
	contact.address = address  
	contact.phone = phone  
	contact.mobile = mobile  
	contact.email = email  
	contact.gender = gender  
	contact.occupation = occupation  
	contact.age = age  
	contact.photo = photo  
	contact.save()


def create_contacts(num):
	fake = Faker()
	contacts = []
	for i in range(num):
		contact = Contact()
		contact.first_name = fake.first_name()
		contact.last_name = fake.last_name()
		contact.address = fake.address()
		contact.phone = fake.phone_number()
		contact.mobile = fake.phone_number()
		contact.email = fake.email()
		contact.age = fake.random_int(20,60)
		contact.gender = fake.random_element(["Male","Female"])
		contact.occupation = fake.profile()["job"]
		photo = asyncio.run(get_person()).split('/')[-1]
		contact.photo = "imageDB/" + photo
		shutil.move("images/"+photo, "imageDB/"+photo)
		contacts.append(contact)
	Contact.objects.insert(contacts)


def query_contact(email):
	contact = Contact.objects(email=email).first()
	return contact

def delete_contact(email):
	contact = query_contact(email)
	contact.delete()


def edit_contact(con,first_name,last_name,address,phone,mobile,email,gender,occupation,age,photo):
	contact = cont
	contact.first_name = first_name  
	contact.last_name = last_name  
	contact.address = address  
	contact.phone = phone  
	contact.mobile = mobile  
	contact.email = email  
	contact.gender = gender  
	contact.occupation = occupation  
	contact.age = age  
	contact.photo = photo  
	contact.save()

connect("Contact")