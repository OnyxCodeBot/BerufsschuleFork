
public class Model {
	private double zahl1;
	private double zahl2;
	private char operator;
	private double ergebnis = 0;
	
	char leave = 'n';
	
	public double GetErgebnis() {
		return ergebnis;
	}
	
	public char GetLeave() {
		return leave;
	}
	
	
	public void SetZahl1(double num) {
		zahl1 = num;
	}
	
	public void SetZahl2(double num) {
		zahl2 = num;
	}
	
	public void SetOperator(char op) {
		operator = op;
	}
	
	public void SetErgebnis(double num) {
		ergebnis = num;
	}
	
	public void SetLeave(char c) {
		leave = c;
	}
	
	public void BerechneErgebnis() {
		switch (operator) {
		case '+':
			ergebnis = zahl1 + zahl2;
			break;
		case '-':
			ergebnis = zahl1 - zahl2;
			break;
		case '*':
			ergebnis = zahl1 * zahl2;
			break;
		case '/':
			if (zahl2 != 0) {
				ergebnis = zahl1 / zahl2;
			} 
			else {
				throw new IllegalArgumentException("Division durch Null ist nicht erlaubt.");
			}
			break;
		default:
			throw new IllegalArgumentException("Ungültiger Operator.");
	}
	}
}
