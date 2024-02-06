import java.util.Scanner;

public class EinfacherTaschenrechner {
    public static void main (String[] args) {
        Scanner sc = new Scanner(System.in);

        double ergebnis = 0;

        //Input
        System.out.println("Zahl 1:");
        double zahl1 = sc.nextDouble();

        System.out.println("Operand:");
        sc.skip("Operand:");
        String operand = sc.nextLine();

        System.out.println("Zahl 2:");
        double zahl2 = sc.nextDouble();


        switch (operand) {
            case "+":
                ergebnis = zahl1 + zahl2;
                break;
            case "-":
                ergebnis = zahl1 - zahl2;
                break;
            case "/":
                if (zahl2 == 0){
                    System.out.println("Division durch 0 nicht erlaubt!");
                }
                else {
                    ergebnis = zahl1 / zahl2;
                }
                break;
            case "*":
                ergebnis = zahl1 * zahl2;
                break;
            default:
                System.out.println("Ungültiger Operand");
        }
    }
}
