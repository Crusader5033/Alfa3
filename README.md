# Okenní aplikace pro správu služby vojáka

## Obsah

1. **Úvod**
    1.1. Účel Aplikace
    1.2. Předpoklady pro Spuštění

2. **Konfigurační Soubor**
    2.1. Struktura `app.config`
    2.2. Nastavení Připojení do Databáze

3. **Struktura Databáze**
    3.1. Tabulky
    3.2. Pohledy
    3.3. Transakce

4. **Modelování Databáze**
    4.1. Singleton pro Připojení
    4.2. Třídy Controller a Model

5. **Struktura Aplikace**
    5.1. Okenní Okna
    5.2. Funkce Okenních Oken

6. **Spouštění Aplikace**

7. **Vytváření, Čtení, Aktualizace a Mazání (CRUD) Operace**
    7.1. Vytvoření
    7.2. Čtení
    7.3. Aktualizace
    7.4. Mazání

8. **Známé Problémy a Omezení**
    8.1. Work in Progress Funkcionality

## 1. Úvod

### 1.1 Účel Aplikace
Tato okenní aplikace v C# slouží k správě vojáků z povolání v rámci vojenských služeb. Umožňuje zobrazovat, přidávat, mazat a upravovat informace o vojácích, jejich službách, zkouškách, specializacích a útvarech.

### 1.2 Předpoklady pro Spuštění
Pro spuštění aplikace je nezbytné mít nainstalovaný .NET Framework a správně nakonfigurovanou MSSQL databázi.

## 2. Konfigurační Soubor

### 2.1 Struktura `app.config`
Konfigurační soubor `app.config` obsahuje informace potřebné pro připojení k MSSQL databázi. Struktura souboru je následující:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<appSettings>
		<add key="DataSource" value="193.85.203.188"/>
		<add key="Database" value="prochazka6"/>
		<add key="Name" value="prochazka6"/>
		<add key="Password" value="dominik2005"/>
	</appSettings>
</configuration>
```

### 2.2 Nastavení Připojení do Databáze
Výše uvedené hodnoty (`DataSource`, `Database`, `Name`, `Password`) je třeba přizpůsobit aktuálním připojovacím údajům pro MSSQL server.

## 3. Struktura Databáze
![Snímek obrazovky 2024-02-04 201514](https://github.com/Crusader5033/Alfa3/assets/113086006/5423851b-a659-4c7e-8476-c5ff53d6bf7a)
### 3.1 Tabulky
- `Vojaci`: Obsahuje informace o vojácích.
- `Specializace`: Obsahuje informace o vojenských specializacích.
- `Zkousky`: Obsahuje informace o zkouškách, kterým vojáci podstupují.
- `Utvary`: Obsahuje informace o vojenských útvarech.
- `Role`: Obsahuje informace o vojenských rolích.
- `Sluzby`: Obsahuje informace o vojenských službách vojáků.

### 3.2 Pohledy
- `Vojaci_S_Specializacemi`: Pohled spojující informace o vojácích a jejich specializacích.
- `Vojaci_S_Sluzbami`: Pohled spojující informace o vojácích a jejich službách.
### 3.3 Transakce
- Při přidání vojáka lze najednou přidat vojáka a automaticky mu přiřadiť zkoušku na KZP(Kurz základní přípravy).


## 4. Modelování Databáze

### 4.1 Singleton pro Připojení
Pro zajištění efektivního připojení k databázi se využívá singleton třída `DatabaseSingleton`.

### 4.2 Třídy Controller a Model
Pro každou tabulku existuje Controller a Model třída , uživatel pracuje oknem které následně pracuje s Controllerem a následně Model s DB. Například `RoleController` a `Role` pro tabulku `Role` ,.

## 5. Struktura Aplikace
![Výstřižek](https://github.com/Crusader5033/Alfa3/assets/113086006/e798132d-2ade-463d-b80c-1ea692e762f4)

### 5.1 Okenní Okna
Aplikace obsahuje několik okenních oken:
- **Hlavní Okno**: Zobrazuje nabídku oken pro práci s DB.
- **Přidání **: Slouží k přidání nových záznamů do databáze.
- **Smazání **: Slouží ke smazání záznamů z databáze.
- **Výpis **: Obsahuje funkce na výpis záznamů v databázi.
- **Úprava **: Obsahuje funkce na úpravu záznamů v databázi.

### 5.2 Funkce Okenních Oken
Každé okno má specifické funkce pro zobrazení, přidání, úpravu a mazání dat. Okna jsou navržena tak, aby bylo snadné pracovat s jednotlivými entitami.

## 6. Spouštění Aplikace

Pro spuštění aplikace stačí spustit spustitelný soubor (exe) Alfa3.exe ve Alfa3\bin\Debug

## 7. Vytváření, Čtení, Aktualizace a Mazání (CRUD) Operace

Pro většinu entit (voják, specializace, zkouška, útvar, role, služba) jsou implementovány

 funkce pro CRUD operace, umožňující manipulaci s daty v databázi.

### 7.1 Vytvoření
Přidání nových záznamů do databáze je možné pomocí příslušných formulářů v okně pro přidání.

### 7.2 Čtení
Zobrazení dat o vojácích, specializacích, zkouškách, útvarech, rolích a službách se provádí v okně výpis.

### 7.3 Aktualizace
Upravování dat v databázi probíhá v okně úprava.

### 7.4 Mazání
Smazání záznamů lze provést pomocí okna pro smazání, kde je nutné vybrat, který záznam se má odstranit.

## 8. Známé Problémy a Omezení

### 8.1 Work in Progress Funkcionality
Některé části aplikace jsou označeny jako "Work in Progress", což znamená, že jsou ve fázi vývoje a nejsou plně implementovány.

