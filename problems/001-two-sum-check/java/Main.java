import java.util.HashSet;
import java.util.Scanner;

public class Main {

    static Integer[] numbers = {10, 15, 3, 7};

    public static void main(String... args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter the number k: ");
        
        if (scanner.hasNextInt()) {
            Integer k = scanner.nextInt();
            System.out.println(checkSum(k));
        } else {
            System.out.println("Invalid input.");
        }

        scanner.close();
    }

    static boolean checkSum(Integer k) {
        HashSet<Integer> seenNumbers = new HashSet<>();

        for (Integer number : numbers) {
            int complement = k - number;
            if (seenNumbers.contains(complement)) {
                return true;
            }
            seenNumbers.add(number);
        }

        return false;
    }
}
