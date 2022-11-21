namespace BasicWebApp.Services;

public class CommonCounter : ICounter
{
    private int current ;
    public int SimpleInterest(int p,int r,int n)
    {
        return((p*n*r)/100);
        
    }
}