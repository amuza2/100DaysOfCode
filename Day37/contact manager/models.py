from mongoengine import *
from mongoengine_pagination import DocumentPro


class User(Document):
	username = StringField(required=True,unique=True)
	password = BinaryField(required=True)
	email = EmailField(required=True, unique=True)


class Contact(DocumentPro):
	first_name = StringField(required=True)
	last_name = StringField(required=True)
	address = StringField()
	phone = StringField()
	mobile = StringField()
	email = EmailField(required=True,unique=True)
	gender = StringField()
	occupation = StringField()
	age = IntField()
	photo = StringField()