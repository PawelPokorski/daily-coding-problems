import java.util.Arrays;

public class App {

    static Integer[] numbers = {1, 2, 3, 4, 5};

    public static void main(String... args) {
        var output = arrayProduct(numbers);
        System.out.println(Arrays.toString(output));
    }

    static Integer[] arrayProduct(Integer[] array) {
        int length = array.length;
        Integer[] productArray = new Integer[length];
        Arrays.fill(productArray, 1);

        for(int i = 0; i < length; i++) {
            for(int j = 0; j < length; j++) {
                if(i != j) {
                    productArray[i] *= array[j];
                }
            }
        }

        return productArray;
    }
}
