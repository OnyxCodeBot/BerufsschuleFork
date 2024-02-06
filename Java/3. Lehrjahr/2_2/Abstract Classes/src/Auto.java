
public class Auto extends KFZ implements Bewegen {
	
	private String FIN;
	
	public Auto(String fin, String farbe) {
		this.FIN = fin;
		super.setFarbe(farbe);
	}
	
	@Override
	public void fahren() {
		System.out.println("Fahren");
	}
	
	@Override
	public String getFIN() {
		return FIN;
	}
	
	@Override
	public String toString() {
		return "Auto FIN: " + getFIN();
	}
	
	public String downcast() {
		return "Downcast erfolgreich!";
	}
}
