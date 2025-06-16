import java.util.HashSet;

public class Main {

    public static void main(String... args) {
        int[] array = {-3,2,-1,1,7,2,3,4,5,6};

        System.out.print(firstMissingPositive(array));
    }

    public static int firstMissingPositive(int[] nums) {
        HashSet<Integer> seenNumbers = new HashSet<Integer>();

        for(int num : nums) {
            if(num > 0) {
                seenNumbers.add(num);
            }
        }

        for(int i = 1; i <= nums.length; i++) {
            if(!seenNumbers.contains(i)) {
                return i;
            }
        }

        return nums.length + 1;
    }
}
