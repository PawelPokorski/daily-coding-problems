import java.util.Arrays;

public class App {
    static class Pair<A, B> {
        private final A head;
        private final B tail;

        public Pair(A head, B tail) {
            this.head = head;
            this.tail = tail;
        }

        public static <A, B> Pair<A, B> cons(A a, B b) {
            return new Pair<>(a,b);
        }

        public static <A, B> A car(Pair<A, B> pair) {
            return pair.head;
        }

        public static <A, B> B cdr(Pair<A, B> pair) {
            return pair.tail;
        }

        public static void main(String[] args) {

            Pair<Integer, Integer> pair1 = cons(3,4);
            var car1 = car(pair1).toString();
            var cdr1 = cdr(pair1).toString();

            System.out.println("Pair: cons(3,4)");
            System.out.println("car: " + car1 + "; cdr: " + cdr1);

            Pair<Integer[], String> pair2 = cons(new Integer[] { 1,2,3}, "This is a text");
            var car2 = Arrays.toString(car(pair2));
            var cdr2 = cdr(pair2).toString();

            System.out.println("Pair: cons([1,2,3], 'This is a text')");
            System.out.println("car: " + car2 + "; cdr: '" + cdr2 + "'");
        }
    }
}
