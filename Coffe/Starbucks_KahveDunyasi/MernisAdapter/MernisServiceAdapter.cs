
using ServiceReference;
using Starbucks_KahveDunyasi.Individuals;
using Starbucks_KahveDunyasi.Interfaces;

namespace Starbucks_KahveDunyasi.MernisAdapter
{
    public class MernisServiceAdapter : IMernisCheck
    {
        public bool CheckIfActualPerson(Customers customers)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            KPSPublicSoapClient client = new KPSPublicSoapClient();

            return client.TCKimlikNoDogrulaAsync(customers.NationalityId, customers.FirstName.ToUpper(),
                customers.LastName.ToUpper(), customers.BirthData.Year);
        }
    }
}