package validadordecorreo;

/**
 *
 * @author Jesús Oviedo
 */
public class ValidadordeCorreo {
    
    private static String[] v_Emails;
    
    public static void main(String[] args) {
        v_Emails = new String[]{"test@example.com",
            "test-101@example.com", "test.101@yahoo.com",
            "test101@example.com", "test_101@example.com",
            "test-101@test.net", "test.100@example.com.au", "test@e.com",
            "test@1.com", "test@example.com.com", "test+101@example.com",
            "101@example.com", "test-101@example-test.com", "example", "example@.com.com",
            "exampel101@test.a", "exampel101@.com", ".example@test.com",
            "example**()@test.com", "example@%*.com",
            "example..101@test.com", "example.@test.com",
            "test@example_101.com", "example@test@test.com",
            "example@test.com.a5"};
        
        validator vt = new validator();
        vt.validEmailTest(v_Emails);
    }
}
