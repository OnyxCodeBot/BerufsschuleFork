import java.util.Arrays;

public class ArrayTest {
    public static void main(String[] args) {

        //Eindimensionales Array
        int[] einDimArr;

        //Werte zuweisen
        int[] wertZuweisen = {1, 2, 3};

        //Zugriff auf Wert
        System.out.println("Zugriff auf Wert: " + wertZuweisen[0]);

        //Länge
        System.out.println("Länge: " + wertZuweisen.length);

        //Wert ändern
        wertZuweisen[1] = 5;

        //Ungültiges Array-Element
        try
        {
            System.out.println(wertZuweisen[100]);
        } catch (ArrayIndexOutOfBoundsException exception)
        {

        }

        //Verschiedene Datentypen
        //int[] verschDatentypen = {1, 5.6, 4, 2.5f, true}; //Nein nicht möglich

        //Initialisieren mit Standard Werten
        einDimArr = new int[10];

        //Array mit Schleife durchlaufen
        for(int i : einDimArr)
        {
            System.out.println("Element " + i + ": " + einDimArr[i]);
        }

        //Größtes Element in einem Array
        int maxWert = wertZuweisen[0];

        for(int i : wertZuweisen)
        {
            if(i > maxWert)
            {
                maxWert = i;
            }
        }
        System.out.println("Max Wert: " + maxWert);

        //Durchschnitt aller Elemente
        int summe = 0;

        for(int i : wertZuweisen)
        {
            summe += wertZuweisen[i];
        }

        System.out.println("Durchschnitt: " + ( summe / wertZuweisen.length ));

        //Vergrößern / Verkleinern
        //Nicht möglich

        //Sortieren
        Arrays.sort(wertZuweisen);

        //Vor- / Nachteile ?????

        //Verwendungszweck
        //Datenspeicherung
    }
}
