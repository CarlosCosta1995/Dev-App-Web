using Teste.Models;

namespace Teste.Data
{
    public static class StoreExtension
    {
        public static void CreateDbIfNotExists(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<StoreContext>();

                //Create Db if not exists
                if (context.Database.EnsureCreated())
                {
                    StoreDBInitializer.InsertData(context);
                }
            }
        }
    }
}
