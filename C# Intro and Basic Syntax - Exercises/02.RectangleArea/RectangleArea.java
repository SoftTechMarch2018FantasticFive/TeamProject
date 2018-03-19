// CONFIRMED from <denishristov>
// CONFIRMED <NinoBonev> 19.03.2018
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class RectangleArea {
    public static void main(String[] args) throws IOException {
        // Initialize a console reader
        BufferedReader console = new BufferedReader(new InputStreamReader(System.in));

        // Create variables and parse the input data 
        double rectangleWidth = Double.parseDouble(console.readLine());
        double rectangleHeight = Double.parseDouble(console.readLine());

        // Calculate the answer
        double rectangleArea = rectangleHeight * rectangleWidth;

        // Print out the answer rounded to the 2nd digit after the decimal point
        System.out.printf("%.2f", rectangleArea);
    }
}
