using VitHealth.DAL.EFCoreDbContexts;
using VitHealth.DAL.Repositories.Concrete;
using VitHealth.Entities.Concrete;

//!!!!!!PROJE SONUNDA KALDIRILACAK!!!!!!
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title()
            {
                TitleName = "Uzman Doctor",
            };

            RepositoryBase<Title, int, SqlServerDbContext> repositoryBase = new();


            var s = repositoryBase.Delete(3);
            Console.WriteLine(s.Result);
        }
    }
}
