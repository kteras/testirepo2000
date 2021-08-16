# olio-ohjelmointi-2021-syksy
Gradia olio-ohjelmointi kurssin arkisto (repository).

Jokainen tehtävä sijoitetaan tänne omaan hakemistoonsa ja jokainen kurssilainen käyttää omaa haaraa (branch).

# Git ohje

**HUOM! Perjantaina 13. elokuuta Github muutti kirjautumisvaatimuksiaan ja login/salasana kirjautuminen ei enää toimi. Teemme kaikille SSH avaimet Maanantaina 16. elokuuta. Kopioin ohjeen myös tänne.

# Repositorion kloonaaminen omalle koneelle
Tämä tehdään vain kerran kurssin aluksi. Jokaiselle kurssilaiselle on lähetetty kutsu tulla kolloboraattoriksi tähän repositorioon.

1. Avaa GitBash hakemistoon jonka alle haluat tehtäväkansion. Tämä onnistuu klikkaamalla oikealla hiirennapilla hakemistoa Windows Explorerissa ja valitsemalla "Avaa GitBash tässä."
2. kirjoita komento ```git clone git@github.com:kteras/olio-ohjelmointi-2021-syksy.git```

# Oman haaran (branch) luominen
Tämäkin tehdään aluksi vain kerran.
1. Avaa GitBash tehtäväkansioon ```olio-ohjelmointi-2021-syksy.git``` ellei se ole jo auki kyseisessä hakemistossa.
2. kirjoita komento ```git checkout -b <omanimi>``` jossa omanimi on oma nimesi tai tunnuksesi ilman ääkkösiä tai välilyöntejä. Esim. ```git checkout -b karrit```.

# Uusien tehtävänantojen hakeminen
Kaikki tämä tehdään GitBashissä harjoitustehtävän hakemistossa.
1. ```git status``` - tarkista että olet omassa haarassa (branch), ja että sinulla ei ole avoimia muutoksia (jotka näkyvät punaisena tai vihreänä). Mikäli niitä on, tallenna ne ensin komennoilla ```git add .```, ```git commit -m "Muutokset talteen.".
2. ```git checkout main```
3. ```git pull```
4. ```git checkout <omanimi>``` - vaihda omanimi oman haarasi nimeksi.
5. ```git merge main```

# Oman työn palauttaminen
Kaikki tämä tehdään GitBashissä harjoitustehtävän hakemistossa.
1. ```git status``` - tarkista että olet omassa haarassa (branch), ja että sinulla ON avoimia muutoksia (jotka näkyvät punaisena).
2. ```git add .```
3. ```git status``` - tarkista että muutokset näkyvät nyt vihreinä.
4. ```git commit -n "Tehtävän <se ja se> palautus." - laita palauttamasi tehtävän nimi ja/tai numero kommenttiin.
5. ```git push``` 

# Muita hyödyllisä komentoja GitBashissä

## ```cd```
Siirtyy toiseen hakemistoon, esim. ```cd 00_Hevonen``` siirtyy hakemistoon ```00_Hevonen```

## ```ls```
Listaa nykyisen hakemiston sisällön, eli tässä hakemistossa olevat tiedostot ja hakemistot.

## ```git status```
Kertoo missä haarassa (branch) olet, ja mitä tiedostoja olet muokannut, mitkä on merkitty (staged) lisättäväksi repositorioon. Lisäksi komento kertoo onko oma kopiosi haarasta samalla tasolla kuin GitHub palvelimella oleva, vai onko sinulla paikallisia muutoksia joita et ole vielä työntänyt (push) palvelimelle.



