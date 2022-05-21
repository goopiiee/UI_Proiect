# Proiect PIU > Aplicatie pentru Gestionarea unui Inventar

## Cuprins :
* [Informatii](#informatii)
* [Tehnologii](#tehnologii)
* [Credite](#credite)


## Informatii
Aceasta aplicatie are ca scop gestionarea in format minimalist a unui inventar cuprinzand categorii precum:
* Useri
* Produse
* Comenzi
* Clienti

Utilizarea dintr-o perspectiva a unui user este usoara, intuitiva, organizata si seemless. Aplicatia foloseste un sistem de logare prin intermediul unui **UniqueUserID** oferit random intr-o raza de **(1000 - 9999)** la fiecare introducere a unui user in sistem de catre administrator. Doar administratorul are acces la seciunea **Useri** printr-un cod separat, fiind furnizat un mesaj de eroare la nerespectarea privilegiilor in prealabil.

La deschiderea aplicatiei, suntem dusi intr-un loginscreen, care arata astfel:

<img src="https://user-images.githubusercontent.com/75086843/169666086-f81f3521-fc68-4a12-8dc6-1b0b68edc65b.png" width="400" height="500"/>

Daca dorim sa ne logam fara sa introducem niciun UUID, primim urmatorul mesaj:

<img src="https://user-images.githubusercontent.com/75086843/169666163-1bc879de-c010-40ee-9f6c-3c2c3ed280a0.png" width="400" height="500"/>

La introducerea unui UUID incorect, primim unul dintre cele 2 mesaje de eroare:

<img src="https://user-images.githubusercontent.com/75086843/169666183-392f8d23-8e14-47b1-b3ec-507f23aeb7b8.png" width="400" height="500"/>

<img src="https://user-images.githubusercontent.com/75086843/169666195-a3e2a9c8-3b30-434b-bf06-7c0727504b22.png" width="400" height="500"/>

Meniul principal este simplu, colorat si usor de inteles:

![image](https://user-images.githubusercontent.com/75086843/169666301-6b8999e9-9910-424c-8e33-9e310281c62b.png)

Fiecare categorie este definita de o tema specifica bazata pe culoarea fiecarui buton, dupa cum urmeaza:

**Useri**

![image](https://user-images.githubusercontent.com/75086843/169666332-eed71da8-8cd2-4dd6-9f66-b84a22f764d3.png)

**Clienti**

![image](https://user-images.githubusercontent.com/75086843/169666341-7bf213fc-2842-418e-bf95-9ed7d56666fe.png)

**Produse**

![image](https://user-images.githubusercontent.com/75086843/169666372-57341a42-1933-44f2-a939-bd042fc8adff.png)

**Comenzi**

![image](https://user-images.githubusercontent.com/75086843/169666355-fb608412-f29c-4e54-8d2c-7526915cf63d.png)

Sistemul de logare dispune de functionalitati minime in ceea ce priveste validarea UUID-ului introdus de catre Utilizator sau Administrator. Dupa ce logarea a fost efectuata cu succes, celelalte categorii pot fi accesate cu usurinta, fiecare dispunand de:
* Functii pentru adaugarea unui item 
* Functii pentru modificarea unui item selectat
* Functii pentru stergerea unui item selectat

Fiecare fereastra pentru adaugarea datelor necesare fiecarui item in parte dispune de functionalitati minime in ceea ce priveste validarea datelor. Mesajul de eroare:
````
Datele trebuie sa fie complete! 
````
va fi prezent cat timp exista un camp necompletat in fereastra de adaugare din fiecare categorie in parte, observabil cu ajutorul urmatoarei imagini:

![image](https://user-images.githubusercontent.com/75086843/169666385-c9213154-ace8-4b8e-be99-7dc355bb24db.png)

Butonul de salvare este lipsit de functionalite cat timp mesajul de eroare este de asemenea prezent.

## Tehnologii
Pentru realizarea acestei aplicatii au fost folosite:
* Limbajul C#
* Framework-ul .NET 4.8
* Windows Forms

## Credite
Aplicatia a fost creata de:
> **Murarasu Matei - George, FIESC, Calculatoare, Anul 2** 
