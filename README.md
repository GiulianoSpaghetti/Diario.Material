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

## Su GNU/Linux

Seguite le istruzioni su http://numeronesoft.ddns.net per installare il repository e poi installate il programma diario.


Prerequisiti:

https://learn.microsoft.com/en-us/linux/packages

Note: i package sono system indpedent ed IL, per cui in teoria è sufficiente reinstallare il pacchetto ad ogni aggiornamento del desktop runtime ed avviare il programma una volta per ottenere il codice binario aggiornato.
Ovviamente se aggiornano avalonia bisogna ricompilare.


## Su Windows

[![winget](https://user-images.githubusercontent.com/49786146/159123313-3bdafdd3-5130-4b0d-9003-40618390943a.png)](https://marticliment.com/wingetui/share?pid=GiulioSorrentino.Diario&pname=Diario&psource=Winget:%20winget)

Prerequisiti:

https://winstall.app/apps/Microsoft.DotNet.DesktopRuntime.9

Note: i package sono system indpedent ed IL, per cui in teoria è sufficiente reinstallare il pacchetto ad ogni aggiornamento del desktop runtime ed avviare il programma una volta per ottenere il codice binario aggiornato.
Ovviamente se aggiornano avalonia bisogna ricompilare.

## Internazionalizzazione

Aprire il file MainWindows.axaml, all'interno del tag MainWindow.Resources ci sono qulli che vengono chiamati dizionari.
BIsogna copiare un dizioario ed aggiungrlo alla fine dei dizionari, chiamarlo con la denominazione internazionale a due carattri ella lingua (it per italiano, pt per portoghese, es per spagnolo e via dicendo) e bisogna tradurre tutto qullo che è il contenuto del tag x:string, non il parametro.

## Screenshots

## Su debian

![Schermata del 2025-01-25 18-21-39](https://github.com/user-attachments/assets/c38cdc21-7641-475b-9da1-0a45bdad6804)
![Schermata del 2025-01-25 18-21-44](https://github.com/user-attachments/assets/186606e0-5ece-46ab-a726-38ea6837fa26)
![Schermata del 2025-01-25 18-22-00](https://github.com/user-attachments/assets/f420b0cd-1645-44dc-b5e9-adb0757ed153)
![Schermata del 2025-01-25 18-22-08](https://github.com/user-attachments/assets/83e89800-52a7-417e-a86c-308bc5bd75a6)

## Su Windows

<img width="1431" alt="2025-01-25 (5)" src="https://github.com/user-attachments/assets/37f734f6-1efb-4365-be70-c940b9ce0098" />
<img width="1431" alt="2025-01-25 (4)" src="https://github.com/user-attachments/assets/10be54ad-3d2c-4606-a842-0d90d06755d8" />

## Donazione

http://numerone.altervista.org/donazioni.php
