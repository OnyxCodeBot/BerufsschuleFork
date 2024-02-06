import java.util.Locale;
import java.util.Scanner;

public class Jahreszeiten {
    public static void main (String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Geben Sie einen Kalendermonat ein: ");

        String month = sc.nextLine();
        month.trim();
        month.toLowerCase();

        if(month.equals("dezember")
                || month.equals("januar")
                || month.equals("februar")

                || month.equals("12")
                || month.equals("1")
                || month.equals("01")
                || month.equals("2")
                || month.equals("02")){
            System.out.println("winter");
        }
        else if(month.equals("märz")
                || month.equals("april")
                || month.equals("mai")

                || month.equals("3")
                || month.equals("03")
                || month.equals("4")
                || month.equals("04")
                || month.equals("5")
                || month.equals("05")){
            System.out.println("Frühjahr");
        }
        else if(month.equals("juni")
                || month.equals("juli")
                || month.equals("august")

                || month.equals("6")
                || month.equals("06")
                || month.equals("7")
                || month.equals("07")
                || month.equals("8")
                || month.equals("08")){
            System.out.println("Sommer");
        }
        else if(month.equals("september")
                || month.equals("oktober")
                || month.equals("november")

                || month.equals("9")
                || month.equals("09")
                || month.equals("10")
                || month.equals("11")){
            System.out.println("Herbst");
        }
        else{
            System.out.println("ERROR");
        }
    }
}
