namespace Tools.Earn;
public class LocalEarnfactory : EarnFactory
{
    private decimal  _percetage;

    public LocalEarnfactory( decimal percetage )
    {
         _percetage = percetage; 
    }

    public override IEarn  GetEarn()
    {
        return  new LocalEarn(_percetage);
    }
}