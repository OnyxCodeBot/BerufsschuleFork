import java.util.Scanner;

public class A1_Tresor {
    public static void main (String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Bitte geben Sie den Pin ein: ");


        if(sc.nextInt() == 615243) {
            System.out.println("Tresor kann geöffnet werden!");
        }
        else {
            System.out.println("Falscher Pin!");
        }
    }
}
