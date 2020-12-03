public class PhoneNumber
{
  public static string CreatePhoneNumber(int[] n)
  {
        //(123) 456-7890
        return $"({n[0]}{n[1]}{n[2]}) {n[3]}{n[4]}{n[5]}-{n[6]}{n[7]}{n[8]}{n[9]}";
    }
}