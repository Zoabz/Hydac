**Ny UseCases**  
**Analyse Artefakter**

# **✅**Use case : Opret medarbejder

| Felt | Hvad skriver vi |
| :---- | :---- |
| Nummer | UC01 |
| Use case navn | Opret medarbejder |
| Virkefelt | HYDACs komme-gå-system |
| Niveau | Brugermål |
| Primær aktør | Medarbejder |
| Mål | Medarbejderen opretter en ny bruger med navn og kode, så vedkommende kan bruge systemet og stå ansvarlig for gæstebesøg. |
| Interessenter | Medarbejder: Vil hurtigt kunne komme i gang uden at vente på IT. Reception: Vil kunne slå op, hvem der er ansvarlig for et besøg. HYDAC: Vil kunne dokumentere, hvem der har adgang til systemet. |
| Før-tilstand | Medarbejderen er ikke oprettet i forvejen. Men der findes en default administrativ bruger. |
| Efter-tilstand | Medarbejderen er gemt med navn og kode og fremgår af medarbejderlisten. Medarbejderen kan vælges som ansvarlig på et besøg. Medarbejderen kan logge ind. |
| Hovedscenarie | Medarbejdere logger ind med "administrative" brugere. Medarbejderen vælger at oprette en ny medarbejder. Systemet beder om navn og kode. Medarbejderen indtaster navn og kode. Systemet gemmer medarbejderen, viser beskeden "Medarbejder oprettet" og tilføjer den til medarbejderlisten. |
| Udvidelser | Medarbejderen fortryder Systemet gemmer ikke medarbejderen og vender tilbage til menuen. Navn er ikke udfyldt Systemet viser fejlen "Navn skal udfyldes". Kode er ikke udfyldt eller for kort Systemet viser fejlen og kravet til koden. Medarbejderen findes allerede Systemet viser fejlen "Medarbejderen findes allerede". |
| Specielle krav | Koden må ikke gemmes eller vises i klartekst. Systemet gemmer kun de persondata, der er nødvendige (GDPR). |

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

# **✅**Use case : Vis medarbejderliste

| Felt | Hvad skriver vi |
| :---- | :---- |
| Nummer | UC03 |
| Use case navn | Vis medarbejderliste |
| Virkefelt | HYDACs komme-gå-system |
| Niveau | Sub Funktion (delmål – indgår i UC02) |
| Primær aktør | Medarbejder |
| Mål | Medarbejderen får vist de oprettede medarbejdere. |
| Interessenter | HYDAC: Vil have overblik over, hvem der er oprettet i systemet. |
| Før-tilstand | Der er oprettet mindst én medarbejder i systemet (UC01). |
| Efter-tilstand | Listen over medarbejdere er vist. |
| Hovedscenarie | Medarbejderen vælger at se medarbejderlisten Systemet finder de medarbejdere, der er oprettet Systemet viser medarbejderlisten med navn. |
| Udvidelser | Medarbejderen fortryder Systemet vender tilbage til menuen uden at vise listen. Der angives intet navn Systemet viser alle oprettede medarbejdere. Ingen medarbejdere matcher søgningen Systemet viser beskeden "Ingen medarbejdere fundet". Der er ingen medarbejdere i systemet Systemet viser beskeden "Der er endnu ikke oprettet nogen medarbejdere". |
| Specielle krav | Koder vises aldrig på listen. Listen viser kun de oplysninger, der er nødvendige for at identificere den ansvarlige (GDPR). |

# **✅**Use case : Vis gæsteliste

| Felt | Hvad skriver vi |
| :---- | :---- |
| Nummer | UC04 |
| Use case navn | Vis gæsteliste |
| Virkefelt | HYDACs komme-gå-system |
| Niveau | Brugermål |
| Primær aktør | Medarbejder (typisk receptionen) |
| Mål | Medarbejderen får vist de registrerede besøg med navn, firma, ankomsttid, afgangstid, dato og ansvarlig, så dagens gæster og personer i huset kan overskues. |
| Interessenter | Reception: Vil have en korrekt og læsbar liste over dagens forventede gæster. Beredskab/AMO: Vil kunne se, hvem der er i huset, ved en evakuering. Medarbejder: Vil kunne kontrollere, at sit eget besøg er registreret rigtigt. HYDAC: Vil kunne dokumentere besøg bagudrettet. |
| Før-tilstand | Der er oprettet mindst ét besøg i systemet (UC02). |
| Efter-tilstand | Gæstelisten er vist. |
| Hovedscenarie | Medarbejderen vælger at se gæstelisten. Systemet finder de registrerede besøg. Systemet viser gæstelisten med navn, firma, ankomsttid, afgangstid, dato, ansvarlig og status. |
| Udvidelser | Medarbejderen fortryder Systemet vender tilbage til menuen uden at vise listen  Der er ingen besøg på den valgte dato Systemet viser beskeden "Ingen forventede gæster". Datoen har forkert format Systemet viser fejlen og et eksempel på korrekt format. |
| Specielle krav | Listen skal læses hurtigt ved en evakuering. Systemet viser kun de persondata, der er nødvendige for besøget (GDPR). |

# **✅**Use case : Tjek gæst ind

| Felt | Hvad skriver vi |
| :---- | :---- |
| Nummer | UC05 |
| Use case navn | Tjek gæst ind |
| Virkefelt | HYDACs komme-gå-system |
| Niveau | Brugermål |
| Primær aktør | Medarbejder |
| Mål | Medarbejderen registrerer, at gæsten er ankommet og har modtaget sikkerhedsfolderen, så besøgets status bliver "Tjekket Ind" og listen over personer i huset er korrekt. |
| Interessenter | Gæst: Vil tages hurtigt imod og vide, hvordan der skal forholdes ved en alarm. Reception: Vil kunne se, hvem der rent faktisk er ankommet. Beredskab/AMO: Vil have, at kun faktisk ankomne personer står på listen over personer i huset, og at det er dokumenteret, at sikkerhedsfolderen er udleveret. HYDAC: Vil kunne dokumentere ankomsttidspunkt og udlevering af sikkerhedsinformation. |
| Før-tilstand | Besøget er oprettet (UC02) og har status "Ikke Tjekket Ind". Gæsten er ankommet til receptionen. |
| Efter-tilstand | Besøget har status "Tjekket Ind". Det er registreret, om gæsten har modtaget sikkerhedsfolderen. Gæsten indgår i listen over personer i huset. |
| Hovedscenarie | Medarbejderen indtaster gæstens indtjekning kode. Systemet finder besøget og spørger, om sikkerhedsfolderen er modtaget (ja/nej). Medarbejderen svarer på, om folderen er modtaget. Systemet gemmer svaret, ændrer besøgets status til "Tjekket Ind" og viser bekræftelsen. |
| Udvidelser | Medarbejderen fortryder Systemet ændrer ikke status og vender tilbage til  menuen. Indtjekning Koden findes ikke Systemet viser fejlen "Besøget blev ikke fundet". Besøget er allerede tjekket ind Systemet viser beskeden "Gæsten er allerede tjekket ind" og ændrer ikke status. Besøget er allerede tjekket ud Systemet viser beskeden "Besøget er afsluttet". Gæsten har ikke modtaget sikkerhedsfolderen Systemet registrerer "nej" og gør medarbejderen opmærksom på, at folderen skal udleveres. |
| Specielle krav | Indtjekning skal kunne gennemføres hurtigt i receptionen. Systemet gemmer kun de persondata, der er nødvendige for besøget (GDPR). |

# **✅Use case : Tjek gæst ud**

| Felt | Hvad skriver vi |
| :---- | :---- |
| Nummer | UC06 |
| Use case navn | Tjek gæst ud |
| Virkefelt | HYDACs komme-gå-system |
| Niveau | Brugermål |
| Primær aktør | Medarbejder |
| Mål | Medarbejderen registrerer, at gæsten har forladt virksomheden, så besøget afsluttes og gæsten ikke længere står som værende i huset. |
| Interessenter | Gæst: Vil kunne gå hjem uden besvær. Reception: Vil have en liste, der kun indeholder de gæster, der faktisk er i huset. Beredskab/AMO: Vil ikke lede efter personer, der for længst er gået hjem. HYDAC: Vil kunne dokumentere, hvornår besøget sluttede. |
| Før-tilstand | Besøget har status "Tjekket Ind" (UC05). Gæsten er på vej ud af virksomheden. |
| Efter-tilstand | Besøget har status "Tjekket Ud". |
| Hovedscenarie | Medarbejderen indtaster gæstens indtjekningskode. Systemet finder besøget og ændrer status til "Tjekket Ud". Systemet viser bekræftelsen. |
| Udvidelser | Medarbejderen fortryder Systemet ændrer ikke status og vender tilbage til menuen. Indtjekningskoden findes ikke Systemet viser fejlen "Besøget blev ikke fundet". Besøget er ikke tjekket ind Systemet viser beskeden "Gæsten er ikke tjekket ind" og ændrer ikke status. Besøget er allerede tjekket ud Systemet viser beskeden "Gæsten er allerede tjekket ud". Gæsten er ikke tjekket ud ved dagens slutning Systemet markerer besøget, så receptionen kan følge op. |
| Specielle krav | Udtjekning skal kunne gennemføres hurtigt. Systemet gemmer kun de persondata, der er nødvendige for besøget (GDPR). |

