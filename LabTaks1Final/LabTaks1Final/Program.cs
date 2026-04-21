using System;

class Service
{
    protected string uniqueID;
    protected double baseCharge;

    public Service(string uniqueID, double baseCharge)
    {
        this.uniqueID = uniqueID;
        this.baseCharge = baseCharge;
    }

    public double BaseCharge
    {
        get { return baseCharge; }
        set { if(value >=0) baseCharge = value; }
    }

    public virtual double CalculateBill(int usage) { 
        return baseCharge;
    }
}

class StreamingService : Service
{
    private double subDurationl;

    public StreamingService(string uniqueID, double baseCharge, double subDurationl) : base(uniqueID, baseCharge)
    {
        this.subDurationl = subDurationl
           ;
    }

    public override double CalculateBill(int usage)
    {
        if(subDurationl > usage)
        {
            return baseCharge - baseCharge * 0.15;
        }
        else
        {
            return baseCharge;
        }
    }
}


class CloudStorageService : Service
{
    private double storageUsed;
    public CloudStorageService(string uniqueID, double baseCharge, double storageUsed) : base(uniqueID, baseCharge)
    {
        this.storageUsed = storageUsed;
    }
    public override double CalculateBill(int usage)
    {
        if(storageUsed > usage)
        {
            return baseCharge + baseCharge * 0.10;
        }
        else
        {
            return baseCharge;
        }
    }
}