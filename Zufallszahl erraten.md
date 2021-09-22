# Zufallszahl erraten

## Aufgabenstllung und Ziele

Im Lernatelier programmierten wir ein kleines Spiel, in dem man eine Zufallszahl erraten kann. Ich werde Ihnen probieren, zu erklären, wie Sie auch so ein Programm erstellen können.

**Ziele**:
1. Erklären wie man einen Loop erstellt.
2. Zeigen, wie man ein Try-Catch gebraucht und warum es wichtig ist.
## Inhalt 1

In einem Programm wie dieser, ist es wichtig, dass man mehrmals eine Zahl erraten kann. Für das braucht es einen Loop, der sich wiederholt, solange die Eingabe des Benutzers nicht der Zufallszahl entspricht, oder vielleicht gar nicht etwas mit dem Programm zu tun hat. Es kann passieren, dass der Benutzer eine Zahl über 100 eingibt, obwohl das Programm nur von 1-100 geht. Manchmal könnte auch passieren, dass man ein Wort eingibt anstatt eine Zahl. In solchen Momenten würde das Programm normalerweise "crashen", also kann man es nicht mehr gebrauchen. Damit das nicht passiert, gibt es den Try-Catch, der solche Fehler auffängt, und mit einem zusätzlichem Loop erlaubt man dem Benutzer, nochmals zu probieren. Ein solcher Loop ist eigentlich einfach zum Programmieren, ich habe einen while-loop gebraucht. Das Wichtige daran ist, dass man nach einer falschen Eingabe nochmals nach eine neue Eingabe fragt, damit der Computer weiss, dass eine neue Nummer gebraucht wird. Also die erste Benutzereingabe wird nach einer falschen Eingabe wieder ersetzt, indem man erneut danach frägt. By try-catch passiert das automatisch, wenn Sie ein while loop mit true in den Klammern schreibt.

## Inhalt 2

Hier ist ein Beispiel,für meinen while-loop, und wie ich nach einer Neueingabe gefragt habe 
![loop userinput](https://github.com/duckud/LA1200/blob/main/screenshot.png?raw=true)

## Inhalt 3

Hier zeige ich die Loop und Try-catch Funktionen meines Programmes
[Youtube Video](https://www.youtube.com/watch?v=UoDT3WSDDbg&ab_channel=luciel)

## Verifikation + Reflektion 

**Reflektion**:
Ich hatte Mühe mit dem Screenshot, da ich nicht wusste wie ich es hier aufladen kann
VBV: Nächstes Mal werde ich das Bild direkt auf github aufladen.

**Verifikation**:
Ziel 1: Ich habe meinem Pultnachbar mein Portfolio gezeigt, *erreicht, jedoch hatte er gesagt, es wäre besser hätte ich die Funktion erklärt.*
Ziel 2: Ich habe es meinem Pultnachbar gezeigt *Warum es wichtig ist, ist klar, der Gebrauch könnte detaillierter sein.*
