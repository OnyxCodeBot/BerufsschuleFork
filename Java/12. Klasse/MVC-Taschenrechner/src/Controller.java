import java.util.Scanner;

public class Controller {
	public void Start() {
		Scanner scanner = new Scanner(System.in);
		Model model = new Model();
		View view = new View();
		
		while(model.GetLeave() == 'n' || model.GetLeave() == 'N')
		{
			//Display Titel
			view.DisplayMessage("Einfacher Taschenrechner");
		
			//Display Prompt Input Number 1
			view.DisplayMessage("Geben Sie die erste Zahl ein: ");
		
			model.SetZahl1(scanner.nextDouble());
		
			//Display Prompt Input Operator
			view.DisplayMessage("Geben Sie einen Operator (+, -, *, /) ein: ");
		
			model.SetOperator(scanner.next().charAt(0));
		
			//Display Prompt Input Number 2
			view.DisplayMessage("Geben Sie die zweite Zahl ein: ");
		
			model.SetZahl2(scanner.nextDouble());
		
			try {
				model.BerechneErgebnis();
				view.DisplayMessage("Ergebnis: " + model.GetErgebnis());
			} catch (IllegalArgumentException e) {
				view.DisplayMessage(e.getMessage());
			}
		
			view.DisplayMessage("Programm verlassen? (J|N)");
			model.SetLeave(scanner.next().charAt(0));
		}
		scanner.close();
	}
}