using eBook_Library_Service.Models;

namespace eBook_Library_Service.ViewModels
{
    public class WaitingListStatusViewModel
    {
        public Book Book { get; set; } // The book being waited for
        public List<WaitingList> WaitingList { get; set; } // List of users waiting for the book
        public int UserPosition { get; set; } // The current user's position in the waiting list
    }
}
