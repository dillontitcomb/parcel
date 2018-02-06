namespace ParcelDelivery.Models
{
  public class PackageVariable
  {
    private int _weight;
    private int _speed;

    public int GetWeight()
    {
      return _weight;

    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;

    }

    public int GetSpeed()
    {
      return _speed;

    }

    public void SetSpeed(int newSpeed)
    {
      _speed = newSpeed;
    }

    public int GetCost()
    {
      return ( _weight / 5 + _speed/ 3 ) * 3;
    }

  }
}
