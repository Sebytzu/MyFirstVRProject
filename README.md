# My First VR Project

Un proiect de Realitate Virtuală (VR) realizat în Unity folosind OpenXR și XR Interaction Toolkit. Aplicația este un mini-joc de bowling: jucătorul apucă o bilă, o aruncă pe pistă și încearcă să doboare cele 10 popice.

Când un popic se înclină peste un anumit unghi, scriptul îl marchează ca fiind căzut, îl colorează în verde, actualizează scorul afișat pe peretele din spate și îl face să dispară după scurt timp. Jocul poate fi testat și fără headset, folosind XR Device Simulator.

## Video Demo
https://github.com/user-attachments/assets/af9be4d1-1eaa-4b1b-a0ab-149c06ec5eb7
https://github.com/user-attachments/assets/4dbe20aa-967a-4f60-af0d-c05bee4177e7

## Tehnologii folosite
* **Unity 3D** (versiunea 6.3 LTS)
* **OpenXR** (pentru runtime-ul VR)
* **XR Interaction Toolkit 3.3.2** (pentru Grab Interactable și interactori)
* **XR Device Simulator** (pentru testare fără headset)
* **TextMeshPro** (pentru afișarea scorului în UI)
* **Blender 5.2** (pentru modelarea, texturarea și animarea mâinilor)
* **C#** (pentru logica de detectare a popicelor căzute, scor, limitarea aruncărilor și animarea mâinilor)

## Funcționalități principale
* **Apucarea și aruncarea obiectelor:** Bila de bowling poate fi prinsă și aruncată prin XR Grab Interactable.
* **Detectarea popicelor căzute:** Calculul înclinării fiecărui popic în timp real, cu feedback vizual (culoarea devine verde).
* **Scor în timp real:** Numărul de popice dărâmate este afișat pe un panou World Space TextMeshPro.
* **Efecte vizuale:** Sistem de particule (confetti) la STRIKE.
* **Mâini 3D personalizate:** Mâinile jucătorului sunt un model 3D făcut în Blender (5 degete, UV unwrap, textură aplicată și manșetă albastră), exportat în FBX și atașat pe controllerul stâng și drept. Mâna stângă este oglindită prin Scale X = -1.
* **Animații de mână:** Două animații create în Blender, **Grab** (degetele mijlociu, inelar și mic se închid) și **Trigger** (arătătorul se îndoaie), controlate din Unity printr-un Animator cu Blend Tree.

## Controale în simulator
* **Trigger:** comută pe Controller (Tab), ține **T** (stânga) sau **Y** (dreapta) și dă click stânga.
* **Grab:** tasta **G**.

## Limitări cunoscute
În XR Device Simulator, tasta G închide ambele mâini deodată, deoarece simulatorul nu are un buton de grip separat pentru fiecare controller. Este doar o limitare vizuală a simulatorului; pe un headset real, grip-ul vine din butonul fiecărui controller și funcționează separat pe fiecare mână.
