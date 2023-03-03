using SingleResApp.Lib;

namespace OpenCloseApp.Lib
{
    public class Shop : VendingMachine
    {
        public Shop()
        {

        }

        public string Open()
        {
            var str = "Shop is opening up for business";

            return str;
        }

        public string Close()
        {
            var str = "Shop is closing down";

            return str;
        }
    }
}
