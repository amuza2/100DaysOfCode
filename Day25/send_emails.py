import smtplib, ssl

user = "sender_mail@gmail.com"
password = "password"
receiver = "receiver_mail@gmail.com"
message = "This is a message from the sender"
context = ssl.create_default_context()

with smtplib.SMTP_SSL("smtp.gmail.com", 465, context=context) as server:
    server.login(user, password)
    server.sendmail(user, receiver, message)

    server.quit()