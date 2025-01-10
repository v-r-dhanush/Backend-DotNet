namespace ReactMakeMyTripApp.Models
{
    public class Repository : IRepository
    {
        private Dictionary<int, ReactMakeMyTrip> items;

        public Repository()
        {
            items = new Dictionary<int, ReactMakeMyTrip>();
            new List<ReactMakeMyTrip>
            {
                new ReactMakeMyTrip{id=1,name="dhanush",startlocation="Perambalur",endlocation="Aranarai"},
                new ReactMakeMyTrip{id=2,name="Ravi",startlocation="Perambalur",endlocation="Devanur"},
                new ReactMakeMyTrip{id=3,name="Sudha",startlocation="Devanur",endlocation="Perambalur"},
                new ReactMakeMyTrip{id=4,name="Sanjana",startlocation="Aranarai",endlocation="Perambalur"},
            }.ForEach(r => AddReservation(r));
        }
        public ReactMakeMyTrip this[int id] => items.ContainsKey(id) ? items[id] : null;

        public IEnumerable<ReactMakeMyTrip> Reservations => items.Values;

        public ReactMakeMyTrip AddReservation(ReactMakeMyTrip makemytrip)
        {
            if (makemytrip.id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key))
                {
                    key++;
                }
                makemytrip.id = key;
            }

            items[makemytrip.id] = makemytrip;
            return makemytrip;
        }

        public void DeleteReservation(int id)
        {
            items.Remove(id);
        }

        public ReactMakeMyTrip UpdateReservation(ReactMakeMyTrip makemytrip)
        {
            return AddReservation(makemytrip);
        }
    }
}
