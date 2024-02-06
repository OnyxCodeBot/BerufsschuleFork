import java.util.Scanner;

public class Schulnoten {
    public static void main (String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Geben Sie eine Zahl zwischen 1 und 6 ein: ");

        int note = sc.nextInt();

        switch (note) {
            case 1:
                System.out.print("Sehr Gut");
                break;
            case 2:
                System.out.println("Gut");
                break;
            case 3:
                System.out.println("Befriedigend");
                break;
            case 4:
                System.out.println("Ausreichend");
                break;
            case 5:
                System.out.println("Mangelhaft");
                break;
            case 6:
                System.out.println("Ungenügend");
                break;
            default:
                System.out.println("Error");
                break;
        }
    }
}
