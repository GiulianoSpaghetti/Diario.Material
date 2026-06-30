[![.NET AVALONIA Build](https://github.com/GiulianoSpaghetti/Diario.Material/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/GiulianoSpaghetti/Diario.Material/actions/workflows/dotnet-desktop.yml)

# Diario

:it: Made in Italy. Il primo prodotto maui ad utilizzare linq su avalonia con dialetto material ed internazionalizzato nel mondo ad usare le snackbar.

Il primo diario ad essere a norma secondo le leggi italiane

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

    unigetui://DesktopRuntime
    
installare il windows desktopruntime 10

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

## Manuale di istruzioni
https://photos.app.goo.gl/UhkQT6XqXntW6tDSA

## Donazione

http://numerone.altervista.org/donazioni.php
