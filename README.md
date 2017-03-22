# Tim10-NAM
<p align = "center">
<img src = "http://vignette1.wikia.nocookie.net/logopedia/images/2/23/Pet-society-logo.png/revision/latest?cb=20110817212915">
</p>
Članovi tima:

1. Nađa Žilić

2. Adna Tucak

3. Mirza Muharemović


# Opis teme:

Pet Society je sistem koji pomaže u poslovanju veterinarske stanice u sklopu koje se nalazi pet shop. 
Sistem je osmišljen tako da odgovori na zadane zahtjeve vlasnika: 
-	modernizacija poslovanja uz pomoć informacionih tehnologija
-	učiniti poslovanje jednostavnijim i pristupačnijim
-	smanjenje troškova zapošljavanja
-	proaktivne povratne informacije za klijente
-	smanjenje potreba za administracijom
Dakle, glavni cilj ovog sistema jeste da omogući klijentima zakazivanje pregleda za ljubimce, te kupovinu u pet shopu u elektronskom obliku. Pored toga, sistem će omogućiti zaposlenima u ovoj ustanovi lakše poslovanje. Naime, ukoliko je sistem korišten od strane veterinara ili medicinske sestre/brata, tada će biti omogućen brz pristup svim relevantim informacijama o pacijentima,  olakšano vršenje evidencije pregleda i potvrđivanja slobodnih termina, efikasniji način komunikacije sa pacijentima,etc. Ukoliko je, pak, sistem korišten od strane prodavača u pet shopu, tada će biti olakšan proces prodaje i sistem će u tom slučaju raditi kao fiskalna kasa.


# Procesi:

# Prijava na sistem

Korisnik se pomoću odgovarajućeg username-a i passworda loguje na sistem. U zavisnosti od toga koja uloga mu je dodijeljena, pružaju mu se različite opcije, pomoću odgovarajućih formi.

# Dodavanje osoblja

Admin nakon instaliranja sistema dodaje sve potrebne informacije o uposlenima i daje im određene privilegije.
Registrovanje novih klijenata
Nakon što se klijent odluči učlaniti u veterinarsku stanicu, medicinska sestra popunjava formular sa potrebim informacijama za identifikaciju korisnika i dodaje ga u bazu podataka. Potom mu se dodjeljuje odgovarajući username, šifra, članska kartica sa identifikacijskim brojem, te mu se na e-mail adresu šalje instalacija softvera.

Online zakazivanje pregleda

Da bi klijent zakazao pregled online putem, potrebno je da bude učlanjen. Vrši prijavu na sistem sa podacima koji su mu dodijeljeni prilikom učlanjenja. Otvara se prozor na kojem su prikazani slobodni termini za pregled ljubimaca. Klikom na željeni termin, zahtjev se šalje u veterinsku stanicu, te nakon odobravanja od strane medicinske sestre, se označava kao zauzet i upisuje u raspored veterinara. Da bi verifikacija bila kompletna, 48h prije zakazanog termina klijent dobija poruku kao podsjetnik. Ukoliko ne odgovori na istu, termin se poništava. U suprotnom, termin ostaje zauzet.

Online kupovina

Da bi klijent vršio online kupovinu, potrebno je da bude učlanjen. Vrši prijavu na sistem sa podacima koji su dodijeljenji prilikom učlanjenja. Otvara se prozor na kojem su prikazani proizvodi koji se nalaze u ponudi. Klijent pritiskom na odgovarajuće proizvode, iste dodaje u košaricu. 
Nakon odabira proizvoda, klikom na dugme, otvara se interfejs za unos osnovnih podataka i broja kreditne kartice, nakon čega se vrši  validacija istih. Zatim se ti podaci šalju eksternom sistemu za autorizaciju kartica koji treba da odobri ili odbije transakciju plaćanja.

Upravljanje zalihama

Prodavač u pet shopu vrši ažuriranje o stanjima zaliha. Prilikom svake kupovine i nabavke nove robe dolazi  do promjene stanja zaliha. Ukoliko  nestane neki proizvod iz magacina, radnik prima informaciju o tome da taj proizvod više nije na stanju i tada mu se nudi opcija potpunog uklanjanja proizvoda iz ponude ili nabavka. Kada se vrši nabavka, proizvodu se dodaje oznaka da nije na stanju. 

Potvrda termina

Da bi medicinska sestra izvršila potvrdu zakazanog termina, potrebno je da bude prijavljena na sistem. 
Ukoliko je klijent poslao online zahtjev, provjerava da li je moguće ispuniti zahtjev. Ukoliko jeste, dodaje ga u raspored navedenog veterinara i šalje obavijest o uspješno zakazanom terminu. Ukoliko nije,klijent  se obavještava da odabere novi termin.
U slučaju da klijent želi zakazati termin uživo, medicinska sestra mu nudi dostupne termine. Nakon odabira termina, pomoću kartice koja se skenira, popuni se forma potrebna za zakazivanje termina.

Prodaja 

Da bi radnik u pet shopu izvršio prodaju proizvoda, potrebno je da bude prijavljen na sistem. 
Prodaja je omogućena kako uživo, tako i online putem.
Ukoliko je riječ o kupovini uživo, klijent dolazi na kasu sa odabranim artiklima. Zatim prodavač  pomoću skener mašine, dodaje svaki od proizvoda na račun. Nakon toga, vrši se štampanje računa i plaćanje. Plaćeni iznos se dodaje na bankovni račun prodavnice.
U slučaju da je korisnik izvršio online kupovinu, prodavač vrši potvrdu iste. Nakon toga šalje poruku kupcu sa podacima o isporuci pošiljke.

Vršenje pregleda

Da bi veterinar izvršio pregled, potrebno je da bude prijavljen na sistem. 
Veterinar bira trenutnog pacijenta koji se nalazi na rasporedu i otvara pripadajući medicinski karton. Nakon što izvrši pregled životinje, ažurira karton  tako što upisuje podatke o pregledu.

Registrovanje ljubimaca

Da bi medicinska sestra izvršila registraciju ljubimca potrebno je da bude prijavljena na sistem. 
Medicinska sestra upisuje identifikacijski broj klijenta, nakon čega se otvara prozor u koji upisuje relevantne podatke i fotografiše životinju. Zatim navede podatke spašava u bazu podataka.
Online komunikacija
Omogućena je komunikacija između uposlenika i klijenata pomoću messengera.

Funkcionalnosti:

•	Mogućnost prodaje opreme za ljubimce

•	Mogućnost online prodaje

•	Mogućnost lakše evidencije asortimana pet shopa

•	Mogućnost online zakazivanja pregleda 

•	Mogućnost komunikacije sa veterinarom

•	Mogućnost evidencije pregleda i pacijenata na jako jednostavan način

•	Mogućnost prijave sa različitim privilegijama (veterinar,prodavač,medicinska sestra..)

•	Mogućnost registrovanja klijenata (članska kartica, verifikacija pomoću maila)

•	Mogućnost registrovanja ljubimaca

•	Mogućnost fotografisanja ljubimaca

Akteri:

Administrator 

Osoba koja instalira sistem i  ima pristup svim dijelovima sistema. U slučaju da dođe do kvara dužan je izvršiti popravku istog.

Veterinar

Osoba koja radi u veterinarskom centru, te vrši pregled životinja i istima ažurira medicinske kartone.

Prodavač

Osoba koja radi u pet shopu i vrši prodaju artikala. Vodi evidenciju o stanjima proizvoda u shopu. Vrši nabavku istih.

Medicinska sestra

Osoba koja radi u veterinarskom centru. Vrši dodavanje novih klijenata i njihovih ljubimaca, kontroliše zakazivanje termina za preglede.

Klijent 

Osoba koja nakon učlanjivanja, dobija account i koristi aplikaciju za online trgovinu u pet shopu i lakše zakazivanje termina pregleda, odnosno lakšu i bržu komunikaciju sa veterinarom.

