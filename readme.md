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

### Aufgabe 4: Finden Sie die zwei Zahlen mit dem kleinsten Abstand

**Ziel**: Implementiere eine Methode, die die zwei Zahlen in einer Liste findet, die den kleinsten Abstand zueinander haben. Der "Abstand" wird als der absolute Unterschied zwischen zwei Zahlen definiert.

**Inputs**:

-   Eine Liste von Integers (mit mindestens 2 Elementen).

**Outputs**:

-   Ein Tuple mit den zwei Zahlen, die den kleinsten Abstand zueinander haben.

**Funktionssignatur**:

```csharp
public static (int, int) FindClosestNumbers(List<int> numbers)
{
    // Dein Code hier
}
```

**Hinweis**: Du könntest überlegen, die Liste zuerst zu sortieren und dann die benachbarten Elemente zu vergleichen.

### Aufgabe 5: Finden Sie die längste Sequenz von aufeinanderfolgenden Zahlen

**Ziel**: Implementiere eine Methode, die die längste Sequenz von aufeinanderfolgenden Zahlen in einer Liste findet. "Aufeinanderfolgend" bedeutet hier, dass der Unterschied zwischen zwei benachbarten Zahlen genau 1 ist.

**Inputs**:

-   Eine Liste von Integers.

**Outputs**:

-   Eine Liste von Integers, die die längste Sequenz von aufeinanderfolgenden Zahlen repräsentiert.

**Funktionssignatur**:

```csharp
public static List<int> FindLongestConsecutiveSequence(List<int> numbers)
{
    // Dein Code hier
}

```

**Hinweis**: Du könntest die Zahlen zunächst sortieren und dann durch die Liste iterieren, während du die längste Sequenz von aufeinanderfolgenden Zahlen trackst.