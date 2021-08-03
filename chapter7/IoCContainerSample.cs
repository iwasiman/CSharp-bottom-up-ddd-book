public class IoCContainerSample
{
    // 予めIoC Containerで依存解決の設定を登録 これをアプリ起動時に実行されるどこか一箇所のコードで設定。
    var serviceCollection = new ServiceCollection();
    serviceCollection.AddTransient<IUserRepository, InMemoryUserRepository>();
    serviceCollection.AddTransient<UserApplicationService>;

    // サービスクラスのインスタンスをIoC Container経由で取得する
    // 自動でInMemoryUserRepositoryが設定されている。すっごーい！
    var provider = serviceCollection.BuildServiceProvider();
    var userApplicationService = provider.GetService<UserApplicationService>();
}