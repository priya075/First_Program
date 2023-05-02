namespace _18AprilDB.Models
{
    public class DAL
    {
        CredProDB_TRN1Context db = new CredProDB_TRN1Context();

        public List<TblUser> GetUsers()
        {
            return db.TblUsers.ToList();
        }
    }
}
