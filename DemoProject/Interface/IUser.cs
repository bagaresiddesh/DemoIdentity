namespace DemoProject.Interface
{
    public interface IUser
    {
        void DeleteById(int Id);
        int UpdateById(int Id);
        void GetAll();
        int Count();
    }
}
