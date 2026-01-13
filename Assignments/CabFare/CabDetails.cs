using System;

namespace CabFare
{
    public class CabDetails : Cab
    {
        public int perkilometre{set;get;}

        #region validation
        public bool validateBookingId()
        {
            if (bookingID.Length >=6)
            {
                int positionOfSymbol=bookingID.IndexOf("@");
                if (positionOfSymbol != -1)
                {
                    char ifC=bookingID[positionOfSymbol-1];
                    char ifA=bookingID[positionOfSymbol-2];
                    
                    if(ifC.Equals('C') && ifA.Equals('A'))
                    {
                        
                        string subString=bookingID.Substring(positionOfSymbol+1);
                        if (subString.Length==3 && int.TryParse(subString,out int val))
                        {
                            return true; 
                        }
                        
                    }
                }

            }
            return false;
        }
        #endregion


        public double CalculateFareAmount()
        {
            switch (cabType)
            {
                case "Hatchback":
                    {
                        perkilometre=10;
                        break;
                    }
                case "Sedan":
                    {
                        perkilometre=20;
                        break;
                    }
                case "SUV":
                    {
                        perkilometre=30;
                        break;
                    }
            }

            return Math.Floor(perkilometre*distance+Math.Sqrt(waitingTime));
            
        }
        


    }
}
