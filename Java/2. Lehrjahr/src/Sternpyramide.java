public class Sternpyramide {
    public static void main(String[] args) {
        int rows = 10;
        int characters = 0;
        String printed = "(ノ°Д°）ノ︵ ┻━┻";

        for(int i = 1; i <= rows; i++){
            if(i == 1)
            {
                characters = 1;
            }
            else{
                characters += 2;
            }

            for(int spaces = (rows - i) * printed.length(); spaces > 0; spaces--){
                System.out.print(" ");
            }

            for(int j = characters; j > 0; j--){
                System.out.print(printed);
            }
            System.out.println();
        }
    }
}
