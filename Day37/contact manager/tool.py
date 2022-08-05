import PIL.Image
import io
import base64
from thispersondoesnotexist import get_online_person,save_picture,get_checksum_from_picture
import asyncio, shutil, time



def convert_to_bytes(file_or_bytes, resize=None):
	if isinstance(file_or_bytes, str):
		img = PIL.Image.open(file_or_bytes)
	else:
		try:
			img = PIL.Image.open(io.BytesIO(base64.b64decode(file_or_bytes)))
		except Exception as e:
			data_bytes_io = io.BytesIO(file_or_bytes)
			img = PIL.Image.open(data_bytes_io)

	cur_width, cur_height = img.size
	if resize:
		new_width, new_height = resize
		scale = min(new_height/cur_height, new_width/cur_width)
		img = img.resize((int(cur_width*scale), int(cur_height*scale)), PIL.Image.ANTIALIAS)
	bio = io.BytesIO()
	img.save(bio, format="PNG")
	del img
	return bio.getvalue()	


async def get_person():
	await asyncio.sleep(1)
	picture = await get_online_person()
	file_name = get_checksum_from_picture(picture) + ".jpeg"
	await save_picture(picture)
	des_file = "images/" + file_name
	shutil.move(file_name, des_file)
	return des_file
