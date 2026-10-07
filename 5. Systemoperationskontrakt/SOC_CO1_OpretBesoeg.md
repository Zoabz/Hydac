# Systemoperationskontrakt: opretBesøg

| Felt | Hvad skriver vi |
|---|---|
| Nummer | CO1 |
| Operation | opretBesøg(navn, firma, dato, forventetAnkomsttid, forventetAfgangstid, lokale, ansvarlig) |
| Krydsreferencer | Use case: UC02 Opret besøg<br>SSD: UC02 - Opret besøg |
| Forudsætninger | • Medarbejderen er logget ind.<br>• Der findes en Medarbejder-instans, hvis brugernavn svarer til *ansvarlig*. |
| Slutbetingelser | 1. En Besøg-instans *b* blev oprettet (instansoprettelse).<br>2. *b*.dato blev sat til *dato*, *b*.forventet ankomsttid blev sat til *forventetAnkomsttid*, *b*.forventet afgangstid blev sat til *forventetAfgangstid*, og *b*.lokale blev sat til *lokale* (attributændring).<br>3. En Gæst-instans *g* blev oprettet (instansoprettelse).<br>4. *g*.navn blev sat til *navn*, og *g*.firma blev sat til *firma* (attributændring).<br>5. *b* blev associeret med *g* (association dannet).<br>6. *b* blev associeret med den Medarbejder, hvis brugernavn svarer til *ansvarlig* (association dannet).<br>7. *b*.status blev sat til "Ikke Tjekket Ind", og *b*.indtjekningskode blev sat til en ny, unik indtjekningskode (attributændring). |
