import java.util.HashMap;

public class Main {

	public static void main(String[] args) {
		HashMap<String, String> hashMap = new HashMap<>();
		
		hashMap.put("B", "2");
		hashMap.put("A", "1");
		hashMap.put(null, null);
		hashMap.put(null, "2");
		hashMap.put("a", "1");
		
		hashMap.forEach((key, value) -> System.out.println("Key: " + key + " Value: " + value));
	}

}
