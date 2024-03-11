import java.util.regex.*;

public class Application {
    public static void main(String[] args) {
        Pattern pDomain = Pattern.compile("M[ae][iy]e?r");

        Matcher m = pDomain.matcher("Meier");

        System.out.println(m.matches());
    }
}
