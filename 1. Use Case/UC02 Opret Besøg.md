# **✅**Use case : Opret besøg

| Felt | Hvad skriver vi |
| :---- | :---- |
| Nummer | UC02 |
| Use case navn | Opret besøg |
| Virkefelt | HYDACs komme-gå-system |
| Niveau | Brugermål |
| Primær aktør | Medarbejder |
| Mål | Medarbejderen registrerer et aftalt besøg, så receptionen ved, hvem der kommer, hvornår, og hvem der har ansvaret for gæsten. |
| Interessenter | Medarbejder: Vil hurtigt kunne oprette besøget uden papirarbejde. Gæst: Vil blive taget imod hurtigt uden at skulle skrive sig ind i en papir gæstebog. Reception: Vil have en korrekt og læsbar liste over dagens forventede gæster. HYDAC: Vil kunne dokumentere, hvem der har besøgt virksomheden, hvornår, og hvem der var ansvarlig. |
| Før-tilstand | Medarbejderen er oprettet i systemet (UC01). Medarbejderen er logget ind. Medarbejderen har aftalt et besøg med gæsten. |
| Efter-tilstand | Besøget er gemt med gæstens navn, firma, dato, forventet ankomsttid, forventet sluttid og ansvarlig medarbejder. Besøget har status "Ikke Tjekket Ind" og vises på gæstelisten for den pågældende dato. |
| Hovedscenarie | Medarbejderen vælger at oprette et nyt gæstebesøg. Systemet beder om gæstens navn, firma, dato, forventet ankomsttid, forventet sluttid samt den ansvarlige. Medarbejderen indtaster de efterspurgte oplysninger.  Systemet gemmer besøget i listen. |
| Udvidelser | Medarbejderen fortryder Systemet gemmer ikke besøget og vender tilbage til menuen. Navn eller firma er ikke udfyldt Systemet viser fejlen "Navn og firma skal udfyldes". Dato eller tid har forkert format Systemet viser fejlen og et eksempel på korrekt format. Datoen ligger i fortiden Systemet viser fejlen "Datoen må ikke ligge før i dag". Sluttid ligger før ankomsttid Systemet viser fejlen "Sluttid skal være efter ankomsttid". Den ansvarlige findes ikke Systemet viser fejlen "Vælg en oprettet medarbejder som ansvarlig". |
| Specielle krav | Dato indtastes i det rigtige format. Systemet gemmer kun de persondata, der er nødvendige for besøget (GDPR). |