namespace Codewars._6kyus;

// https://www.codewars.com/kata/5544c7a5cb454edb3c000047

public class BouncingBalls
{
    public static int BouncingBall(double h, double bounce, double window)
    {
        // these conditions must be met for a valid experiment
        if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
            return -1;

        int count = 0;
        h *= bounce;

        while (h > window)
        {
            h *= bounce;
            count++;
        }

        return count * 2 + 1;

        // other solution
        // int result = -1;
        //
        // do{
        //     result+=2;
        //     h*=bounce;
        // }while(h>window);
        //
        // return result;
    }
}
