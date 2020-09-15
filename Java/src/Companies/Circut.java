import java.util.Collections;
import java.util.HashMap;

public class Circut {
    public static void main(final String[] args) {
        Integer out = MaxWord("hello how are you hello hello");
        System.out.println(out);
    }

    public static Integer MaxWord(final String in) {

        if (in.isEmpty()) {
            return 0;
        }

        HashMap<String, Integer> hm = new HashMap<String, Integer>();

        String[] words = in.split(" ");
        for (String word : words) {
            Integer oldCount = hm.get(word);
            if ( oldCount == null ) {
                oldCount = 0;
            }
            hm.put(word, oldCount + 1);
        }

        Integer maxcount = Collections.max(hm.values(),null);

        return maxcount;
    }

}