**1. Mi az ágens?** Bővebben értelmezve az ágens egy olyan entitás, amely az **érzékelői segítségével érzékeli a környezetét, és a beavatkozói \(****aktuátorok****\) segítségével megváltoztatja azt**. Maga az ágens az architektúrából \(a fizikai felépítésből\) és az ágens programból \(amely a viselkedést leíró függvényt megvalósítja\) tevődik össze.

**2. Fogalmak meghatározása**

- **Epoch** **szám:** Azt mutatja meg, hogy a neurális hálózat tanítása során a **teljes tanítóminta hányszor megy végig a hálózaton**.

- **Tanulási ráta \(learning** **rate****\):** Egy paraméter, amely azt szabályozza, hogy a gradiens csökkentés során a hálózat **milyen mértékben próbálja megtanulni az aktuális \(batch\) ismereteit**, azaz mekkora lépésközt alkalmazzon a súlyok frissítésekor.

- **Osztályozás:** Olyan felügyelt tanulási feladat, ahol a modell **kimenete egy diszkrét értékkészletből kerül ki \(kategóriák, osztályok\)**. Célja, hogy egy ismeretlen példáról a tulajdonságai alapján eldöntse, melyik ismert kategóriába tartozik \(pl. spam vagy nem spam\).

- **Csoportosítás \(****klaszterezés****\):** Olyan nem felügyelt tanulási feladat, amelynek során előzetesen nem ismert osztályokba, **hasonlóságuk alapján osztjuk csoportokba \(klaszterekbe\) az objektumokat**.

**3. A neurális hálók esetében a hiba visszaterjesztés során milyen paramétereket frissítünk?** A hiba visszaterjesztése \(backpropagation\) során a hálózat **súlyait \(w\)** és **eltolási értékeit \(****bias****, b\)** frissítjük annak érdekében, hogy minimalizáljuk a kimenet és az elvárt érték közötti hibát.

**4. Alfa\-béta vágás feladat logikája** Az Alfa\-béta vágás a Minimax algoritmus optimalizált változata, amely arra szolgál, hogy a játékfán ne kelljen minden ágat feleslegesen kiértékelni. Két fő értéket tartunk nyilván a csúcsoknál:

- **\(Alfa\):** Az a minimális érték, amit a MAX játékos már biztosan ki tud kényszeríteni \(kezdeti értéke\).

- **\(Béta\):** Az a maximális érték, amit a MIN játékos biztosan ki tud kényszeríteni \(kezdeti értéke\). **Levágások:** Ha egy MAX csúcs alatti vizsgálatnál kiderül, hogy az elért érték, akkor **béta vágás** történik \(mert a MIN ős ezt a lépést úgysem engedné\). Ha egy MIN csúcsnál teljesül a feltétel, akkor **alfa vágás** jön létre \(mert a MAX ős más, jobb utat fog választani\).

**5. Gráfos feladatok**

- **a, Heurisztikus költség \(\):** Ez a költség egy becslést ad arról, hogy az aktuális állapottól **milyen költséggel jár a célállapot elérése**.

- **b, Vak kereső algoritmusra példa és működése:** Ilyen például a **Szélességi keresés \(BFS\)**. Működésének lényege, hogy a kifejtetlen csúcsokat tartalmazó OPEN listát **sor \(FIFO\) adatszerkezetként** kezeli, tehát minden lépésben mindig a legrégebben a listára került csomópontot fejti ki \(így szintenként halad a fában\). A másik példa a **Mélységi keresés \(DFS\)**, amely **verem \(LIFO\)** adatszerkezetet használ, és a legutóbb bekerült csúcsot terjeszti ki.

- **c, A\* algoritmussal történő** **végigjárás****:** Az A\* algoritmus minden csomópontot az kiértékelő függvény alapján vizsgál meg, ahol az eddig megtett út valós költsége, a célállapotig becsült hátralévő távolság. Az OPEN lista ez alapján az érték alapján van rendezve, és a kereső **minden lépésben a legkisebb értékű elemet terjeszti ki**.

**6. Táblázat kitöltése a 4 algoritmussal**

- **Iteratívan frissíti az összeset:** Ez az állítás a **PSO \(Részecske\-raj optimalizálás\)** és a **Genetikus algoritmus** modellekre igaz, mivel ezek populáció alapú keresők, amik lépésről lépésre egy teljes egyedhalmazzal/rajjal dolgoznak és frissítik őket.

- **Lehet rosszabb állapot:** Erre a **Szimulált lehűtés \(****Simulated** **annealing****\)** a jó válasz. A lokális maximumok elkerülése érdekében ez az algoritmus egy \(időben exponenciálisan csökkenő\) valószínűséggel képes arra, hogy olyan szomszédba lépjen, amelynek a célfüggvény\-értéke rosszabb az aktuálisnál.

- **Keresztezés és mutáció művelet:** Kizárólag a **Genetikus algoritmusra** igaz, amely a biológiából vett természetes kiválasztódás analógiájára építve ezen két művelettel hoz létre új generációkat.

**7. Genetikus algoritmusban az egyed reprezentációja** A genetikus algoritmusokban egy egyed magát a lehetséges megoldást/állapotot jelöli, amelyet egy **véges ábécén értelmezett kódsorozattal \(füzérrel\)**, az úgynevezett **genetikus kóddal** reprezentálunk. Például a 8\-királynő probléma esetén az egyed reprezentálható egy 8 számjegyből álló számsorozattal \(pl. 6 7 2 4 7 5 8 8\), ami azt mutatja, hogy az egyes oszlopokban hányadik sorban van a királynő.

**8. Passzív megerősítéses tanulás kifejtése** A passzív megerősítéses tanulás során az ágens **stratégiája \(\) már rögzített**, tehát egy adott állapotban nem kell döntést hoznia az akcióról, mert mindig a stratégia által meghatározott lépést hajtja végre. A tanulás célja nem az optimális útvonal kitalálása, hanem az **egyes állapotok hasznosságának \(állapot\-értékeinek\) a megtanulása** a környezettől kapott jutalmak vagy büntetések alapján. Ezt például a közvetlen hasznosságbecslés \(Direct Utility Estimation\) vagy időbeli különbség tanulás \(TD\) algoritmusokkal érhetjük el.

