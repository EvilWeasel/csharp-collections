C# Grundlagen: Arbeiten mit Generic Listen
==========================================

Herzlich Willkommen zum C# Grundlagen Kurs! In dieser Serie von Aufgaben werden wir uns mit den grundlegenden Funktionen der Generic Liste in C# auseinandersetzen. Die Generic Liste ist ein dynamisches Array, das dir ermöglicht, eine geordnete Sammlung von Objekten zu erstellen. Mehr Informationen zu Generic Listen findest du unter: [Verwenden von generic List -- Tutorial: Einführung in C# | Microsoft Learn](https://learn.microsoft.com/de-de/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections)

Aufgaben
--------

### Aufgabe 1: Hinzufügen von Elementen in eine Liste

**Ziel**: Implementiere eine Methode, die eine bestimmte Anzahl von zufälligen Zahlen zu einer Liste hinzufügt.

**Inputs**:

-   Eine Liste von Integers.-   Ein Integer, der die Anzahl der hinzuzufügenden Elemente angibt.

**Outputs**:

-   Eine aktualisierte Liste mit den hinzugefügten Zahlen.

**Funktionssignatur**:

```csharp
public static List<int> AddRandomNumbersToList(List<int> numbers, int quantity)
{
    // Dein Code hier
}

```

**Hinweis**: Nutze die `Random` Klasse um zufällige Zahlen zu generieren.

### Aufgabe 2: Entfernen von Elementen aus einer Liste

**Ziel**: Implementiere eine Methode, die das erste Vorkommen eines spezifischen Elements aus einer Liste entfernt.

**Inputs**:

-   Eine Liste von Integers.-   Ein Integer, der das zu entfernende Element repräsentiert.

**Outputs**:

-   Eine aktualisierte Liste ohne das spezifische Element (falls es gefunden wurde).-   Eine Nachricht, die anzeigt, ob das Element erfolgreich entfernt wurde oder nicht.

**Funktionssignatur**:

```csharp
public static (List<int>, string) RemoveElementFromList(List<int> numbers, int element)
{
    // Dein Code hier
}

```

**Hinweis**: Nutze die `Remove` Methode der List-Klasse.

### Aufgabe 3: Überprüfen, ob ein Element in der Liste vorhanden ist

**Ziel**: Implementiere eine Methode, die überprüft, ob ein bestimmtes Element in der Liste vorhanden ist.

**Inputs**:

-   Eine Liste von Integers.-   Ein Integer, der das zu suchende Element repräsentiert.

**Outputs**:

-   Ein Boolean, der angibt, ob das Element in der Liste gefunden wurde oder nicht.

**Funktionssignatur**:

```csharp
public static bool CheckElementInList(List<int> numbers, int element)
{
    // Dein Code hier
}

```

**Hinweis**: Nutze die `Contains` Methode der List-Klasse.

### Aufgabe 4: Finden des höchsten und niedrigsten Wertes in einer Liste

#### 4.1 Finden des höchsten Wertes in einer Liste

**Ziel**: Implementiere eine Methode, die den höchsten Wert in einer Liste von Ganzzahlen zurückgibt. Wenn die Liste leer ist, sollte 0 zurückgegeben werden.

**Inputs**:

-   Eine Liste von Ganzzahlen (`List<int> numbers`)

**Outputs**:

-   Der höchste Wert in der Liste als `int`.

**Funktionssignatur**:

```
csharpCopy code
`public static int FindMax(List<int> numbers)
{
    // Dein Code hier
}`

```

**Beispiele**:

-   Eingabe: `[3, 5, 2, 8, 1]`-   Ausgabe: `8`

#### 4.2 Finden des niedrigsten Wertes in einer Liste

**Ziel**: Implementiere eine Methode, die den niedrigsten Wert in einer Liste von Ganzzahlen zurückgibt. Wenn die Liste leer ist, sollte 0 zurückgegeben werden.

**Inputs**:

-   Eine Liste von Ganzzahlen (`List<int> numbers`)

**Outputs**:

-   Der niedrigste Wert in der Liste als `int`.

**Funktionssignatur**:

```
csharpCopy code
`public static int FindMin(List<int> numbers)
{
    // Dein Code hier
}`

```

**Beispiele**:

-   Eingabe: `[3, 5, 2, 8, 1]`-   Ausgabe: `1`

### Aufgabe 5: Finden des Mittelwerts einer Liste von Zahlen

**Ziel**: Implementiere eine Methode, die den Mittelwert der Zahlen in einer Liste von Ganzzahlen als Gleitkommazahl zurückgibt. Wenn die Liste leer ist, sollte 0.0 zurückgegeben werden.

**Inputs**:

-   Eine Liste von Ganzzahlen (`List<int> numbers`)

**Outputs**:

-   Der Mittelwert der Zahlen in der Liste als `double`.

**Funktionssignatur**:

```
csharpCopy code
`public static double CalculateAverage(List<int> numbers)
{
    // Dein Code hier
}`

```

**Beispiele**:

-   Eingabe: `[1, 2, 3, 4, 5]`-   Ausgabe: `3.0`