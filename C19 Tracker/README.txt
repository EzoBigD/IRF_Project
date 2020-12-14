A projekt neve C19 Tracker, ami egy trackin program Covidos betegekkel foglalkozó orvosok számára.
Fő célja a programnak, hogy le egyszerűsítse az orvosok munkáját és könnyedén dokumentálni tudják a kórházi történéseket.

A program egy lokális adatbázis adataival dolgozik, az adatbázis tartalmazza a betegek, az orvosok, a Kórház ágyainak és termeinek adatait.
Indításkor egy bejelentkezési ablak jelenik meg, megfelelő felhasználónév és jelszó beírása után betölti a main formot. (User1, 1111)

A Mainformom található mai dátum, óra egy logó, plusz a program kiírja a bejelentkezett felhasználó nevét, ezeket az adatokat egy külön classban tárolja a program. 
Emellett található egy menüsor, 5 gombbal ezek mindegyike egy különböző UserControlt tölt be a Formon található Panelre.

A Betegek oldalon be vannak töltve a Betegek adatai, ezeket lehet szerkeszteni, új beteget felvenni, a Mentés gomb lenyomásával lehet
ezeket a változtatásokat elmenteni. A Kiírás gomb lenyomásával, ki lehet írni az aktuális adatokat egy CSV fájlba. A Törlés gomb 
lenyomásával, pedig a már meggyógyult betegek adatait, lehet kitörölni.

Az Ágyak/Termek nevezetű oldal megmutatja hogy mely betegek, melyik ágyakon vannak jelenleg elhelyezve.
Az első funkció az egy szimpla keresési funkció az ágyakra és a betegekre vonatkozóan. Mindkettő esetben van 1 legördülő listánk, 
az ágyak esetében ki lehet választani az ágyszámot és betölti a mellette lévő Datagridview-ba az adott ágyra vonatkozó adatokat. 
A betegek esetében, pedig a beteg neve alapján mutatja meg a beteg ID-ját. Emellett van 2 táblázat az UC-n az egyik a szabad ágyakat 
mutatja a másik pedig a foglaltakat. A 3. funkció, pedig az update, itt lehet szerkeszteni az adatokat az Elhelyezés gomb lenyomásával, 
pedig elmenti a módosításokat.

Az Állapot oldalon, a betegek állapot feljegyzéseit, lehet megtalálni a felső tűblázatban, a beteg nevének kiválasztása után. 
Az alsó táblázat, pedig szerkeszthető, ott lehet új állapot feljegyzéseket regisztrálni a a Mentés gomb lenyomásával.

A Beosztás oldalon, az orvosok nevére lehet rákeresni és a listából való kiválasztás után a táblázat megjeleníti, az adott Orvos beosztását.

A Készlet oldal már nem a lokális adatbázis adatait tartalmazza, itt a felhasználó tud érkezett és felhasznált készletek adatit feljegyezni,
két különböző Datagridview-ba. A Textboxok lehet beírni a szükséges adatokat és Mentés gomb lenyomásával hitelesíteni. Ezeket az adatokat két
kólünböző classban tárolja a program.


