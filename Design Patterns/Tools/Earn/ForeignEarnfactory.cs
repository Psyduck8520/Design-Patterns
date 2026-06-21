namespace Tools.Earn;

public class ForeignEarnfactory : EarnFactory
{
     private  decimal  _percentage;
     private  decimal  _extra;
     public ForeignEarnfactory(decimal percentage, decimal extra)
     {
          _percentage = percentage;
          _extra = extra;
     }
     
    public override IEarn GetEarn()
    {
         return new ForeignEarn(_percentage, _extra);
    }
}