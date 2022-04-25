using AddressBook_Problem;

namespace AddressBookSystem
{
    public class SortingClassBase
    {
        public int Compare(ContactDetails x, ContactDetails y)
        {

            switch (Detail)
            {
                case SortingType.NAME:
                    return x.Name.CompareTo(y.Name);
                    break;
                case SortingType.CITY:
                    return x.City.CompareTo(y.City);
                    break;
                case SortingType.STATE:
                    return x.State.CompareTo(y.State);
                    break;
                case SortingType.ZIP:
                    return x.ZipCode.CompareTo(y.ZipCode);
                    break;
                default:
                    break;

            }
            return x.Name.CompareTo(y.Name);
        }
    }
}