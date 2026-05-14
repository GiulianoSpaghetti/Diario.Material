# Diario

:it: Made in Italy. Il primo prodotto maui ad utilizzare linq su avalonia con dialetto material ed internazionalizzato nel mondo ad usare le snackbar.

![Napoli-Logo](https://github.com/user-attachments/assets/802ba5f0-bade-46f6-a4ed-74526258b3f6)
![made in parco grifeo](https://github.com/user-attachments/assets/53db171f-cfc6-45d7-b46f-963e99723741)


## Diario.Material
 Un diario in avalonia con dialetto Material con sqlite integrato non crittato. Non usa il foglio di stile di google, ma usa il reactive ui di avalonia (si legge multithraded)
 
 Il database è interno ed è il file 
 
 su windows: %localappdata%\test.db
 
 su linux: $HOME/.local/share/test.db
 
 La differenza tra un database relazionale ed un database ad oggetti è che mysql consente di stabilire relazioni tra le entità (con  l'id), mentre un database ad oggetti conserva solo l'oggetto.


## Come installare

## Per unix

[![pling](http://numeronesoft.ddns.net:8080/images/pling.png)](https://www.pling.com/p/2296521/)


## Per windows
(da copiare in esegui)

    unigetui://giuliosorrentino&#46diario&#46avalonia


## Prerequisti

### Windows
https://winstall.app/apps/Microsoft.DotNet.DesktopRuntime.10

### Unix

https://learn.microsoft.com/it-it/linux/packages

Bisogna installare libice6 e libsm6 e bisogna precaricare freetype per farlo funzionare.

E' stato dimostrato che il software è perfettamente bilanciato, perché il binario viene ottimizzato dal dotnet.

Sapendo che il binario è per amd64, è possibile avviarlo con dotnet /opt/Diario/Diario.Desktop.dll sui sistemi arm64.

## Installazione col repository (GNU/Linux)
Per prima seguire la guida su https://learn.microsoft.com/it-it/dotnet/core/install/linux-debian

Poi seguire la guida su http://numeronesoft.ddns.net:8080

e poi update e install dario

Prerequisites:

https://learn.microsoft.com/en-us/linux/packages

Note: i pacchetti sono in IL, quindi in teoria basta reinstallare il software ad ogni update del dotnet e quindi avviare una volta il programma per ottenere il binario 

## Screenshots

## Su debian

![Schermata del 2025-01-25 18-21-39](https://github.com/user-attachments/assets/c38cdc21-7641-475b-9da1-0a45bdad6804)
![Schermata del 2025-01-25 18-21-44](https://github.com/user-attachments/assets/186606e0-5ece-46ab-a726-38ea6837fa26)
![Schermata del 2025-01-25 18-22-00](https://github.com/user-attachments/assets/f420b0cd-1645-44dc-b5e9-adb0757ed153)
![Schermata del 2025-01-25 18-22-08](https://github.com/user-attachments/assets/83e89800-52a7-417e-a86c-308bc5bd75a6)

## Su Windows

<img width="1431" alt="2025-01-25 (5)" src="https://github.com/user-attachments/assets/37f734f6-1efb-4365-be70-c940b9ce0098" />
<img width="1431" alt="2025-01-25 (4)" src="https://github.com/user-attachments/assets/10be54ad-3d2c-4606-a842-0d90d06755d8" />

## Video di pesentazione

https://youtu.be/tVXf1eiv9yM

## Donazione

http://numerone.altervista.org/donazioni.php
