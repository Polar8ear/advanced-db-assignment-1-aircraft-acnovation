from google_images_search import GoogleImagesSearch
import os

keywords = []

with open('./keywords.txt', 'r') as keyword_file:
  keywords = [i.strip() for i in keyword_file.read().splitlines()]

def get_search_params(name):
  return {
    'q': name,
    'num': 1,
    'fileType': 'jpg',
    'rights': 'cc_publicdomain|cc_attribute|cc_sharealike|cc_noncommercial|cc_nonderived',
    'imgType': 'photo', ##
    'imgSize': 'medium', ##
  }

gis = GoogleImagesSearch('AIzaSyAaByeGkRIMhDVFxteBXpMoEK6xtJi5cA0', '963220c5314b743c4')

dir_path = r'./images'
# count = len([entry for entry in os.listdir(dir_path) if os.path.isfile(os.path.join(dir_path, entry))]) + 1
count = 1

for keyword in keywords:
  gis.search(search_params=get_search_params(keyword), path_to_dir=dir_path, custom_image_name=f'{count}.jpg')  # type: ignore
  count += 1

