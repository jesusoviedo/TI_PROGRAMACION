/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package validadordecorreo;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 *
 * @author Jesús Oviedo
 */
public class validator {

    private static final String PATTERN_EMAIL = "^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@"
            + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$";

    public static boolean validateEmail(String email) {
        // Compiles the given regular expression into a pattern.
        Pattern pattern = Pattern.compile(PATTERN_EMAIL);

        // Match the given input against this pattern
        Matcher matcher = pattern.matcher(email);
        return matcher.matches();
    }

    public void validEmailTest(String[] validEmails) {
        for (String temp : validEmails) {
            boolean valid = validator.validateEmail(temp);
            System.out.println("Email is valid : " + temp + " , " + valid);
        }
    }
}
