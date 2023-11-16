
public class main {

	public static void main(String[] args) {
		//Auto toyota = new Auto("1", "Blau");
		//toyota.fahren();
		
		////KFZ kfz = new KFZ();
		//KFZ kfz = new Auto("2", "Rot");
		//System.out.println(((Auto)kfz).downcast());
		
		//Moped intruder = new Moped("Schwarz");
		//intruder.fahren();
		
		//System.out.println(toyota instanceof Bewegen);
		//System.out.println(intruder instanceof Bewegen);
		
		KFZ kfz2 = new Auto("3", "Blau");
		System.out.println(kfz2 instanceof Auto);
		System.out.println(kfz2 instanceof KFZ);
	}
}
