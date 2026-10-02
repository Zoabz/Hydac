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

