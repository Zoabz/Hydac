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