
public class Moped extends KFZ {
	public Moped(String farbe) {
		super.setFarbe(farbe);
	}
	
	@Override
	public void fahren() {
		System.out.println("Moped gibt Gas!");
	}
	
	@Override
	public String getFIN() {
		// TODO Auto-generated method stub
		return null;
	}
}
