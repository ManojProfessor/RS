/* dummy code to see how CI/CD works using Azure devops*/
interface ITest
{
   public test ();
}

Class Test :ITest
{
    public void test { 
      System.WriteLine("Testing");
    }
}
