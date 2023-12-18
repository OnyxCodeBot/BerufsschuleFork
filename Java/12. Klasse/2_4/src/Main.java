import java.util.*;

public class Main {

	public static void main(String[] args) {
		ArrayList<String> al = new ArrayList<>();
		al.add("Hans");
		al.add("Bert");
		al.add("Sigi");
		al.add("Xaver");
		al.add("Rudi");
		al.add(3, "Angela");
		
		al.sort(null);
		
		//System.out.println(al.get(3));
		
		
		Set<String> hs = new HashSet<>();
		hs.add("Hans");
		hs.add("Bert");
		hs.add("Rudi");
		hs.add("Bert");
		hs.add("Alfred");
		hs.add("Sepp");
		hs.add("hans");
		
		//System.out.println(hs.size());
		
		/*for(String elem : hs) {
			System.out.println(elem);
		}*/
	}

}
