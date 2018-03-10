import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class RectangleArea {
    public static void main(String[] args) throws IOException{

        BufferedReader console = new BufferedReader(new InputStreamReader(System.in));

        double rectangleWidth = Double.parseDouble(console.readLine());
        double rectangleHeight = Double.parseDouble(console.readLine());

        double rectangleArea = rectangleHeight * rectangleWidth;

        System.out.printf("%.2f", rectangleArea);
    }
}
