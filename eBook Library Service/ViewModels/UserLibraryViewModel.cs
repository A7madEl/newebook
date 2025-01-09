using eBook_Library_Service.Models;

namespace eBook_Library_Service.ViewModels
{
    public class UserLibraryViewModel
    {
        public List<Borrow> BorrowedBooks { get; set; }
        public List<WaitingList> WaitingListEntries { get; set; }
    }
}
