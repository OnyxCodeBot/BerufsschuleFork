import java.util.Scanner;

public class SchokobonsMR {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Täglich produzierte Bons:");
        int dailyBons = sc.nextInt();

        System.out.println("Packungsgröße:");
        int packGroesse = sc.nextInt();

        System.out.println("Übrig Bleibende Bons:");
        System.out.println(dailyBons % packGroesse);
    }
}
