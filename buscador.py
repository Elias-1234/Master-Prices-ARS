
import requests
nom=input("ingrese el nombre.txt de la lista de subdominios:\n")
wordlist = open(nom, 'r')
sirve=open("funcionando.txt","w")
entries = wordlist.readlines()
for entry in entries:
    url = f"https://{entry.strip()}"
    try:
        response = requests.get(url)
        print(f"Subdominio: {entry.strip()} - Estado: {response.status_code}")
       
        if response.status_code == 200:
        	sirve.write(entry)
    except:
        pass
sirve=open("funcionando.txt","r")
alt443=open("activo_443.txt","w")                                            
for sir in sirve.readlines():
	url = f'https://{sir.strip()}'
	response = requests.get(url)
	if 'alt-svc' in response.headers and 'h3=":443"' in response.headers['alt-svc']:
		alt443.write(sir)
sirve.close()
alt443=open("activo_443.txt","r")
print("\nHost con estado 200 ok y con alt-svc='443' \n")        
for alt in alt443:
	print(alt)
	
alt443.close()