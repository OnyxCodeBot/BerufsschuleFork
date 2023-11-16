
public class BeispielFinal implements InterfaceB, InterfaceC {
	public final int i;
	private final int j = 15;
	private int k = 50;
	
	public BeispielFinal(int v) {
		i = v;
	}

	public int getK() {
		return k;
	}

	public void setK(int k) {
		this.k = k;
	}

	public int getI() {
		return i;
	}

	public int getJ() {
		return j;
	}

	@Override
	public String GetString(String s) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public int GetInt() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public void getT() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void GetC() {
		// TODO Auto-generated method stub
		
	}


}
