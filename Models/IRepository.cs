namespace ReactMakeMyTripApp.Models
{
    public interface IRepository
    {
        public ReactMakeMyTrip AddReservation(ReactMakeMyTrip makemytrip);

        public ReactMakeMyTrip UpdateReservation(ReactMakeMyTrip makemytrip);

        public void DeleteReservation(int id);

        public IEnumerable<ReactMakeMyTrip> Reservations { get; }

        public ReactMakeMyTrip this[int id] { get; }
    }
}
