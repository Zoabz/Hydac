# Systemoperationskontrakt (SOC): OpretBesøg

| Felt | Hvad skriver vi |
| :---- | :---- |
| Nummer | CO1 |
| Operation | OpretBesøg(navn, firma, ankomsttid, afgangstid, dato, ansvarlig) |
| Krydsreferencer | Use case: UC02 Opret besøg.<br>SSD: UC02 - Opret Gæstebesøg. |
| Forudsætninger | Medarbejderen er logget ind.<br>Der findes en Medarbejder-instans, som svarer til *ansvarlig*. |
| Slutbetingelser | 1. En Besøg-instans *b* blev oprettet (instansoprettelse).<br>2. *b*.dato blev sat til *dato*, *b*.forventet ankomst blev sat til *ankomsttid*, og *b*.forventet afrejse blev sat til *afgangstid* (attributændring).<br>3. En Gæst-instans *g* blev oprettet (instansoprettelse).<br>4. *g*.navn blev sat til *navn*, *g*.firma blev sat til *firma*, og *g*.gæstID blev sat til en ny, unik indtjekningskode (attributændring).<br>5. *b* blev associeret med *g* (association dannet).<br>6. *b* blev associeret med den Medarbejder, som svarer til *ansvarlig* (association dannet).<br>7. *b*'s Besøgs_Status blev sat til "Ikke Tjekket Ind" (attributændring). |
