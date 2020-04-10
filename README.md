## House of Code optagelsesprøve

Dette web applikation indeholder en **responsiv (Mobile first)** Umbraco hjemmeside, med egen implementeret design. 
Landing page består en intro tekst, pakker og "call to action", som kan redigeres igennem Umbraco CMS'et.
Login- og registreringssiden validerer brugererens input. Hvis der er fejl, dukker en fejlmeddelelse op, ellers redirecter den brugereren til forsiden.
Alle sider deler en **SEO** og **Hero** component. Forsiden benytter en element til pakkeløsninger, så man ikke gentager sig med fields.

Det er muligt at benytte hjemmesiden uden brug af mus, dvs. via brug af tab (Accessibility).

For styling af siden, blev der benyttet af SASS, hvor den derefter sammen med javaScript blev minificeret af gulp.js.

### Bruger oplysninger
PS! Brugernavn og kode er case sensitive.
| Typer        | Username / e-mail           | Kodeord  |
| ------------- |-------------| -----|
| Database      | HouseOfCode | Password1 |
| Umbraco Login      | erol.bakic@hotmail.com      |   !Admin12345 |

### Mulige forbedringer
- Hjemmesiden benytter sig ikke af en API. Jeg har ikke nok erfaring med API-værk i Umbraco CMS, men har arbejdet med API i WordPress.
- Login og registeringssiden benytter ikke af egen models i MVC. Jeg har haft tekniskse problemer med oprettelse af models og rebuilding, hvilket resulterede i mine filer korrupterede og var nød til at bruge et backup. Login og Registreringsside bruger snippets leveret af Umbraco.
- Hjemmesiden er ikke uploadet på en remote server. Jeg har ikke haft undervisning på skolen om, hvordan man deployer en Umbraco side og fandt ikke en dokumentation/video, der var god nok til at guide mig igennem processen. Jeg har stor interesse i at lære det! Databasen findes på dette repository med navn: **HouseOfCodeFinal.bak**


### Log
- Lørdag - 4. apr | 14:00 - 16:00 (Projektet korrupterede og startede forfra) 18:00 - 20:00 | 4 timer
- Søndag - 5. apr | 12:30 - 17:30 | PAUSE | 18:30 - 21:30 | 7 timer
- Mandag - 6. apr | 13:00 - 17:30 | PAUSE | 18:30 - 22:00 | 9 timer
- Tirsdag - 7. apr | Fri
- Onsdag - 8. apr | 12:30 - 14:30 | PAUSE | 15:00 - 17:00 | 4 timer
- Tosdag - 9. apr | 13:00 - 15:30 | (Login og Signup models og controller mislykkedes) | 2.5 timer
- Fredag - 10. apr | 19:00 - 22:00 | (Web deploy mislykkedes) | 3 timer

Total tid: ca. 29 timer og 30 minutter.

### Billeder af web applikationen
#### Forside
![Forside](https://i.imgur.com/1tTDmhV.png "Forside")
----
#### Login
![Login](https://i.imgur.com/PMVxnXl.png "Login")
----
#### Signup
![Signup](https://i.imgur.com/ZV0xRYq.png "Signup")
